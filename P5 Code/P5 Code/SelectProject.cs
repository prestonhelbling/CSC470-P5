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
using P5_Code;

namespace P5_Code
{
    public partial class SelectProject : Form
    {
        private ListBox listBox2;
        
        FakeProjectRepository projectDatabase = new FakeProjectRepository();
        public Project project;
        private static List<Project> projects;



        public SelectProject()
        {
            InitializeComponent();

            projects = projectDatabase.GetAll();
            foreach (var project in projects){
                listBox2.Items.Add(project.name);
            }   
        }

        public void InitializeComponent()
        {
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(46, 29);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(385, 303);
            this.listBox2.TabIndex = 0;
            // 
            // SelectProject
            // 
            this.ClientSize = new System.Drawing.Size(489, 404);
            this.Controls.Add(this.listBox2);
            this.Name = "SelectProject";
            this.Text = "Select Project";
            this.ResumeLayout(false);

            
            

        }

        private void SelectProject_Load(object sender, EventArgs e)
        {

        }

     
    }
}
