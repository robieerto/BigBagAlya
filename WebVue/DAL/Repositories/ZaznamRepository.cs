using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebVue.Models;

namespace WebVue.DAL.Repositories
{
	public class ZaznamRepository
	{
		private readonly BigBagDbContext _context;

		public ZaznamRepository(BigBagDbContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<Zaznam>> GetZaznamy()
		{
			return await _context.Zaznamy.ToListAsync();
		}

		public async Task SaveZaznam(IEnumerable<Zaznam> zaznamy)
		{
			await _context.Zaznamy.AddRangeAsync(zaznamy);
		}
	}
}
