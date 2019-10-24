using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.GroupProject
{
    public class GroupProject
    {
        public GroupProject(Group.Group group,Project.Project project)
        {
            Group = group;
            Project = project;
        }
        public int GroupId { get; set; }
        public virtual Group.Group Group{get; set; }
        public int ProjectId { get; set; }
        public virtual Project.Project Project { get; set; }
    }
}
