using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Conversation.Factories
{
    public class ConversationFactory:IConversationFactory
    {
        public Task<Conversation> CreateAsync(User.User receiver, User.User sender,string title, string message)
        {
            return System.Threading.Tasks.Task.Factory.StartNew(() => new Conversation(title,message,receiver,sender));
        }
    }
}
