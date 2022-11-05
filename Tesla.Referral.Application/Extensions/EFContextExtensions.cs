using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Tesla.Referral.Infrastructure.Contexts;

namespace Tesla.Referral.Application.Extensions
{
    /// <summary>
    /// EF上下文扩展
    /// </summary>
    public static class EFContextExtensions
    {
        /// <summary>
        /// 添加MYSQL集群上下文服务
        /// </summary>
        /// <param name="services"></param>
        /// <param name="masterConnectionString"></param>
        /// <param name="slaveConnectionString"></param>
        /// <returns></returns>
        public static IServiceCollection AddMySqlClusterContext(this IServiceCollection services, string masterConnectionString, string slaveConnectionString)
        {
            // 添加引荐MasterContext
            services.AddDbContext<ReferralMasterContext>(optionsAction =>
            {
                optionsAction.UseMySql(masterConnectionString);
            });

            // 添加引荐SlaveContext
            services.AddDbContextPool<ReferralSlaveContext>(optionsAction =>
            {
                optionsAction.UseMySql(slaveConnectionString);
            });
            return services;
        }
    }
}
