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
	
	public class ChatMediaController : BaseController<ChatMedia,ChatMedia,ChatMedia>

    {
        public ChatMediaController(IFacebookUow uow):base(uow) {}

    }
}
