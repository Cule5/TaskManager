using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Conversation.Repositories
{
    public interface IConversationRepository
    {
        System.Threading.Tasks.Task AddAsync(Conversation conversation);

    }
}
