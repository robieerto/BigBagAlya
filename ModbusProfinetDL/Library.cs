using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ModbusProfinetDL
{
	public static class Library
	{
		public static string dataPath;

		public static void Initialize(string pathData)
		{
			dataPath = pathData;
			if (!Directory.Exists(dataPath))
			{
				Directory.CreateDirectory(dataPath);
			}
		}

		public static void WriteLog(Exception ex)
		{
			try
			{
				using (var sw = new StreamWriter(dataPath + "\\log.txt", true))
				{
					sw.WriteLine(DateTime.Now.ToString() + ": " + ex.Source.ToString().Trim() + "; " + ex.Message.ToString().Trim());
				}

			}
			catch
			{
			}
		}

		public static void WriteLog(string Message)
		{
			try
			{
				using (var sw = new StreamWriter(dataPath + "\\log.txt", true))
				{
					sw.WriteLine(DateTime.Now.ToString() + ": " + Message);
				}
			}
			catch
			{
			}
		}

		public static void WriteLastTime()
		{
			try
			{
				using (var sw = new StreamWriter(dataPath + "\\lastTimeData.txt", false))
				{
					sw.WriteLine(DateTime.Now.ToString() + ": Posledne vycitane data");
				}
			}
			catch
			{
			}
		}
	}
}
