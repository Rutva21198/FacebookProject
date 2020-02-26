using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using FBRxweb.UnitOfWork.Main;
using FBRxweb.Models.Main;

namespace FBRxweb.Domain.UserChatModule
{
    public class ChatMessageDomain : IChatMessageDomain
    {
        public ChatMessageDomain(IUserChatUow uow) {
            this.Uow = uow;
        }

        public async Task<object> GetAsync(ChatMessage parameters)
        {
            //throw new NotImplementedException();
            return await Uow.Repository<ChatMessage>().AllAsync();
        }

        public  Task<object> GetBy(ChatMessage parameters)
        {

            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(ChatMessage entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(ChatMessage entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(ChatMessage entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(ChatMessage entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(ChatMessage parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(ChatMessage parameters)
        {
            throw new NotImplementedException();
        }

        public IUserChatUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IChatMessageDomain : ICoreDomain<ChatMessage, ChatMessage> { }
}
