using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tesla.Referral.Application.Commands
{
    /// <summary>
    /// 修改引荐命令定义
    /// </summary>
    public class ModifyReferralCommand : IRequest<bool>
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
