using System;
using System.Collections.Generic;
using System.Text;
using Services.Common.Command;

namespace Services.Conversation.Command
{
    public class SendMessage:ICommand
    {
        public string Message { get; set; }
    }
}
