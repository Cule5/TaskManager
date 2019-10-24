using System;
using System.Collections.Generic;
using System.Text;
using Core.Domain.Conversation.Repositories;

namespace Services.Conversation
{
    public class ConversationService:IConversationService
    {
        private readonly IConversationRepository _conversationRepository = null;
        public ConversationService(IConversationRepository conversationRepository)
        {
            _conversationRepository = conversationRepository;
        }
        public async System.Threading.Tasks.Task SendMessageAsync()
        {
            throw new NotImplementedException();
        }
    }
}
