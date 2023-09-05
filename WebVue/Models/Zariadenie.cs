#nullable enable

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace WebVue.Models
{
	public class Zariadenie
	{
		public int Id { get; set; }
		public int Cislo { get; set; }
		public string? Nazov { get; set; }
		public ICollection<Zaznam> Zaznamy { get; set; } = new Collection<Zaznam>();
		public ICollection<ProgramVyroby> Programy { get; set; } = new Collection<ProgramVyroby>();
	}
}
