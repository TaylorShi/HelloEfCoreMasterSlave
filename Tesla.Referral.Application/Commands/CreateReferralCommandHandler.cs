using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Tesla.Referral.Domain.Aggregates;
using Tesla.Referral.Infrastructure.Repositories;

namespace Tesla.Referral.Application.Commands
{
    /// <summary>
    /// 创建引荐命令处理
    /// </summary>
    internal class CreateReferralCommandHandler : IRequestHandler<CreateReferralCommand, bool>
    {
        /// <summary>
        /// 引荐代码仓储
        /// </summary>
        readonly IReferralCodeRepository _referralCodeRepository;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="referralCodeRepository"></param>
        public CreateReferralCommandHandler(IReferralCodeRepository referralCodeRepository)
        {
            _referralCodeRepository = referralCodeRepository;
        }

        /// <summary>
        /// 处理程序
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<bool> Handle(CreateReferralCommand request, CancellationToken cancellationToken)
        {
            var referralCode = new ReferralCode(request.Name, request.Code);
            await _referralCodeRepository.AddAsync(referralCode, cancellationToken);
            return true;
        }
    }
}
