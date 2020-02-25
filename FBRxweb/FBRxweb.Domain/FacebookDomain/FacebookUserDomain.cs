using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using FBRxweb.UnitOfWork.Main;
using FBRxweb.Models.Main;

namespace FBRxweb.Domain.FacebookModule
{
    public class FacebookUserDomain : IFacebookUserDomain
    {
        public FacebookUserDomain(IFacebookUow uow) {
            this.Uow = uow;
        }

        public Task<object> GetAsync(FacebookUser parameters)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetBy(FacebookUser parameters)
        {
            throw new NotImplementedException();

        }
        

        public HashSet<string> AddValidation(FacebookUser entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(FacebookUser entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(FacebookUser entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(FacebookUser entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(FacebookUser parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(FacebookUser parameters)
        {
            throw new NotImplementedException();
        }

        public IFacebookUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IFacebookUserDomain : ICoreDomain<FacebookUser, FacebookUser> { }
}
