#region Namespace
using Microsoft.Extensions.DependencyInjection;
using FBRxweb.Infrastructure.Security;
using RxWeb.Core.Data;
using RxWeb.Core.Security;
using RxWeb.Core.Annotations;
using RxWeb.Core;
using FBRxweb.UnitOfWork.DbEntityAudit;
using FBRxweb.BoundedContext.Main;
using FBRxweb.UnitOfWork.Main;
using FBRxweb.Domain.FacebookUserDetailModule;
            using FBRxweb.Domain.FacebookUserWorkModule;
            using FBRxweb.Domain.EducationDetailModule;
            #endregion Namespace






namespace FBRxweb.Api.Bootstrap
{
    public static class ScopedExtension
    {

        public static void AddScopedService(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IRepositoryProvider, RepositoryProvider>();
            serviceCollection.AddScoped<ITokenAuthorizer, TokenAuthorizer>();
            serviceCollection.AddScoped<IModelValidation, ModelValidation>();
            serviceCollection.AddScoped<IAuditLog, AuditLog>();
            serviceCollection.AddScoped<IApplicationTokenProvider, ApplicationTokenProvider>();
            serviceCollection.AddScoped(typeof(IDbContextManager<>), typeof(DbContextManager<>));

            #region ContextService

            serviceCollection.AddScoped<ILoginContext, LoginContext>();
            serviceCollection.AddScoped<ILoginUow, LoginUow>();
             
            serviceCollection.AddScoped<IFacebookContext, FacebookContext>();
            serviceCollection.AddScoped<IFacebookUow, FacebookUow>();
                        serviceCollection.AddScoped<IProfileViewContext, ProfileViewContext>();
            serviceCollection.AddScoped<IProfileViewUow, ProfileViewUow>();
                        serviceCollection.AddScoped<IProfileViewContext, ProfileViewContext>();
            serviceCollection.AddScoped<IProfileViewUow, ProfileViewUow>();
                        serviceCollection.AddScoped<IProfileViewContext, ProfileViewContext>();
            serviceCollection.AddScoped<IProfileViewUow, ProfileViewUow>();
                        serviceCollection.AddScoped<IFacebookUserDetailContext, FacebookUserDetailContext>();
            serviceCollection.AddScoped<IFacebookUserDetailUow, FacebookUserDetailUow>();
                        serviceCollection.AddScoped<IFacebookUserWorkContext, FacebookUserWorkContext>();
            serviceCollection.AddScoped<IFacebookUserWorkUow, FacebookUserWorkUow>();
                        serviceCollection.AddScoped<IEducationDetailContext, EducationDetailContext>();
            serviceCollection.AddScoped<IEducationDetailUow, EducationDetailUow>();
            #endregion ContextService











            #region DomainService

            
            serviceCollection.AddScoped<IFacebookUserDetailDomain, FacebookUserDetailDomain>();
            
            serviceCollection.AddScoped<IFacebookUserWorkDomain, FacebookUserWorkDomain>();
            
            serviceCollection.AddScoped<IEducationDetailDomain, EducationDetailDomain>();
            #endregion DomainService



        }
    }
}




