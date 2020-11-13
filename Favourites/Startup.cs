using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Favourites.Models;
using Favourites.Repositories;
using Favourites.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace Favourites
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            this.ValidateToken(Configuration, services);
            services.AddControllers();
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder => builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
                /*.AllowCredentials(*//*)*/);
            });
            services.AddDbContext<DataContext>(options => options.UseSqlServer(Configuration.GetConnectionString("SqlConnection")));
            services.AddScoped<IFavouriteRepository,FavouriteRepository>();
            services.AddScoped<IFavouriteService,FavouriteService>();
            services.AddSwaggerGen(Options => Options.SwaggerDoc("v1", new OpenApiInfo { Title = "CplayerApp", Version = "1.O", Description = "This is FavouritesAPI" }));
        }



        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();

            app.UseCors("CorsPolicy");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseSwagger();
            app.UseSwaggerUI(endpoint => endpoint.SwaggerEndpoint("/swagger/v1/swagger.json", "CplayerApp "));
        }
        private void ValidateToken(IConfiguration configuration, IServiceCollection services)
        {
            var audienceconfig = configuration.GetSection("Audience");
            var secretkey = audienceconfig["Secret"];
            var keybyteArray = Encoding.ASCII.GetBytes(secretkey);
            var signature = new SymmetricSecurityKey(keybyteArray);

            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = signature,

                ValidateIssuer = true,
                ValidIssuer = audienceconfig["Iss"],

                ValidateAudience = true,
                ValidAudience = audienceconfig["Aud"],

                ValidateLifetime = true,
                ClockSkew = TimeSpan.Zero
            };
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(o => { o.TokenValidationParameters = tokenValidationParameters; });
        }
    }
}
