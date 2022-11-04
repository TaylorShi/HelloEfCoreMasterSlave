using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tesla.Referral.Domain.AggregatesModel.ReferralAggregate;

namespace Tesla.Referral.Infrastructure.EntityConfigurations
{
    /// <summary>
    /// 引荐代码领域模型和实体类型配置类
    /// </summary>
    internal class ReferralCodeEntityTypeConfiguration : IEntityTypeConfiguration<ReferralCode>
    {
        public void Configure(EntityTypeBuilder<ReferralCode> builder)
        {
            builder.ToTable("referralcode");
            builder.HasKey(p => p.Id);
            // 忽略领域事件这个字段
            builder.Ignore(b => b.DomainEvents);
            builder.HasIndex(p => p.Code);
            builder.Property(p => p.Name).HasMaxLength(120);
            builder.Property(p => p.Code).HasMaxLength(200);
        }
    }
}
