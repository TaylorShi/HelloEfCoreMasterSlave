using System;
using System.Collections.Generic;
using System.Text;
using Tesla.Framework.Domain.Abstractions;

namespace Tesla.Referral.Domain.AggregatesModel.ReferralAggregate
{
    /// <summary>
    /// 引荐代码领域模型
    /// </summary>
    public class ReferralCode : Entity<long>, IAggregateRoot
    {
        /// <summary>
        /// 引荐名称
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// 引荐代码
        /// </summary>
        public string Code { get; private set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="name"></param>
        /// <param name="code"></param>
        public ReferralCode(string name, string code)
        {
            Name = name;
            Code = code;
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="name"></param>
        /// <param name="code"></param>
        public void Modify(string name, string code)
        {
            Name = name;
            Code = code;
        }
    }
}
