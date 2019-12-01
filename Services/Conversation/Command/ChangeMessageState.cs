using System;
using System.Collections.Generic;
using System.Text;
using Services.Common.Command;

namespace Services.Conversation.Command
{
    public class ChangeMessageState:ICommand
    {
        public int ConversationId { get; set;t }
    }
}
