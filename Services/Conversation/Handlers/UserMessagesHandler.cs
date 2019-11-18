using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Services.Common.Query;
using Services.Conversation.Dtos;
using Services.Conversation.Query;

namespace Services.Conversation.Handlers
{
    public class UserMessagesHandler:IQueryHandler<UserMessages,IEnumerable<UserMessagesDto>>
    {
        private readonly AppDbContext _dbContext = null;
        public UserMessagesHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<UserMessagesDto>> HandleAsync(UserMessages query)
        {
            return await _dbContext.Conversations
                .Where(conversation => conversation.Receiver.UserId == query.UserId)
                .Select(conversation=>new UserMessagesDto())
                .ToListAsync();
        }
    }
}
