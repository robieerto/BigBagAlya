#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebVue.ViewModels
{
	public class UzivatelVM
	{
		public int Id { get; set; }
		public int? Cislo { get; set; }
		public string? Nazov { get; set; }
		public int? ZariadenieId { get; set; }
	}
}
