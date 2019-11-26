using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Services.Common.Query;
using Services.Group.Dtos;
using Services.Group.Query;

namespace Services.Group.Handlers
{
    public class AllGroupsHandler:IQueryHandler<AllGroups,IEnumerable<CommonGroupDto>>
    {
        private readonly AppDbContext _dbContext = null;
        public AllGroupsHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<CommonGroupDto>> HandleAsync(AllGroups query)
        {
            return await _dbContext.Groups.Select(group =>new CommonGroupDto(group.GroupId,group.GroupName)).ToListAsync();
        }
    }
}
