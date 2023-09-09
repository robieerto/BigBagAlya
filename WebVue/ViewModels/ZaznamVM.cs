#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebVue.ViewModels
{
	public class ZaznamVM
	{
		public int Id { get; set; }
		public int? ZariadenieId { get; set; }
		public int? ZariadenieCislo { get; set; }
		public string? ZariadenieNazov { get; set; }
		public int? ProgramCislo { get; set; }
		public string? ProgramNazov { get; set; }
		public int? UzivatelCislo { get; set; }
		public string? UzivatelNazov { get; set; }
		public double Vaha { get; set; }
		public DateTime CasVazenia { get; set; }
		public DateTime CasVycitania { get; set; }
	}
}
