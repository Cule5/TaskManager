using System;
using System.Collections.Generic;
using System.Text;
using Services.Common.Query;
using Services.Project.Dtos;

namespace Services.Project.Query
{
    public class AllProjects:IQuery<IEnumerable<CommonProjectDto>>
    {
    }
}
