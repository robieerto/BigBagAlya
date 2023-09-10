using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModbusProfinetDL;
using WebVue.DAL;
using WebVue.DAL.Repositories;
using System.IO;
using System.Reflection;

namespace WebVue
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Task.Run(() => DataCommunication.ProfinetTask());

			CreateHostBuilder(args).Build().Run();
		}

		public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
				.ConfigureWebHostDefaults(webBuilder =>
				{
					webBuilder.UseStartup<Startup>();
				})
			.UseContentRoot(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
	}
}
