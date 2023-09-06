using System;
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
			var dataPath = AppDomain.CurrentDomain.BaseDirectory + "\\data";
			Library.Initialize(dataPath);
			Library.WriteLog("Sluzba bola spustena");

			Task.Run(() => DataCommunication.ProfinetTask());
			Console.ReadKey();
		}
	}
}
