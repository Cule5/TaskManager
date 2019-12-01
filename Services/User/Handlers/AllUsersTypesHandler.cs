using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Common;
using Services.Common.Query;
using Services.User.Query;

namespace Services.User.Handlers
{
    public class AllUsersTypesHandler:IQueryHandler<AllUsersTypes,IEnumerable<EUserType>>
    {
        public Task<IEnumerable<EUserType>> HandleAsync(AllUsersTypes query)
        {
            return System.Threading.Tasks.Task.Factory.StartNew<IEnumerable<EUserType>>(() =>
            {
                var usersType = new List<EUserType>() { EUserType.ProjectManager, EUserType.Worker};
                return usersType;
            });
        }
    }
}
