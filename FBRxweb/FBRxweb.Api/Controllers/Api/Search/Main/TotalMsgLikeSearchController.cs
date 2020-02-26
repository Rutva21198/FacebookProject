using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RxWeb.Core.Data;
using FBRxweb.Models.ViewModels;
using FBRxweb.BoundedContext.SqlContext;
namespace FBRxweb.Api.Controllers.PostModule
{
    [ApiController]
	[Route("api/[controller]")]
    public class SearchTotalMsgLikeController : ControllerBase
    {
        private IDbContextManager<MainSqlDbContext> DbContextManager { get; set; }
        public SearchTotalMsgLikeController(IDbContextManager<MainSqlDbContext> dbContextManager) {
            DbContextManager = dbContextManager;
        }

		[HttpPost]
        public async Task<IActionResult> Post([FromBody]Dictionary<string,string> searchParams)
        {
            var spParameters = new SqlParameter[1];
            spParameters[0] = new SqlParameter() { ParameterName = "id", Value = searchParams["id"] };
         
            var result = await DbContextManager.StoreProc<StoreProcResult>("[dbo].spTotalMessageLikeOnPost", spParameters);
            return Ok(result.SingleOrDefault()?.Result);
        }
    }
}
