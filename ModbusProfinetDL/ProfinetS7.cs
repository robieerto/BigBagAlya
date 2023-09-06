using System;
using System.Collections.Generic;
using ModbusProfinetDL.Models;
using S7.Net;

namespace ModbusProfinetDL
{
	public class ProfinetS7
	{
		private readonly short _rack = 0;
		private readonly short _slot = 1;
		private readonly int _db = 5;
		private string _ipAddr;
		private int _port;
		private int _zariadenie;
		private Plc _plc;

		public bool isConnected = true;

		public ProfinetS7(string ipAddr, int port, int zariadenie)
		{
			_ipAddr = ipAddr;
			_port = port;
			_zariadenie = zariadenie;
			_plc = new Plc(CpuType.S71200, ipAddr, port, _rack, _slot);
		}

		public List<BigBagModel> ReadData()
		{
			try
			{
				if (_plc.IsConnected == false)
				{
					try
					{
						_plc.Open();
						Library.WriteLog("Profinet pripojeny");
					}
					catch (Exception ex)
					{
						if (isConnected)
						{
							Library.WriteLog($"Spojenie Profinet zariadenie {_zariadenie} neuspesne:");
							Library.WriteLog(ex);
						}
						isConnected = false;
						return null;
					}
				}
				isConnected = true;

				int bufferCount = (ushort)_plc.Read($"DB{_db}.DBW2");
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
						Zariadenie = _zariadenie,
						Program = (ushort)_plc.Read($"DB{_db}.DBW{dbw}"),
						Uzivatel = (ushort)_plc.Read($"DB{_db}.DBW{dbw + 2}"),
						Vaha = (ushort)_plc.Read($"DB{_db}.DBW{dbw + 4}") / 10.0f,
						Rok = (ushort)_plc.Read($"DB{_db}.DBW{dbw + 6}"),
						Mesiac = (ushort)_plc.Read($"DB{_db}.DBW{dbw + 8}"),
						Den = (ushort)_plc.Read($"DB{_db}.DBW{dbw + 10}"),
						Hodiny = (ushort)_plc.Read($"DB{_db}.DBW{dbw + 12}"),
						Minuty = (ushort)_plc.Read($"DB{_db}.DBW{dbw + 14}"),
					});

					dbw += 16;
				}

				_plc.Write($"DB{_db}.DBX0.0", true);

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
