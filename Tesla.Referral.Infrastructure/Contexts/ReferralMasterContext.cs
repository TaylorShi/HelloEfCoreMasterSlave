using MediatR;
using Microsoft.EntityFrameworkCore;
using Tesla.Framework.Infrastructure.Core.Contexts;
using Tesla.Referral.Domain.Aggregates;
using Tesla.Referral.Infrastructure.EntityConfigurations;

namespace Tesla.Referral.Infrastructure.Contexts
{
    /// <summary>
    /// 引荐MasterContext
    /// </summary>
    public class ReferralMasterContext : EFContext
    {
        public ReferralMasterContext(DbContextOptions<ReferralMasterContext> options, IMediator mediator) : base(options, mediator)
        {
        }

        public DbSet<ReferralCode> ReferralCodes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 注册领域模型与数据库的映射关系
            modelBuilder.ApplyConfiguration(new ReferralCodeEntityTypeConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
