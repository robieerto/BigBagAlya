using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ModbusProfinetDL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebVue.DAL;
using WebVue.DAL.Repositories;
using WebVue.Models;

namespace WebVue.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ZaznamyController : ControllerBase
	{
		private readonly ILogger<ZaznamyController> _logger;
		private readonly ZaznamRepository _zaznamRepository;

		public ZaznamyController(BigBagDbContext context, ILogger<ZaznamyController> logger)
		{
			_zaznamRepository = new ZaznamRepository(context);
			_logger = logger;
		}

		[HttpGet]
		public async Task<IEnumerable<Zaznam>> Get()
		{
			return await _zaznamRepository.GetZaznamy();
		}
	}
}
