using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.EntityFramework;
using Services.Common.Query;
using Services.Conversation.Query;

namespace Services.Conversation.Handlers
{
    public class GetMessageHandler:IQueryHandler<GetMessage,string>
    {
        private readonly AppDbContext _dbContext = null;
        public GetMessageHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<string> HandleAsync(GetMessage query)
        {
            var dbConversation=await _dbContext.Conversations.FindAsync(query.ConversationId);
            return dbConversation != null ? dbConversation.Message : string.Empty;
        }
    }
}
