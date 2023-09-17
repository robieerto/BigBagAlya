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
	public class AktualneDataController : Controller
	{
		private readonly ILogger<AktualneDataController> _logger;

		public AktualneDataController(ILogger<AktualneDataController> logger)
		{
			_logger = logger;
		}

		[HttpGet]
		public IActionResult Get()
		{
			var data = DataCommunication.connections.Select(e => new AktualneDataVM
			{
				Zariadenie = e.zariadenie,
				Vaha = e.vaha,
			});

			return Json(data);
		}
	}
}
