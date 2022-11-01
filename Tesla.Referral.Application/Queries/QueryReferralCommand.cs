using MediatR;
using System.Collections.Generic;
using Tesla.Referral.Domain.Aggregates;

namespace Tesla.Referral.Application.Queries
{
    /// <summary>
    /// 查询引荐命令定义
    /// </summary>
    public class QueryReferralCommand : IRequest<List<ReferralCode>>
    {
        /// <summary>
        /// 引荐ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 引荐名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 引荐代码
        /// </summary>
        public string Code { get; set; }
    }
}
