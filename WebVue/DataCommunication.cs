using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ModbusProfinetDL;
using ModbusProfinetDL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebVue.DAL;
using WebVue.Models;

namespace WebVue
{
	public static class DataCommunication
	{
		static DbContextOptionsBuilder<BigBagDbContext> optionsBuilder;
		static List<BigBagModel> dataProfinet;
		public static List<ProfinetS7> connections = new List<ProfinetS7>();

		public static bool Initialization()
		{
			try
			{
				var config = new ConfigurationBuilder().AddJsonFile("configuration.json").Build();

				// data folders and logging
				CsvLayer.filename = "dataVaha";
				var dataPath = config.GetSection("PathData").Value;
				if (dataPath == null || dataPath.Length == 0)
				{
					dataPath = AppDomain.CurrentDomain.BaseDirectory + "\\data";
				}
				Library.Initialize(dataPath);
				Library.WriteLog("Sluzba bola spustena");

				// profinet connections
				for (var i = 1; ; i++)
				{
					var device = config.GetSection($"Device{i}");
					var readData = device.GetSection("ReadData").Value;
					if (readData == null)
					{
						break;
					}
					if (Convert.ToBoolean(readData))
					{
						var ipAddress = device.GetSection("IpAddress").Value;
						var port = int.Parse(device.GetSection("Port").Value);
						connections.Add(new ProfinetS7(ipAddress, port, i));
					}
				}

				// database connection
				var appSettings = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
				optionsBuilder = new DbContextOptionsBuilder<BigBagDbContext>();
				optionsBuilder.UseSqlServer(appSettings.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value);

			}
			catch (Exception ex)
			{
				Library.WriteLog(ex);

				return false;
			}

			return true;
		}

		public static async Task ProfinetTask()
		{
			try
			{
				if (Initialization() == false)
				{
					return;
				}

				// read data loop
				while (true)
				{
					dataProfinet = new List<BigBagModel>();

					foreach (var connection in connections)
					{
						try
						{
							var data = await connection.ReadData(2694, 2);
							if (data != null)
							{
								dataProfinet.AddRange(data);
							}

							var programy = await connection.ReadArray(10, 6, "4.0");
							var uzivatelia = await connection.ReadArray(30, 710, "4.1");

							if (programy != null || uzivatelia != null)
							{
								using var dbContext = new BigBagDbContext(optionsBuilder.Options);
								if (programy != null)
								{
									await dbContext.Programy
										.Where(e => e.ZariadenieId == connection.zariadenie)
										.ForEachAsync(e =>
										{
											if (e.Cislo != null) e.Nazov = programy[(int)e.Cislo];
										});

								}
								if (uzivatelia != null)
								{
									await dbContext.Uzivatelia
										.Where(e => e.ZariadenieId == connection.zariadenie)
										.ForEachAsync(e =>
										{
											if (e.Cislo != null) e.Nazov = uzivatelia[(int)e.Cislo];
										});

								}

								await dbContext.SaveChangesAsync();
							}
						}
						catch (Exception ex)
						{
							Library.WriteLog(ex);
						}
					}

					if (dataProfinet.Count > 0)
					{
						var zaznamy = dataProfinet
							.Select(e =>
							{
								DateTime casVazenia;
								try
								{
									casVazenia = new DateTime(e.Rok, e.Mesiac, e.Den, e.Hodiny, e.Minuty, 0);
								}
								catch (Exception)
								{
									casVazenia = new DateTime();
								}

								return new Zaznam()
								{
									ZariadenieId = e.Zariadenie,
									ZariadenieCislo = e.Zariadenie - 1,
									ProgramCislo = e.Program,
									UzivatelCislo = e.Uzivatel,
									Vaha = e.Vaha,
									CasVycitania = e.Cas,
									CasVazenia = casVazenia,
									Rok = e.Rok,
									Mesiac = e.Mesiac,
									Den = e.Den,
									Hodiny = e.Hodiny,
									Minuty = e.Minuty
								};
							})
							.ToList();

						using var dbContext = new BigBagDbContext(optionsBuilder.Options);
						var programy = dbContext.Programy;
						var uzivatelia = dbContext.Uzivatelia;
						zaznamy.ForEach(e =>
						{
							var programNazov = programy.Where(p => p.ZariadenieId == e.ZariadenieId && p.Cislo == e.ProgramCislo).FirstOrDefault()?.Nazov;
							var uzivatelNazov = uzivatelia.Where(p => p.ZariadenieId == e.ZariadenieId && p.Cislo == e.UzivatelCislo).FirstOrDefault()?.Nazov;
							e.ProgramNazov = programNazov;
							e.UzivatelNazov = uzivatelNazov;
						});
						await dbContext.Zaznamy.AddRangeAsync(zaznamy);
						await dbContext.SaveChangesAsync();

						foreach (var connection in connections)
						{
							await connection.SetBitDataWereRead();
						}
					}

					await Task.Delay(1000);
				}
			}
			catch (Exception ex)
			{
				Library.WriteLog(ex);
			}
		}
	}
}
