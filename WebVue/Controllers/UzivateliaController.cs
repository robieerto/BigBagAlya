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
	public class UzivateliaController : Controller
	{
		private readonly ILogger<UzivateliaController> _logger;
		private readonly BigBagDbContext _context;

		public UzivateliaController(BigBagDbContext context, ILogger<UzivateliaController> logger)
		{
			_context = context;
			_logger = logger;
		}

		[HttpGet]
		public async Task<IActionResult> Get(DataSourceLoadOptions loadOptions)
		{
			var result = _context.Uzivatelia.Select(e => new UzivatelVM
			{
				Id = e.Id,
				Cislo = e.Cislo,
				Nazov = e.Nazov,
				ZariadenieId = e.ZariadenieId,
			});

			return Json(await DataSourceLoader.LoadAsync(result, loadOptions));
		}
	}
}
