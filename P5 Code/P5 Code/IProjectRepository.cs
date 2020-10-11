﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5_Code
{
    interface IProjectRepository
    {
        
        string Add(Project project, out int Id);

        string Remove(int projectId);
        string Modify(int projectId, Project project);
        List<Project> GetAll();
        bool IsDuplicateName(string projectName);

    }
}
