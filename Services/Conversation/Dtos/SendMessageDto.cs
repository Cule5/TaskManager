using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Conversation.Dtos
{
    public class SendMessageDto
    {
        public SendMessageDto(int senderId,int receiverId,string title,string message)
        {
            SenderId = senderId;
            ReceiverId = receiverId;
            Title = title;
            Message = message;
        }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
    }
}
