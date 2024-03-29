﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Kookweb.SubtitleTranslator.Domain.Persistence.Contexts;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Kookweb.SubtitleTranslator.Api {
    public class Program {
        public static void Main (string[] args) {
            var host = CreateWebHostBuilder (args).Build ();

            using (var scope = host.Services.CreateScope ())
            using (var context = scope.ServiceProvider.GetService<AppDbContext> ()) {
                context.Database.EnsureCreated ();
            }

            host.Run ();
        }

        public static IWebHostBuilder CreateWebHostBuilder (string[] args) =>
            WebHost.CreateDefaultBuilder (args)
            .UseStartup<Startup> ();
    }
}