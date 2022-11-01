using MediatR;

namespace Tesla.Referral.Application.Commands
{
    /// <summary>
    /// 删除引荐命令定义
    /// </summary>
    public class DeleteReferralCommand : IRequest<bool>
    {
        /// <summary>
        /// 引荐ID
        /// </summary>
        public int Id { get; set; }
    }
}
