using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using FBRxweb.UnitOfWork.Main;
using FBRxweb.Models.Main;

namespace FBRxweb.Domain.PostMessageDetailModule
{
    public class PostMessageLikeDomain : IPostMessageLikeDomain
    {
        public PostMessageLikeDomain(IPostMessageDetailUow uow) {
            this.Uow = uow;
        }

        public Task<object> GetAsync(PostMessageLike parameters)
        {
            throw new NotImplementedException();
        }

        public async Task<object> GetBy(PostMessageLike parameters)
        {
            //throw new NotImplementedException();
            return await Uow.Repository<PostMessageLike>().FindByAsync(t => t.PostMessageId == parameters.PostMessageId);
        }
        

        public HashSet<string> AddValidation(PostMessageLike entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(PostMessageLike entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(PostMessageLike entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(PostMessageLike entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(PostMessageLike parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(PostMessageLike parameters)
        {
            throw new NotImplementedException();
        }

        public IPostMessageDetailUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IPostMessageLikeDomain : ICoreDomain<PostMessageLike, PostMessageLike> { }
}
