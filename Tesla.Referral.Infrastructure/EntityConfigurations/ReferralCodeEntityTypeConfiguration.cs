using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Tesla.Referral.Domain.Aggregates;

namespace Tesla.Referral.Infrastructure.EntityConfigurations
{
    /// <summary>
    /// 引荐代码领域模型和实体类型配置类
    /// </summary>
    internal class ReferralCodeEntityTypeConfiguration : IEntityTypeConfiguration<ReferralCode>
    {
        public void Configure(EntityTypeBuilder<ReferralCode> builder)
        {
            builder.HasKey(p => p.Id);
            builder.ToTable("referralcode");
            builder.Property(p => p.Name).HasMaxLength(120);
            builder.Property(p => p.Code).HasMaxLength(200);
        }
    }
}
