using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.ProjectUser;
using Core.Domain.User.Repositories;
using Infrastructure.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Services.Common.Query;
using Services.Group.Dtos;
using Services.Project.Dtos;
using Services.User.Dtos;
using Services.User.Query;

namespace Services.User.Handlers
{
    public class UserInfoHandler:IQueryHandler<UserInfo,ExtendedUserDto>
    {
        private readonly AppDbContext _dbContext = null;
        public UserInfoHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<ExtendedUserDto> HandleAsync(UserInfo query)
        {
            var projects = await _dbContext.ProjectUsers.Where(projectUser => projectUser.UserId == query.UserId)
                .Select(projectUser => new CommonProjectDto(projectUser.ProjectId,projectUser.Project.ProjectName))
                .ToListAsync();
            var user = _dbContext.Users.Find(query.UserId);
            var commonGroupDto =
                user.Group != null ? new CommonGroupDto(user.Group.GroupId, user.Group.GroupName) : null;
            

            return new ExtendedUserDto(user.UserId,user.Account.UserType,commonGroupDto, projects);

        }
    }
}
