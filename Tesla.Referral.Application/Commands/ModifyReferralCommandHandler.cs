using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tesla.Referral.Infrastructure.Repositories;

namespace Tesla.Referral.Application.Commands
{
    /// <summary>
    /// 修改引荐命令处理
    /// </summary>
    internal class ModifyReferralCommandHandler : IRequestHandler<ModifyReferralCommand, bool>
    {
        /// <summary>
        /// 引荐代码仓储
        /// </summary>
        readonly IReferralCodeRepository _referralCodeRepository;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="referralCodeRepository"></param>
        public ModifyReferralCommandHandler(IReferralCodeRepository referralCodeRepository)
        {
            _referralCodeRepository = referralCodeRepository;
        }

        /// <summary>
        /// 处理程序
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<bool> Handle(ModifyReferralCommand request, CancellationToken cancellationToken)
        {
            var referralCode = await _referralCodeRepository.GetAsync(request.Id, cancellationToken);
            if (referralCode != null)
            {
                referralCode.Modify(request.Name, request.Code);
                await _referralCodeRepository.UpdateAsync(referralCode);
                return true;
            }
            return false;
        }
    }
}
