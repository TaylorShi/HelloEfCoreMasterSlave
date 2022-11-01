using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Tesla.Referral.Infrastructure.Repositories;

namespace Tesla.Referral.Application.Commands
{
    /// <summary>
    /// 删除引荐命令处理
    /// </summary>
    internal class DeleteReferralCommandHandler : IRequestHandler<DeleteReferralCommand, bool>
    {
        /// <summary>
        /// 引荐代码仓储
        /// </summary>
        readonly IReferralCodeRepository _referralCodeRepository;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="referralCodeRepository"></param>
        public DeleteReferralCommandHandler(IReferralCodeRepository referralCodeRepository)
        {
            _referralCodeRepository = referralCodeRepository;
        }

        /// <summary>
        /// 处理程序
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<bool> Handle(DeleteReferralCommand request, CancellationToken cancellationToken)
        {
            return await _referralCodeRepository.DeleteAsync(request.Id);
        }
    }
}
