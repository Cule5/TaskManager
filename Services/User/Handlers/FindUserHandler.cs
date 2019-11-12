using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.EntityFramework;
using Services.Common.Query;
using Services.User.Dtos;
using Services.User.Query;

namespace Services.User.Handlers
{
    public class FindUserHandler:IQueryHandler<FindUser,IEnumerable<FindUserDto>>
    {
        private readonly AppDbContext _dbContext = null;
        public FindUserHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<IEnumerable<FindUserDto>> HandleAsync(FindUser query)
        {
            //return System.Threading.Tasks.Task.Factory.StartNew<IEnumerable<FindUserDto>>(() =>
            //{
            //    var result=new List<FindUserDto>();
                
            //    var users=_dbContext.Users.Select(user=>)
            //});
            throw new NotImplementedException();

        }
    }
}
