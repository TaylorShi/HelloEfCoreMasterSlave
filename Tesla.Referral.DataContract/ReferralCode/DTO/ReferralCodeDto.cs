using System;
using System.Collections.Generic;
using System.Text;

namespace Tesla.Referral.DataContract.ReferralCode.DTO
{
    /// <summary>
    /// 引荐代码
    /// </summary>
    public class ReferralCodeDto
    {
        /// <summary>
        /// 引荐名称
        /// </summary>
        public string Id { get; set; }

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
