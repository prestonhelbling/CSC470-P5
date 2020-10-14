using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace P5_Code
{
    
    public partial class FormMain : Form
    {
        Project projectTest = new Project();
        
        public FakeProjectRepository projectDatabase = new FakeProjectRepository();


        public FormMain()
        {
            InitializeComponent();



            FakeAppUserRepository userDatabase = new FakeAppUserRepository();
            FormLogin formLogin = new FormLogin();
            SelectProject selectProject = new SelectProject(projectDatabase);
            AppUser user = new AppUser();
            formLogin.ShowDialog();
            while (!user.IsAuthenticated && formLogin.IsOpen)
            {
                formLogin.ShowDialog();
                user = formLogin.user;
            }
            if (!formLogin.IsAuthenticated)
                Environment.Exit(0);

            selectProject.ShowDialog();
            projectTest = selectProject.projectTest;
            this.Text = "Main - " + projectTest.name;
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void countByAssigneeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void selectProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectProject selectProject = new SelectProject(projectDatabase);
            selectProject.ShowDialog();
            projectTest = selectProject.projectTest;
            this.Text = "Main - " + projectTest.name;
        }

        private void createProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProject addProject = new AddProject(projectDatabase);
            addProject.ShowDialog();
           
            projectTest = addProject.newProject;
            if(projectTest.name != null)
                this.Text = "Main - " + projectTest.name;
        }

        private void removeProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectProject removeProject = new SelectProject(projectDatabase);
            removeProject.ShowDialog();

            projectTest = removeProject.projectTest;
        }
    }
}
