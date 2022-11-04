using System;
using System.Collections.Generic;
using System.Text;
using Tesla.Framework.Infrastructure.Core.Repositorys;
using Tesla.Referral.Domain.AggregatesModel.ReferralAggregate;

namespace Tesla.Referral.Infrastructure.Repositories
{
    /// <summary>
    /// 引荐代码仓储接口
    /// </summary>
    public interface IReferralCodeRepository : IRepository<ReferralCode, long>
    {

    }
}
