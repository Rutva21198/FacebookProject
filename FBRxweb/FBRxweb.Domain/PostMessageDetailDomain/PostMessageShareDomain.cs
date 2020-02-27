using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using FBRxweb.UnitOfWork.Main;
using FBRxweb.Models.Main;

namespace FBRxweb.Domain.PostMessageDetailModule
{
    public class PostMessageShareDomain : IPostMessageShareDomain
    {
        public PostMessageShareDomain(IPostMessageDetailUow uow) {
            this.Uow = uow;
        }

        public Task<object> GetAsync(PostMessageShare parameters)
        {
            throw new NotImplementedException();
        }

        public async  Task<object> GetBy(PostMessageShare parameters)
        {
            //throw new NotImplementedException();
            return await Uow.Repository<PostMessageShare>().FindByAsync(t => t.PostMessageId == parameters.PostMessageId);
        }
        

        public HashSet<string> AddValidation(PostMessageShare entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(PostMessageShare entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(PostMessageShare entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(PostMessageShare entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(PostMessageShare parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(PostMessageShare parameters)
        {
            throw new NotImplementedException();
        }

        public IPostMessageDetailUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IPostMessageShareDomain : ICoreDomain<PostMessageShare, PostMessageShare> { }
}
