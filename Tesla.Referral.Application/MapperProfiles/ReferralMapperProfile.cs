using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Tesla.Referral.DataContract.ReferralCode.DTO;
using Tesla.Referral.Domain.AggregatesModel.ReferralAggregate;

namespace Tesla.Referral.Application.MapperProfiles
{
    /// <summary>
    /// 引荐映射配置
    /// </summary>
    public class ReferralMapperProfile : Profile
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public ReferralMapperProfile()
        {
            CreateMap<ReferralCode, ReferralCodeDto>().ReverseMap();
        }
    }
}
