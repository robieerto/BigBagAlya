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
		static List<BigBagModel> dataProfinet;
		static readonly bool vycitajData1 = int.Parse(ConfigurationManager.AppSettings["vycitajData1"]) != 0;

		public static void ProfinetTask()
		{
			while (vycitajData1)
			{
				try
				{
					dataProfinet = ProfinetS7.ReadData();
					if (dataProfinet != null)
					{
						CsvLayer.SaveBigBagData(dataProfinet);
					}
				}
				catch (Exception ex)
				{
					Library.WriteLog(ex);
				}

				Task.Delay(2000);
			}
		}
	}
}
