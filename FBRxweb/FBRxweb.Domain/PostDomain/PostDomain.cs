using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using FBRxweb.UnitOfWork.Main;
using FBRxweb.Models.Main;

namespace FBRxweb.Domain.PostModule
{
    public class PostDomain : IPostDomain
    {
        public PostDomain(IPostUow uow) {
            this.Uow = uow;
        }

        public Task<object> GetAsync(Post parameters)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetBy(Post parameters)
        {
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(Post entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(Post entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(Post entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(Post entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(Post parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(Post parameters)
        {
            throw new NotImplementedException();
        }

        public IPostUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IPostDomain : ICoreDomain<Post, Post> { }
}
