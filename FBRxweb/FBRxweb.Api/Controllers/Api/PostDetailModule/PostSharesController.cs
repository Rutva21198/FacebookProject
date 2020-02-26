using Microsoft.AspNetCore.Mvc;
using System.Linq;
using FBRxweb.Domain.PostDetailModule;
using FBRxweb.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;

namespace FBRxweb.Api.Controllers.PostDetailModule
{
    [ApiController]
    [Route("api/[controller]")]
	
	public class PostSharesController : BaseDomainController<PostShare, PostShare>

    {
        public PostSharesController(IPostShareDomain domain):base(domain) {}

    }
}
