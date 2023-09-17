using ModbusProfinetDL.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModbusProfinetDL
{
	public static class DataCommunication
	{
		public static List<BigBagModel> dataProfinet;
		public static ProfinetS7 profinet;

		public static void ProfinetTask()
		{
			try
			{
				Library.WriteLog("Sluzba bola spustena");
				profinet = new ProfinetS7("192.168.1.100", 8881, 1);

				while (true)
				{
					try
					{
						dataProfinet = profinet.ReadData(2694, 2);
						if (dataProfinet != null)
						{
							CsvLayer.SaveBigBagData(dataProfinet);
						}
					}
					catch (Exception ex)
					{
						Library.WriteLog(ex);
					}

					Task.Delay(3000);
				}
			}
			catch (Exception ex)
			{
				Library.WriteLog(ex);
			}

		}
	}
}
