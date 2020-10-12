using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace P5_Code
{
    public class FakeProjectRepository : IProjectRepository
    {
        public const string NO_ERROR = "";
        public const string MODIFIED_PROJECT_ID_ERROR = "Can not modify the project id.";
        public const string DUPLICATE_PROJECT_NAME_ERROR = "Project name already exists.";
        public const string NO_PROJECT_FOUND_ERROR = "No project found.";
        public const string EMPTY_PROJECT_NAME_ERROR = "Project name is empty or blank.";

        private static List<Project> projects;
        
        
        public FakeProjectRepository()
        {
            // Default projects on creation of class. 

            projects = new List<Project>();


            Project defaultProjectOne = new Project();
                defaultProjectOne.name = "Town House";

                Add(defaultProjectOne, out defaultProjectOne.id);

                Project defaultProjectTwo = new Project();
                defaultProjectTwo.name = "Adobe House";

                projects.Add(defaultProjectTwo);

                Project defaultProjectThree = new Project();
                defaultProjectThree.name = "Large Fence";

                projects.Add(defaultProjectThree);
            
        }

        public string Add(Project project, out int Id)
        {
            // Removes leaving and trailing spaces. 
            project.name = project.name.Trim(' ');
            // Empty Project Name
            if(project.name.Equals(""))
            {
                Id = -1;
                return EMPTY_PROJECT_NAME_ERROR;
            }
            // Duplicate project name.
            else if(IsDuplicateName(project.name))
            {
                Id = -1;
                return DUPLICATE_PROJECT_NAME_ERROR;
            }
            // Succesfully add the project. 
            else
            {
                project.id = GetNextId();
                Id = project.id;
                projects.Add(project);
                return NO_ERROR;
            }
        }

        public string Remove(int projectId)
        {
            // Loop through the projects and compare the id's. If we find that id remove it. 
            foreach (Project project in projects)
            {
                if (project.id == projectId)
                {
                    projects.RemoveAt(projectId + 1);
                    return NO_ERROR;
                }
            }
            // Failed to find project with ID.
            return NO_PROJECT_FOUND_ERROR;
        }
        public string Modify(int projectId, Project project)
        {
            return "test";
        }

        public List<Project> GetAll()
        {
            return projects;
        }
        public bool IsDuplicateName(string projectName)
        {
            // Loop through the projects and compare the names. If we find a duplicate return true.
            foreach(Project project in projects)
            {
                if(project.name.Equals(projectName))
                {
                    return true;
                }
            }
            // No duplicate was found.
            return false;
        }

        private int GetNextId()
        {
            Project lastProjectInList = projects.LastOrDefault<Project>();

            // Found a project. 
            if (lastProjectInList != null)
            {
                int newId = lastProjectInList.id + 1;
                return newId;
            }
            // List is empty. 
            else
            {
                return -1;
            }
        }
    }
}
