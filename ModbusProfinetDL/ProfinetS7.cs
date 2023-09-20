using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
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
		private Plc _plc;

		public int zariadenie;
		public bool isConnected = true;
		public float? vaha = null;

		public ProfinetS7(string ipAddr, int port, int zariadenie)
		{
			this.zariadenie = zariadenie;
			_ipAddr = ipAddr;
			_port = port;
			_plc = new Plc(CpuType.S71200, ipAddr, port, _rack, _slot);
		}

		public bool CheckConnection()
		{
			if (_plc.IsConnected == false)
			{
				try
				{
					_plc.Open();
					Library.WriteLog("Profinet pripojeny");
					isConnected = true;
				}
				catch (Exception ex)
				{
					if (isConnected)
					{
						Library.WriteLog($"Spojenie Profinet zariadenie {zariadenie} neuspesne:");
						Library.WriteLog(ex);
					}
					isConnected = false;
				}
			}
			return isConnected;
		}

		public List<BigBagModel> ReadData(int startDbw, int countDbw)
		{
			try
			{
				if (CheckConnection() == false)
				{
					vaha = null;
					return null;
				}

				vaha = (uint)_plc.Read($"MD508") / 10.0f;
				if (vaha > 10000)
				{
					vaha = 0;
				}

				int bufferCount = (ushort)_plc.Read($"DB{_db}.DBW{countDbw}");
				if (bufferCount < 1)
				{
					return null;
				}

				var data = new List<BigBagModel>();
				var dbw = startDbw;
				for (var i = 0; i < bufferCount; i++)
				{
					data.Add(new BigBagModel()
					{
						Cas = DateTime.Now,
						Zariadenie = zariadenie,
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

				return data;
			}
			catch (Exception ex)
			{
				Library.WriteLog(ex);
				return null;
			}
		}

		public void SetBitDataWereRead()
		{
			try
			{
				if (CheckConnection() == false)
				{
					return;
				}
				_plc.Write($"DB{_db}.DBX0.0", true);
			}
			catch (Exception ex)
			{
				Library.WriteLog(ex);
				return;
			}
		}

		public List<string> ReadArray(int count, int startDbw, string zmenaDbx)
		{
			try
			{
				if (CheckConnection() == false)
				{
					return null;
				}

				bool zmena = (bool)_plc.Read($"DB{_db}.DBX{zmenaDbx}");
				if (zmena == false)
				{
					return null;
				}

				var zaznamy = new List<string>();
				var dbw = startDbw;
				var length = (byte)_plc.Read(DataType.DataBlock, 5, dbw, VarType.Byte, 1);
				dbw += 2;
				for (var i = 0; i < count; i++)
				{
					var zaznam = (string)_plc.Read(DataType.DataBlock, 5, dbw, VarType.String, length);
					zaznam = Regex.Replace(zaznam, @"\p{C}+", string.Empty); // delete non-printable chars
					zaznamy.Add(zaznam);
					dbw += length + 2;
				}

				_plc.Write($"DB{_db}.DBX{zmenaDbx}", false);

				return zaznamy;
			}
			catch (Exception ex)
			{
				Library.WriteLog(ex);
				return null;
			}
		}
	}
}
