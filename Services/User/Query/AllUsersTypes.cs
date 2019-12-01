using System;
using System.Collections.Generic;
using System.Text;
using Core.Domain.Common;
using Services.Common.Query;

namespace Services.User.Query
{
    public class AllUsersTypes:IQuery<IEnumerable<EUserType>>
    {
    }
}
