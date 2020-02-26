using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using FBRxweb.UnitOfWork.Main;
using FBRxweb.Models.Main;

namespace FBRxweb.Domain.PostMessageDetailModule
{
    public class PostMessageCommentDomain : IPostMessageCommentDomain
    {
        public PostMessageCommentDomain(IPostMessageDetailUow uow) {
            this.Uow = uow;
        }

        public Task<object> GetAsync(PostMessageComment parameters)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetBy(PostMessageComment parameters)
        {
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(PostMessageComment entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(PostMessageComment entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(PostMessageComment entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(PostMessageComment entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(PostMessageComment parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(PostMessageComment parameters)
        {
            throw new NotImplementedException();
        }

        public IPostMessageDetailUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IPostMessageCommentDomain : ICoreDomain<PostMessageComment, PostMessageComment> { }
}
