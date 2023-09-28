using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using DevExtreme.AspNet.Data;
using Newtonsoft.Json;
using WebVue.DAL;
using WebVue.ViewModels;

namespace WebVue.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ZaznamyController : Controller
	{
		private readonly ILogger<ZaznamyController> _logger;
		private readonly BigBagDbContext _context;

		public ZaznamyController(BigBagDbContext context, ILogger<ZaznamyController> logger)
		{
			_context = context;
			_logger = logger;
		}

		[HttpGet]
		public async Task<IActionResult> Get(DataSourceLoadOptions loadOptions)
		{
			if (loadOptions.Sort == null)
			{
				var sortinfo = new DevExtreme.AspNet.Data.SortingInfo[]
				{
					new SortingInfo() {Desc = true, Selector = "casVazenia"},
				};
				loadOptions.Sort = sortinfo;
			}

			var result = _context.Zaznamy.Select(e => new ZaznamVM
			{
				Id = e.Id,
				ZariadenieId = e.ZariadenieId,
				ZariadenieCislo = e.ZariadenieCislo,
				ZariadenieNazov = e.Zariadenie.Nazov,
				ProgramCislo = e.ProgramCislo,
				ProgramNazov = e.ProgramNazov,
				UzivatelCislo = e.UzivatelCislo,
				UzivatelNazov = e.UzivatelNazov,
				Vaha = e.Vaha,
				CasVazenia = e.CasVazenia,
				CasVycitania = e.CasVycitania
			}).OrderByDescending(e => e.CasVazenia);

			return Json(await DataSourceLoader.LoadAsync(result, loadOptions));
		}

		[HttpDelete]
		public async Task<IActionResult> Delete(int? id)
		{
			if (id == null)
			{
				return Ok();
			}

			var zaznam = _context.Zaznamy.Find(id);
			_context.Zaznamy.Remove(zaznam);
			await _context.SaveChangesAsync();

			return Ok();
		}
	}
}
