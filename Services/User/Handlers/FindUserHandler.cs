using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Services.Common.Query;
using Services.User.Dtos;
using Services.User.Query;

namespace Services.User.Handlers
{
    public class FindUserHandler:IQueryHandler<FindUser,IEnumerable<CommonUserDto>>
    {
        private readonly AppDbContext _dbContext = null;
        public FindUserHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<CommonUserDto>> HandleAsync(FindUser query)
        {
            return await _dbContext.Users
                .Where(user => user.Name.Equals(query.Name) && user.LastName.Equals(query.LastName))
                .Select(user => new CommonUserDto(user.UserId, user.Name, user.LastName,user.Account.Email)).ToListAsync();
        }
    }
}
