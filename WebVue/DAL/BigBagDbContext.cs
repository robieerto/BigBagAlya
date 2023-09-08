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
		public DbSet<Zariadenie> Zariadenia { get; set; }
		public DbSet<Uzivatel> Uzivatelia { get; set; }
		public DbSet<ProgramVyroby> Programy { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			int i, j, k;

			var zariadenia = new List<Zariadenie>();
			for (i = 0; i < 3; i++)
			{
				zariadenia.Add(new Zariadenie { Id = i + 1, Cislo = i });
				;
			};

			var programy = new List<ProgramVyroby>();
			for (i = 0, j = 0; j < 3; j++)
			{
				for (k = 0; k < 10; k++, i++)
				{
					programy.Add(new ProgramVyroby { Id = i + 1, ZariadenieId = j + 1, Cislo = k });
				}
			}

			var uzivatelia = new List<Uzivatel>();
			for (i = 0, j = 0; j < 3; j++)
			{
				for (k = 0; k < 10; k++, i++)
				{
					uzivatelia.Add(new Uzivatel { Id = i + 1, ZariadenieId = j + 1, Cislo = k });
				}
			}

			var zaznamy = new Zaznam[]
			{
				new Zaznam { Id = ++i, ZariadenieCislo = 1, ZariadenieId = 1, ProgramCislo = 1, ProgramNazov = "Program1", UzivatelCislo = 1, UzivatelNazov = "Uzivatel1", Vaha = 90.5, CasVazenia = DateTime.Now, CasVycitania = DateTime.Now },
				new Zaznam { Id = ++i, ZariadenieCislo = 1, ZariadenieId = 1, ProgramCislo = 1, ProgramNazov = "Program1", UzivatelCislo = 1, UzivatelNazov = "Uzivatel1", Vaha = 91.5, CasVazenia = DateTime.Now, CasVycitania = DateTime.Now },
				new Zaznam { Id = ++i, ZariadenieCislo = 1, ZariadenieId = 1, ProgramCislo = 2, ProgramNazov = "Program2", UzivatelCislo = 1, UzivatelNazov = "Uzivatel1", Vaha = 90.5, CasVazenia = DateTime.Now.AddDays(2), CasVycitania = DateTime.Now },
				new Zaznam { Id = ++i, ZariadenieCislo = 1, ZariadenieId = 1, ProgramCislo = 2, ProgramNazov = "Program2", UzivatelCislo = 2, UzivatelNazov = "Uzivatel2", Vaha = 90, CasVazenia = DateTime.Now.AddDays(3), CasVycitania = DateTime.Now },
				new Zaznam { Id = ++i, ZariadenieCislo = 1, ZariadenieId = 1, ProgramCislo = 3, ProgramNazov = "Program3", UzivatelCislo = 1, UzivatelNazov = "Uzivatel1", Vaha = 85.5, CasVazenia = DateTime.Now.AddDays(6), CasVycitania = DateTime.Now },
				new Zaznam { Id = ++i, ZariadenieCislo = 1, ZariadenieId = 1, ProgramCislo = 1, ProgramNazov = "Program1", UzivatelCislo = 2, UzivatelNazov = "Uzivatel2", Vaha = 90.5, CasVazenia = DateTime.Now.AddDays(7), CasVycitania = DateTime.Now },
				new Zaznam { Id = ++i, ZariadenieCislo = 2, ZariadenieId = 2, ProgramCislo = 2, ProgramNazov = "Program2", UzivatelCislo = 1, UzivatelNazov = "Uzivatel1", Vaha = 92, CasVazenia = DateTime.Now, CasVycitania = DateTime.Now },
				new Zaznam { Id = ++i, ZariadenieCislo = 2, ZariadenieId = 2, ProgramCislo = 1, ProgramNazov = "Program1", UzivatelCislo = 1, UzivatelNazov = "Uzivatel1", Vaha = 91, CasVazenia = DateTime.Now.AddDays(4), CasVycitania = DateTime.Now },
				new Zaznam { Id = ++i, ZariadenieCislo = 2, ZariadenieId = 2, ProgramCislo = 3, ProgramNazov = "Program3", UzivatelCislo = 3, UzivatelNazov = "Uzivatel3", Vaha = 91.5, CasVazenia = DateTime.Now.AddDays(5), CasVycitania = DateTime.Now },
				new Zaznam { Id = ++i, ZariadenieCislo = 3, ZariadenieId = 3, ProgramCislo = 3, ProgramNazov = "Program3", UzivatelCislo = 1, UzivatelNazov = "Uzivatel1", Vaha = 90.5, CasVazenia = DateTime.Now.AddDays(1), CasVycitania = DateTime.Now },
				new Zaznam { Id = ++i, ZariadenieCislo = 3, ZariadenieId = 3, ProgramCislo = 3, ProgramNazov = "Program3", UzivatelCislo = 3, UzivatelNazov = "Uzivatel3", Vaha = 92.5, CasVazenia = DateTime.Now.AddDays(1), CasVycitania = DateTime.Now },
			};

			modelBuilder.Entity<Zariadenie>().HasData(zariadenia);
			modelBuilder.Entity<ProgramVyroby>().HasData(programy);
			modelBuilder.Entity<Uzivatel>().HasData(uzivatelia);
			modelBuilder.Entity<Zaznam>().HasData(zaznamy);

			base.OnModelCreating(modelBuilder);
		}
	}
}
