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
		static List<ProfinetS7> connections = new List<ProfinetS7>();
		static List<BigBagModel> dataProfinet;

		public static async Task ProfinetTask()
		{
			try
			{
				var config = new ConfigurationBuilder().AddJsonFile("configuration.json").Build();

				// data folders and logging
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


				// read data loop
				while (true)
				{
					dataProfinet = new List<BigBagModel>();

					// test
					dataProfinet.Add(new BigBagModel
					{
						Zariadenie = 1,
						Program = 1,
						Uzivatel = 1,
						Vaha = 555.5f,
						Cas = DateTime.Now,
					});

					foreach (var connection in connections)
					{
						try
						{
							var data = connection.ReadData();
							if (data != null)
							{
								dataProfinet.AddRange(data);
							}
						}
						catch (Exception ex)
						{
							Library.WriteLog(ex);
						}
					}

					if (dataProfinet.Count() > 0)
					{
						var zaznamy = dataProfinet.Select(e => new Zaznam()
						{
							ZariadenieCislo = e.Zariadenie,
							//ZariadenieId = e.Zariadenie,
							ProgramCislo = e.Program,
							//ProgramId = e.Program,
							UzivatelCislo = e.Uzivatel,
							//UzivatelId = e.Uzivatel,
							Vaha = e.Vaha,
							Cas = e.Cas,
							Rok = e.Rok,
							Mesiac = e.Mesiac,
							Den = e.Den,
							Hodiny = e.Hodiny,
							Minuty = e.Minuty
						});

						using (var dbContext = new BigBagDbContext(optionsBuilder.Options))
						{
							await dbContext.Zaznamy.AddRangeAsync(zaznamy);
							await dbContext.SaveChangesAsync();
						}
					}

					await Task.Delay(5000);
				}
			}
			catch (Exception ex)
			{
				Library.WriteLog(ex);
			}
		}
	}
}
