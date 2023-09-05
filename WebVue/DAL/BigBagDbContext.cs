using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebVue.Models;

namespace WebVue.DAL
{
	public class BigBagDbContext : DbContext
	{
		public BigBagDbContext(DbContextOptions<BigBagDbContext> options) : base(options) { }

		public DbSet<Zaznam> Zaznamy { get; set; }
		public DbSet<Zaznam> Zariadenia { get; set; }
		public DbSet<Zaznam> Uzivatelia { get; set; }
		public DbSet<Zaznam> Programy { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			int i = 0;

			var zariadenia = new Zariadenie[]
			{
				new Zariadenie { Id = ++i, Cislo = i },
				new Zariadenie { Id = ++i, Cislo = i },
				new Zariadenie { Id = ++i, Cislo = i },
			};

			i = 0;

			var programy = new ProgramVyroby[]
			{
				new ProgramVyroby { Id = ++i, Cislo = i, ZariadenieId = 1 },
				new ProgramVyroby { Id = ++i, Cislo = i, ZariadenieId = 1 },
				new ProgramVyroby { Id = ++i, Cislo = i, ZariadenieId = 2 },
				new ProgramVyroby { Id = ++i, Cislo = i, ZariadenieId = 2 },
				new ProgramVyroby { Id = ++i, Cislo = i, ZariadenieId = 3 },
				new ProgramVyroby { Id = ++i, Cislo = i, ZariadenieId = 3 },
			};

			i = 0;

			var uzivatelia = new Uzivatel[]
			{
				new Uzivatel { Id = ++i, Cislo = i, ZariadenieId = 1 },
				new Uzivatel { Id = ++i, Cislo = i, ZariadenieId = 1 },
				new Uzivatel { Id = ++i, Cislo = i, ZariadenieId = 2 },
				new Uzivatel { Id = ++i, Cislo = i, ZariadenieId = 2 },
				new Uzivatel { Id = ++i, Cislo = i, ZariadenieId = 3 },
				new Uzivatel { Id = ++i, Cislo = i, ZariadenieId = 3 },
			};

			i = 0;

			var zaznamy = new Zaznam[]
			{
				new Zaznam { Id = ++i, ZariadenieCislo = 1, ZariadenieId = 1, ProgramCislo = 1, ProgramId = 1, UzivatelCislo = 1, UzivatelId = 1, Vaha = 90.5, Cas = DateTime.Now },
				new Zaznam { Id = ++i, ZariadenieCislo = 1, ZariadenieId = 1, ProgramCislo = 1, ProgramId = 1, UzivatelCislo = 1, UzivatelId = 1, Vaha = 91.5, Cas = DateTime.Now },
				new Zaznam { Id = ++i, ZariadenieCislo = 1, ZariadenieId = 1, ProgramCislo = 2, ProgramId = 2, UzivatelCislo = 1, UzivatelId = 1, Vaha = 90.5, Cas = DateTime.Now.AddDays(2) },
				new Zaznam { Id = ++i, ZariadenieCislo = 1, ZariadenieId = 1, ProgramCislo = 2, ProgramId = 2, UzivatelCislo = 2, UzivatelId = 2, Vaha = 90, Cas = DateTime.Now.AddDays(3) },
				new Zaznam { Id = ++i, ZariadenieCislo = 1, ZariadenieId = 1, ProgramCislo = 3, ProgramId = 3, UzivatelCislo = 1, UzivatelId = 1, Vaha = 85.5, Cas = DateTime.Now.AddDays(6) },
				new Zaznam { Id = ++i, ZariadenieCislo = 1, ZariadenieId = 1, ProgramCislo = 1, ProgramId = 1, UzivatelCislo = 2, UzivatelId = 2, Vaha = 90.5, Cas = DateTime.Now.AddDays(7) },
				new Zaznam { Id = ++i, ZariadenieCislo = 2, ZariadenieId = 2, ProgramCislo = 2, ProgramId = 2, UzivatelCislo = 1, UzivatelId = 1, Vaha = 92, Cas = DateTime.Now },
				new Zaznam { Id = ++i, ZariadenieCislo = 2, ZariadenieId = 2, ProgramCislo = 1, ProgramId = 1, UzivatelCislo = 1, UzivatelId = 1, Vaha = 91, Cas = DateTime.Now.AddDays(4) },
				new Zaznam { Id = ++i, ZariadenieCislo = 2, ZariadenieId = 2, ProgramCislo = 3, ProgramId = 3, UzivatelCislo = 3, UzivatelId = 3, Vaha = 91.5, Cas = DateTime.Now.AddDays(5) },
				new Zaznam { Id = ++i, ZariadenieCislo = 3, ZariadenieId = 3, ProgramCislo = 3, ProgramId = 3, UzivatelCislo = 1, UzivatelId = 1, Vaha = 90.5, Cas = DateTime.Now.AddDays(1) },
				new Zaznam { Id = ++i, ZariadenieCislo = 3, ZariadenieId = 3, ProgramCislo = 3, ProgramId = 3, UzivatelCislo = 3, UzivatelId = 3, Vaha = 92.5, Cas = DateTime.Now.AddDays(1) },
			};

			modelBuilder.Entity<Zariadenie>().HasData(zariadenia);
			modelBuilder.Entity<ProgramVyroby>().HasData(programy);
			modelBuilder.Entity<Uzivatel>().HasData(uzivatelia);
			modelBuilder.Entity<Zaznam>().HasData(zaznamy);

			base.OnModelCreating(modelBuilder);
		}
	}
}
