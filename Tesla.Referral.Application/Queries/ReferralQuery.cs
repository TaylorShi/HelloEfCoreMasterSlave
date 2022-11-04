using MediatR;
using Tesla.Framework.Core;
using Tesla.Referral.DataContract.ReferralCode.DTO;

namespace Tesla.Referral.Application.Queries
{
    /// <summary>
    /// 引荐查询定义
    /// </summary>
    public class ReferralQuery : IRequest<PagedList<ReferralCodeDto>>
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

        /// <summary>
        /// 分页页码
        /// </summary>
        public int PageIndex { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        public int PageSize { get; set; }
    }
}
