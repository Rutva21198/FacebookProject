using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using FBRxweb.UnitOfWork.Main;
using FBRxweb.Models.Main;

namespace FBRxweb.Domain.PostDetailModule
{
    public class PostCommentDomain : IPostCommentDomain
    {
        public PostCommentDomain(IPostDetailUow uow) {
            this.Uow = uow;
        }

        public  Task<object> GetAsync(PostComment parameters)
        {
            throw new NotImplementedException();
        }

        public  Task<object> GetBy(PostComment parameters)
        {
            throw new NotImplementedException();
            //return await Uow.Repository<FacebookUser>().SingleOrDefaultAsync(t => t.PostId == parameters.PostId);
        }
        

        public HashSet<string> AddValidation(PostComment entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(PostComment entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(PostComment entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(PostComment entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(PostComment parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(PostComment parameters)
        {
            throw new NotImplementedException();
        }

        public IPostDetailUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IPostCommentDomain : ICoreDomain<PostComment, PostComment> { }
}
