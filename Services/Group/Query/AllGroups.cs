using System;
using System.Collections.Generic;
using System.Text;
using Services.Common.Query;
using Services.Group.Dtos;

namespace Services.Group.Query
{
    public class AllGroups:IQuery<IEnumerable<CommonGroupDto>>
    {
    }
}
