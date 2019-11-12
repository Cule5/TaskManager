using System;
using System.Collections.Generic;
using System.Text;
using Services.Common.Command;

namespace Services.Conversation.Command
{
    public class SendMessage:ICommand
    {
        
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public string Message { get; set; }
    }
}
