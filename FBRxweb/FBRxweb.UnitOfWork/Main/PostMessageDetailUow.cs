using RxWeb.Core.Data;
using FBRxweb.BoundedContext.Main;

namespace FBRxweb.UnitOfWork.Main
{
    public class PostMessageDetailUow : BaseUow, IPostMessageDetailUow
    {
        public PostMessageDetailUow(IPostMessageDetailContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface IPostMessageDetailUow : ICoreUnitOfWork { }
}


