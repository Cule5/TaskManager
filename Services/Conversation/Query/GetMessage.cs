using System;
using System.Collections.Generic;
using System.Text;
using Services.Common.Query;

namespace Services.Conversation.Query
{
    public class GetMessage:IQuery<string>
    {
        public GetMessage(int conversationId)
        {
            ConversationId = conversationId;
        }
        public int ConversationId { get; }
    }
}
