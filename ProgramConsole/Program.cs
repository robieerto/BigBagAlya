﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModbusProfinetDL;

namespace ProgramConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			CsvLayer.filename = "dataVaha";
			Library.Initialize(AppDomain.CurrentDomain.BaseDirectory + "\\data");

			Task.Run(() => DataCommunication.ProfinetTask());
			Console.ReadKey();
		}
	}
}
