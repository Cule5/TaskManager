using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Common;
using Services.Common.Query;
using Services.User.Query;

namespace Services.User.Handlers
{
    public class AllUsersTypesHandler:IQueryHandler<AllUsersTypes,IEnumerable<string>>
    {
        public Task<IEnumerable<string>> HandleAsync(AllUsersTypes query)
        {
            return System.Threading.Tasks.Task.Factory.StartNew<IEnumerable<string>>(() =>
            {
                var usersType = new List<string>() { EUserType.ProjectManager.ToString(), EUserType.Worker.ToString() };
                return usersType;
            });
        }
    }
}
