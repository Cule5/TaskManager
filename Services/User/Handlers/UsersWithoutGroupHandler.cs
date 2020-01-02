using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Common;
using Infrastructure.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Services.Common.Query;
using Services.User.Dtos;
using Services.User.Query;

namespace Services.User.Handlers
{
    public class UsersWithoutGroupHandler:IQueryHandler<UsersWithoutGroup,IEnumerable<CommonUserDto>>
    {
        private readonly AppDbContext _dbContext = null;
        public UsersWithoutGroupHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<CommonUserDto>> HandleAsync(UsersWithoutGroup query)
        {
            var u=await _dbContext.Users.Where(user => user.Group == null && user.Account.UserType != EUserType.CompanyAdmin).Select(user => new CommonUserDto(user.UserId, user.Name, user.LastName, user.Account.Email)).ToListAsync();
            return await _dbContext.Users.Where(user => user.Group == null&&user.Account.UserType!=EUserType.CompanyAdmin).Select(user=>new CommonUserDto(user.UserId,user.Name,user.LastName,user.Account.Email)).ToListAsync();
        }
    }
}
