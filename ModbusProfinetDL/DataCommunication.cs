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
		public static void ProfinetTask()
		{
			List<BigBagModel> dataProfinet;
			var profinet = new ProfinetS7("192.168.1.100", 8881, 1);

			while (true)
			{
				try
				{
					dataProfinet = profinet.ReadData();
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
