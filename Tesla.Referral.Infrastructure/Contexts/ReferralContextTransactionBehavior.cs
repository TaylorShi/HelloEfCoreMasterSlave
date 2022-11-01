using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using Tesla.Framework.Infrastructure.Core.Behaviors;

namespace Tesla.Referral.Infrastructure.Contexts
{
    /// <summary>
    /// 领域事务行为管理类
    /// </summary>
    /// <typeparam name="TRequest"></typeparam>
    /// <typeparam name="TResponse"></typeparam>
    public class ReferralContextTransactionBehavior<TRequest, TResponse> : TransactionBehavior<ReferralMasterContext, TRequest, TResponse>
    {
        public ReferralContextTransactionBehavior(ReferralMasterContext dbContext, ILogger<ReferralContextTransactionBehavior<TRequest, TResponse>> logger) : base(dbContext, logger)
        {

        }
    }
}
