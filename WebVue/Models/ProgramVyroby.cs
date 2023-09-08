#nullable enable

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace WebVue.Models
{
	public class ProgramVyroby
	{
		public int Id { get; set; }
		public int? Cislo { get; set; }
		public string? Nazov { get; set; } = "";
		public int? ZariadenieId { get; set; }
		public Zariadenie? Zariadenie { get; set; }
	}
}
