﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kookweb.SubtitleTranslator.Domain.Persistence.Contexts;
using Kookweb.SubtitleTranslator.Domain.Repositories;
using Kookweb.SubtitleTranslator.Domain.Services;
using Kookweb.SubtitleTranslator.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Kookweb.SubtitleTranslator.Api {
    public class Startup {
        public Startup (IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices (IServiceCollection services) {
            services.AddMvc ().SetCompatibilityVersion (CompatibilityVersion.Version_2_2);

            services.AddDbContext<AppDbContext> (options => {
                options.UseSqlServer (Configuration.GetConnectionString ("AppConnection"));
            });

            services.AddScoped<ITVShowRepository, TVShowRepository> ();
            services.AddScoped<ITVShowService, TVShowService> ();
        }

        public void Configure (IApplicationBuilder app, IHostingEnvironment env) {
            if (env.IsDevelopment ()) {
                app.UseDeveloperExceptionPage ();
            }

            app.UseMvc ();
        }
    }
}