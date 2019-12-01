using System;
using System.Collections.Generic;
using System.Text;
using Services.Conversation.Dtos;

namespace Services.Conversation
{
    public interface IConversationService
    {
        System.Threading.Tasks.Task SendMessageAsync(SendMessageDto sendMessageDto);
        System.Threading.Tasks.Task ChangeMessageStateAsync(int conversationId);
    }
}
