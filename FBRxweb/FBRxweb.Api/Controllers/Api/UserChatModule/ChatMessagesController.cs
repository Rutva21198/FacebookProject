using Microsoft.AspNetCore.Mvc;
using System.Linq;
using FBRxweb.Domain.UserChatModule;
using FBRxweb.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;

namespace FBRxweb.Api.Controllers.UserChatModule
{
    [ApiController]
    [Route("api/[controller]")]
	
	public class ChatMessagesController : BaseDomainController<ChatMessage, ChatMessage>

    {
        public ChatMessagesController(IChatMessageDomain domain):base(domain) {}

    }
}
