using System;
using System.Collections.Generic;
using System.Text;
using Core.Domain.Common;

namespace Services.Conversation.Dtos
{
    public class UserMessagesDto
    {
        public UserMessagesDto(int conversationId,string senderEmail,string title,EMessageStatus messageStatus)
        {
            ConversationId = conversationId;
            SenderEmail = senderEmail;
            Title = title;
            MessageStatus = messageStatus;
        }
        public int ConversationId { get; }
        public string SenderEmail { get; }
        public string Title { get; }
        public EMessageStatus MessageStatus { get; }
    }
}
