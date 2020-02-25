using Microsoft.AspNetCore.Mvc;
using System.Linq;
using FBRxweb.UnitOfWork.Main;
using FBRxweb.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;

namespace FBRxweb.Api.Controllers.FacebookModule
{
    [ApiController]
    [Route("api/[controller]")]
	
	public class vAllOnlineUserListController : BaseController<vAllOnlineUserList,vAllOnlineUserList,vAllOnlineUserList>

    {
        public vAllOnlineUserListController(IFacebookUow uow):base(uow) {}

    }
}
