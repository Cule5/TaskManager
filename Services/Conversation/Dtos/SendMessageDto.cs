using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Conversation.Dtos
{
    public class SendMessageDto
    {
        public SendMessageDto(int senderId,int receiverId,string message)
        {
            SenderId = senderId;
            ReceiverId = receiverId;
            Message = message;
        }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public string Message { get; set; }
    }
}
