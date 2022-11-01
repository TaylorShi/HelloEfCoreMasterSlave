using MediatR;

namespace Tesla.Referral.Application.Commands
{
    /// <summary>
    /// 创建引荐命令定义
    /// </summary>
    public class CreateReferralCommand : IRequest<bool>
    {
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
