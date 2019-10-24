using System;
using System.Collections.Generic;
using System.Text;
using Core.Domain.Common;

namespace Core.Domain.Conversation
{
    public class Conversation
    {
        public int ConversationId { get; set; }
        public string Message { get; set; }
        public int SenderId { get; set; }
        public User.User Sender { get; set; }
        public int ReceiverId { get; set; }
        public User.User Receiver { get; set; }
        public EMessageStatus MessageStatus { get; set; }
    }
}
