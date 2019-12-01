using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Core.Domain.Common;

namespace Core.Domain.Conversation
{
    public class Conversation
    {
        public Conversation()
        {

        }
        public Conversation(string title,string message,User.User receiver,User.User sender)
        {
            Title = title;
            Message = message;
            Sender = sender;
            Receiver = receiver;
        }
        public int ConversationId { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public int SenderId { get; set; }
        public virtual User.User Sender { get; set; }
        public int ReceiverId { get; set; }
        public virtual User.User Receiver { get; set; }
        public EMessageStatus MessageStatus { get; set; } = EMessageStatus.Unread;

        
    }
}
