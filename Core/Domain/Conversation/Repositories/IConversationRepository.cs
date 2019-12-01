using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Conversation.Repositories
{
    public interface IConversationRepository
    {
        System.Threading.Tasks.Task AddAsync(Conversation conversation);
        Task<Conversation> GetAsync(int conversationId);

    }
}
