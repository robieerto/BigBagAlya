#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebVue.Models
{
	public class Zaznam
	{
		public int Id { get; set; }
		public int? ZariadenieCislo { get; set; }
		public int? ZariadenieId { get; set; }
		public Zariadenie? Zariadenie { get; set; }
		public int? ProgramCislo { get; set; }
		public string? ProgramNazov { get; set; }
		public int? UzivatelCislo { get; set; }
		public string? UzivatelNazov { get; set; }
		public double Vaha { get; set; }
		public DateTime CasVazenia { get; set; }
		public DateTime CasVycitania { get; set; }
		public int? Rok { get; set; }
		public int? Mesiac { get; set; }
		public int? Den { get; set; }
		public int? Hodiny { get; set; }
		public int? Minuty { get; set; }
	}
}
