﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Domain.Project
{
    public class Project
    {
        public Project()
        {

        }
        
        public Project(string projectName,string description,DateTime startDate)
        {
            ProjectName = projectName;
            Description = description;
            StartDate = startDate;
        }
        public int ProjectId { get; set; }
        [Required]
        public string ProjectName { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public virtual ICollection<Task.Task> Tasks { get; set; }=new List<Task.Task>();
        public virtual ICollection<ProjectUser.ProjectUser> ProjectUsers { get; set; }
       
    }
}
