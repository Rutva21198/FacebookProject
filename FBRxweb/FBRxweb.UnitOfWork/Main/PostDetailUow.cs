using RxWeb.Core.Data;
using FBRxweb.BoundedContext.Main;

namespace FBRxweb.UnitOfWork.Main
{
    public class PostDetailUow : BaseUow, IPostDetailUow
    {
        public PostDetailUow(IPostDetailContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface IPostDetailUow : ICoreUnitOfWork { }
}


