using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Tesla.Referral.Application.Commands;
using Tesla.Referral.Domain.AggregatesModel.ReferralAggregate;
using Tesla.Referral.Infrastructure.Contexts;

namespace Tesla.Referral.Application.Extensions
{
    /// <summary>
    /// 命令处理扩展
    /// </summary>
    public static class CommandHandlerExtensions
    {
        /// <summary>
        /// 添加命令处理服务
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddCommandHandlers(this IServiceCollection services)
        {
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ReferralContextTransactionBehavior<,>));
            return services.AddMediatR(typeof(ReferralCode).Assembly, typeof(CreateReferralCommand).Assembly);
        }
    }
}
