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
			var zaznamy = _context.Zaznamy.Select(e => new ZaznamVM
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
			});

			return Json(await DataSourceLoader.LoadAsync(zaznamy, loadOptions));
		}
	}
}
