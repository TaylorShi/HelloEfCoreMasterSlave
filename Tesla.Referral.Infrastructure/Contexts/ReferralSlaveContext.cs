using Microsoft.EntityFrameworkCore;
using Tesla.Referral.Domain.Aggregates;
using Tesla.Referral.Infrastructure.EntityConfigurations;

namespace Tesla.Referral.Infrastructure.Contexts
{
    /// <summary>
    /// 引荐SlaveContext
    /// </summary>
    public class ReferralSlaveContext : DbContext
    {
        public ReferralSlaveContext(DbContextOptions<ReferralSlaveContext> options) : base(options)
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
