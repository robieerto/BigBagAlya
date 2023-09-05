using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModbusProfinetDL.Models;
using S7.Net;

namespace ModbusProfinetDL
{
	public static class ProfinetS7
	{
		private static string ipAddr = ConfigurationManager.AppSettings["ipAdresa1"];
		private static int ipPort = int.Parse(ConfigurationManager.AppSettings["port1"]);
		private static short rack = 0;
		private static short slot = 1;
		private static Plc plc = new Plc(CpuType.S71200, ipAddr, ipPort, rack, slot);
		private static int db = 5;
		private static int zariadenie = 0;

		public static bool isConnected = true;

		public static List<BigBagModel> ReadData()
		{
			try
			{
				if (plc.IsConnected == false)
				{
					try
					{
						plc.Open();
						Library.WriteLog("Profinet pripojeny");
					}
					catch (Exception ex)
					{
						if (isConnected)
						{
							Library.WriteLog("Spojenie Profinet neuspesne:");
							Library.WriteLog(ex);
						}
						isConnected = false;
						return null;
					}
				}
				isConnected = true;

				int bufferCount = (ushort)plc.Read($"DB{db}.DBW2");
				if (bufferCount < 1)
				{
					return null;
				}

				var data = new List<BigBagModel>();
				var dbw = 4;
				for (var i = 0; i < bufferCount; i++)
				{
					data.Add(new BigBagModel()
					{
						Cas = DateTime.Now,
						Zariadenie = zariadenie,
						Program = (ushort)plc.Read($"DB{db}.DBW{dbw}"),
						Uzivatel = (ushort)plc.Read($"DB{db}.DBW{dbw + 2}"),
						Vaha = (ushort)plc.Read($"DB{db}.DBW{dbw + 4}") / 10.0f,
						Rok = (ushort)plc.Read($"DB{db}.DBW{dbw + 6}"),
						Mesiac = (ushort)plc.Read($"DB{db}.DBW{dbw + 8}"),
						Den = (ushort)plc.Read($"DB{db}.DBW{dbw + 10}"),
						Hodiny = (ushort)plc.Read($"DB{db}.DBW{dbw + 12}"),
						Minuty = (ushort)plc.Read($"DB{db}.DBW{dbw + 14}"),
					});

					dbw += 16;
				}

				plc.Write($"DB{db}.DBX0.0", true);

				return data;
			}
			catch (Exception ex)
			{
				Library.WriteLog(ex);
				return null;
			}
		}
	}
}
