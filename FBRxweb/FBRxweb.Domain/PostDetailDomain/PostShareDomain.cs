using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using FBRxweb.UnitOfWork.Main;
using FBRxweb.Models.Main;

namespace FBRxweb.Domain.PostDetailModule
{
    public class PostShareDomain : IPostShareDomain
    {
        public PostShareDomain(IPostDetailUow uow) {
            this.Uow = uow;
        }

        public  Task<object> GetAsync(PostShare parameters)
        {
            throw new NotImplementedException();
            
        }

        public async Task<object> GetBy(PostShare parameters)
        {
            //throw new NotImplementedException();
            return await Uow.Repository<PostShare>().FindByAsync(t => t.PostId == parameters.PostId);
        }
        

        public HashSet<string> AddValidation(PostShare entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(PostShare entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(PostShare entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(PostShare entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(PostShare parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(PostShare parameters)
        {
            throw new NotImplementedException();
        }

        public IPostDetailUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IPostShareDomain : ICoreDomain<PostShare, PostShare> { }
}
