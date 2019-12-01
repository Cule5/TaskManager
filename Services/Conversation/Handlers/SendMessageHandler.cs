using System;
using System.Collections.Generic;
using System.Text;
using Services.Common.Command;
using Services.Conversation.Command;
using Services.Conversation.Dtos;

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
            await _conversationService.SendMessageAsync(new SendMessageDto(command.SenderId,command.ReceiverId,command.Title,command.Message));
        }
    }
}
