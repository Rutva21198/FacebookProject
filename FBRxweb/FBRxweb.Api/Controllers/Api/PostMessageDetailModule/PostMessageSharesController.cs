using Microsoft.AspNetCore.Mvc;
using System.Linq;
using FBRxweb.Domain.PostMessageDetailModule;
using FBRxweb.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;

namespace FBRxweb.Api.Controllers.PostMessageDetailModule
{
    [ApiController]
    [Route("api/[controller]")]
	
	public class PostMessageSharesController : BaseDomainController<PostMessageShare, PostMessageShare>

    {
        public PostMessageSharesController(IPostMessageShareDomain domain):base(domain) {}

    }
}
