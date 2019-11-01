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
        public int ConversationId { get; set; }
        public string Message { get; set; }
        public virtual User.User Sender { get; set; }
        public virtual User.User Receiver { get; set; }
        public EMessageStatus MessageStatus { get; set; }
    }
}
