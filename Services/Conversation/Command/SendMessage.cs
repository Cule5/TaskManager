﻿using System;
using System.Collections.Generic;
using System.Text;
using Services.Common.Command;

namespace Services.Conversation.Command
{
    public class SendMessage:ICommand
    {
        public SendMessage()
        {

        }
        public SendMessage(int receiverId,string message)
        {
            ReceiverId = receiverId;
            Message = message;
        }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public string Message { get; set; }
    }
}
