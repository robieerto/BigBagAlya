using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CsvHelper;
using System.Globalization;
using ModbusProfinetDL.Models;
using CsvHelper.Configuration;
using System.Configuration;

namespace ModbusProfinetDL
{
	public static class CsvLayer
	{
		public const string dateFormat = "dd-MM-yyyy";
		public const string dateTimeFormat = "HH:mm:ss dd-MM-yyyy";
		public const string dateTimeFormatCsv = "HH:mm:ss_dd-MM-yyyy";

		public static string lastTime;

		private static string GetSavePath(DateTime now)
		{
			var ci = new CultureInfo("en-US");
			var currYear = now.ToString("yyyy");
			var currMonth = now.ToString("MMMM", ci);
			var currDate = now.ToString(dateFormat);
			var savePath = $"{Library.dataPath}\\{currYear}\\{currMonth}\\{currDate}";
			return savePath;
		}

		public static void SaveData<T>(List<T> data, string filePath)
		{
			var config = new CsvConfiguration(CultureInfo.CurrentCulture)
			{
				HasHeaderRecord = (File.Exists(filePath) == false),
			};

			try
			{
				using (var stream = File.Open(filePath, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
				using (var writer = new StreamWriter(stream))
				using (var csv = new CsvWriter(writer, config))
				{
					csv.WriteRecords(data);
				}
			}
			catch (Exception ex)
			{
				Library.WriteLog("Zapis do CSV suboru zlyhal:");
				Library.WriteLog(ex);
			}
		}

		public static void SaveBigBagData(List<BigBagModel> data)
		{
			var currDateTime = DateTime.Now;
			lastTime = currDateTime.ToString(dateTimeFormat);
			var savePath = GetSavePath(currDateTime);
			if (!Directory.Exists(savePath))
			{
				Directory.CreateDirectory(savePath);
			}

			var filePath = $"{savePath}\\dataVaha.csv";
			SaveData(data, filePath);
		}
	}
}
