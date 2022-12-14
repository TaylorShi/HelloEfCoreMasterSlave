using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Tesla.Referral.Api.Extensions;
using Tesla.Referral.Application.Extensions;

namespace Tesla.Referral.Api
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
            services.AddControllers();
            services.AddCors(options => options.AddPolicy("AllowAllOrigin", buildler =>
            {
                buildler.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
            }));
            // 添加和配置API版本相关服务
            services.AddApiVersions();
            // 添加和配置Swagger相关服务
            services.AddSwaggers();
            // 添加命令处理服务
            services.AddCommandHandlers();
            // 添加MYSQL集群上下文服务
            services.AddMySqlClusterContext(Configuration.GetValue<string>("MYSQL-Master"), Configuration.GetValue<string>("MYSQL-Slave"));
            // 添加所有仓储服务
            services.AddRepositories();
            // 添加程序集映射配置
            services.AddAssemblyMapppers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IApiVersionDescriptionProvider provider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseEfEnsureCreated();

            app.UseSwaggerAndApiVersions(provider);

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = Microsoft.AspNetCore.HttpOverrides.ForwardedHeaders.All
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        
    }
}
