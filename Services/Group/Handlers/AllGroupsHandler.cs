using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Services.Common.Query;
using Services.Group.Query;

namespace Services.Group.Handlers
{
    public class AllGroupsHandler:IQueryHandler<AllGroups,IEnumerable<string>>
    {
        private readonly AppDbContext _dbContext = null;
        public AllGroupsHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<string>> HandleAsync(AllGroups query)
        {
            return await _dbContext.Groups.Select(group => group.GroupName).ToListAsync();
        }
    }
}
