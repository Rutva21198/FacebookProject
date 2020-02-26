using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using FBRxweb.UnitOfWork.Main;
using FBRxweb.Models.Main;

namespace FBRxweb.Domain.PostDetailModule
{
    public class PostLikeDomain : IPostLikeDomain
    {
        public PostLikeDomain(IPostDetailUow uow) {
            this.Uow = uow;
        }

        public Task<object> GetAsync(PostLike parameters)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetBy(PostLike parameters)
        {
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(PostLike entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(PostLike entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(PostLike entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(PostLike entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(PostLike parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(PostLike parameters)
        {
            throw new NotImplementedException();
        }

        public IPostDetailUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IPostLikeDomain : ICoreDomain<PostLike, PostLike> { }
}
