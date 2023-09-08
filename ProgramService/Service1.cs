﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using ModbusProfinetDL;
using System.Timers;
using System.IO;

namespace ProgramService
{
	public partial class BetonarkaModbusProfinet : ServiceBase
	{
		private Timer timer1 = null;

		public BetonarkaModbusProfinet()
		{
			InitializeComponent();
		}

		protected override void OnStart(string[] args)
		{
			timer1 = new Timer();
			this.timer1.Interval = 60000; //every 1 min
			this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Tick);
			timer1.Enabled = true;

			CsvLayer.filename = "dataVaha";
			Library.Initialize(AppDomain.CurrentDomain.BaseDirectory + "\\data");

			Task.Run(() => DataCommunication.ProfinetTask());
		}

		private void timer1_Tick(object sender, ElapsedEventArgs e)
		{
		}

		protected override void OnStop()
		{
			timer1.Enabled = false;
			Library.WriteLog("Sluzba bola stopnuta");
		}
	}
}
