using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using FBRxweb.UnitOfWork.Main;
using FBRxweb.Models.Main;

namespace FBRxweb.Domain.UserChatModule
{
    public class ChatMediaDomain : IChatMediaDomain
    {
        public ChatMediaDomain(IUserChatUow uow) {
            this.Uow = uow;
        }

        public async Task<object> GetAsync(ChatMedia parameters)
        {
            //throw new NotImplementedException();
            return await Uow.Repository<ChatMedia>().AllAsync();
        }

        public Task<object> GetBy(ChatMedia parameters)
        {
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(ChatMedia entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(ChatMedia entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(ChatMedia entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(ChatMedia entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(ChatMedia parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(ChatMedia parameters)
        {
            throw new NotImplementedException();
        }

        public IUserChatUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IChatMediaDomain : ICoreDomain<ChatMedia, ChatMedia> { }
}
