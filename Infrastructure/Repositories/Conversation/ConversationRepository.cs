using System;
using System.Collections.Generic;
using System.Text;
using Core.Domain.Conversation.Repositories;
using Infrastructure.EntityFramework;

namespace Infrastructure.Repositories.Conversation
{
    public class ConversationRepository:IConversationRepository
    {
        private readonly AppDbContext _dbContext = null;
        public ConversationRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public System.Threading.Tasks.Task AddAsync(Core.Domain.Conversation.Conversation conversation)
        {
            throw new NotImplementedException();
        }
    }
}
