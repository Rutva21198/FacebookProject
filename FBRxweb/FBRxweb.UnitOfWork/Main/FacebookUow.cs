using RxWeb.Core.Data;
using FBRxweb.BoundedContext.Main;

namespace FBRxweb.UnitOfWork.Main
{
    public class FacebookUow : BaseUow, IFacebookUow
    {
        public FacebookUow(IFacebookContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface IFacebookUow : ICoreUnitOfWork { }
}
