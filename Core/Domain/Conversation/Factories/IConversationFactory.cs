using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Conversation.Factories
{
    public interface IConversationFactory
    {
        Task<Conversation> CreateAsync();
    }
}
