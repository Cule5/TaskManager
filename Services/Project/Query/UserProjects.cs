using System;
using System.Collections.Generic;
using System.Text;
using Services.Common.Query;
using Services.Project.Dtos;

namespace Services.Project.Query
{
    public class UserProjects:IQuery<IEnumerable<CommonProjectDto>>
    {
        public UserProjects(int userId)
        {
            UserId = userId;
        }
        public int UserId { get; }
    }
}
