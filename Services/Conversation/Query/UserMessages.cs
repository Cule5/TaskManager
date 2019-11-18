using System;
using System.Collections.Generic;
using System.Text;
using Services.Common.Query;
using Services.Conversation.Dtos;

namespace Services.Conversation.Query
{
    public class UserMessages:IQuery<IEnumerable<UserMessagesDto>>
    {
        public UserMessages(int userId)
        {
            UserId = userId;
        }
        public int UserId { get; }
    }
}
