using System;
using System.Collections.Generic;
using System.Text;
using Services.Common.Command;
using Services.Conversation.Command;

namespace Services.Conversation.Handlers
{
    class SendMessageHandler:ICommandHandler<SendMessage>
    {
        private readonly IConversationService _conversationService = null;
        public SendMessageHandler(IConversationService conversationService)
        {
            _conversationService = conversationService;
        }
        public async System.Threading.Tasks.Task HandleAsync(SendMessage command)
        {
            await _conversationService.SendMessageAsync();
        }
    }
}
