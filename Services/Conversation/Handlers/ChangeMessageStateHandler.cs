using System;
using System.Collections.Generic;
using System.Text;
using Services.Common.Command;
using Services.Conversation.Command;

namespace Services.Conversation.Handlers
{
    public class ChangeMessageStateHandler:ICommandHandler<ChangeMessageState>
    {
        private readonly IConversationService _conversationService = null;

        public ChangeMessageStateHandler(IConversationService conversationService)
        {
            _conversationService = conversationService;
        }
        public System.Threading.Tasks.Task HandleAsync(ChangeMessageState command)
        {
            throw new NotImplementedException();
        }
    }
}
