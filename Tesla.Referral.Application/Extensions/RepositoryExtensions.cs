using Microsoft.Extensions.DependencyInjection;
using Tesla.Referral.Infrastructure.Repositories;

namespace Tesla.Referral.Application.Extensions
{
    /// <summary>
    /// 仓储服务扩展
    /// </summary>
    public static class RepositoryExtensions
    {
        /// <summary>
        /// 添加所有仓储服务
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            // 注册引荐代码仓储(作用域模式)
            services.AddScoped<IReferralCodeRepository, ReferralCodeRepository>();
            return services;
        }
    }
}
