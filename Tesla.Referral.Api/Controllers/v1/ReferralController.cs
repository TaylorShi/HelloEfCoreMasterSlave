using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Tesla.Framework.Core;
using Tesla.Referral.Application.Commands;
using Tesla.Referral.Application.Queries;
using Tesla.Referral.DataContract.ReferralCode.DTO;

namespace Tesla.Referral.Api.Controllers.v1
{
    /// <summary>
    /// 引荐服务
    /// </summary>
    [ApiVersion("1.0")]
    [Route("api/v{version:ApiVersion}/[controller]/[action]")]
    [ApiController]
    public class ReferralController : ControllerBase
    {
        readonly IMediator _mediator;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="mediator"></param>
        public ReferralController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// 创建引荐
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<bool> Create([FromBody]CreateReferralCommand cmd)
        {
            // 发送创建引荐的命令
            return await _mediator.Send(cmd, HttpContext.RequestAborted);
        }

        /// <summary>
        /// 修改引荐
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<bool> Modify([FromBody]ModifyReferralCommand cmd)
        {
            // 发送修改引荐的命令
            return await _mediator.Send(cmd, HttpContext.RequestAborted);
        }

        /// <summary>
        /// 删除引荐
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<bool> Delete([FromBody]DeleteReferralCommand cmd)
        {
            // 发送修改引荐的命令
            return await _mediator.Send(cmd, HttpContext.RequestAborted);
        }

        /// <summary>
        /// 查询引荐
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<PagedList<ReferralCodeDto>> Query([FromQuery]ReferralQuery cmd)
        {
            // 发送查询引荐的命令
            return await _mediator.Send(cmd, HttpContext.RequestAborted);
        }
    }
}
