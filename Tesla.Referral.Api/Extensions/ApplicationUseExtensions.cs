﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Tesla.Referral.Infrastructure.Contexts;

namespace Tesla.Referral.Api.Extensions
{
    /// <summary>
    /// 应用启用扩展
    /// </summary>
    public static class ApplicationUseExtensions
    {
        /// <summary>
        /// 使用EF确保创建
        /// </summary>
        /// <param name="app"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseEfEnsureCreated(this IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var dc = scope.ServiceProvider.GetService<ReferralMasterContext>();
                dc.Database.EnsureCreated();
            }

            return app;
        }
    }
}
