using AutoMapper;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Tesla.Framework.Core;
using Tesla.Framework.Infrastructure.Core.Extensions;
using Tesla.Referral.DataContract.ReferralCode.DTO;
using Tesla.Referral.Domain.Aggregates;
using Tesla.Referral.Infrastructure.Contexts;

namespace Tesla.Referral.Application.Queries
{
    /// <summary>
    /// 查询引荐命令处理
    /// </summary>
    public class QueryReferralCommandHandler : IRequestHandler<QueryReferralCommand, PagedList<ReferralCodeDto>>
    {
        private readonly ReferralSlaveContext _referralSlaveContext;
        private readonly IConfigurationProvider _configurationProvider;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="referralSlaveContext"></param>
        public QueryReferralCommandHandler(ReferralSlaveContext referralSlaveContext, IConfigurationProvider configurationProvider)
        {
            _referralSlaveContext = referralSlaveContext;
            _configurationProvider = configurationProvider;
        }

        /// <summary>
        /// 处理程序
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<PagedList<ReferralCodeDto>> Handle(QueryReferralCommand request, CancellationToken cancellationToken)
        {
            IQueryable<ReferralCode> query = _referralSlaveContext.ReferralCodes
                .WhereIf(request.Id > 0, x => x.Id == request.Id)
                .WhereIf(!string.IsNullOrEmpty(request.Name), x => x.Name == request.Name)
                .WhereIf(!string.IsNullOrEmpty(request.Code), x => x.Code == request.Code);

            return await query.Paged<ReferralCode, ReferralCodeDto>(request.PageIndex, request.PageSize, _configurationProvider);
        }
    }
}
