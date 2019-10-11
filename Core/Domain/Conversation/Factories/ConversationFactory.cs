using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Conversation.Factories
{
    public class ConversationFactory:IConversationFactory
    {
        public Task<Conversation> CreateAsync()
        {
            throw new NotImplementedException();
        }
    }
}
