using Microsoft.AspNetCore.Mvc;
using System.Linq;
using FBRxweb.UnitOfWork.Main;
using FBRxweb.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;

namespace FBRxweb.Api.Controllers.ProfileViewModule
{
    [ApiController]
    [Route("api/[controller]")]
	
	public class FacebookUserDetailController : BaseController<FacebookUserDetail,FacebookUserDetail,FacebookUserDetail>

    {
        public FacebookUserDetailController(IProfileViewUow uow):base(uow) {}

    }
}
