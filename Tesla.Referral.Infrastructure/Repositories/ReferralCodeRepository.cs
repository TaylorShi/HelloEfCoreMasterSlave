using System;
using System.Collections.Generic;
using System.Text;
using Tesla.Framework.Infrastructure.Core.Repositorys;
using Tesla.Referral.Domain.Aggregates;
using Tesla.Referral.Infrastructure.Contexts;

namespace Tesla.Referral.Infrastructure.Repositories
{
    /// <summary>
    /// 引荐代码仓储类
    /// </summary>
    public class ReferralCodeRepository : Repository<ReferralCode, long, ReferralMasterContext>, IReferralCodeRepository
    {
        public ReferralCodeRepository(ReferralMasterContext context) : base(context)
        {
        }
    }
}
