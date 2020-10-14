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
    public class AddProject : Form
    {
        private TextBox textBox1;
        private Label label1;
        private Button AddButton;
        private Button CancelButton;

        public static List<Project> projects;
       
        public Project newProject = new Project();

        public AddProject(FakeProjectRepository projectDatabase)
        {
            projects = projectDatabase.GetAll();
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(344, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Project Name:";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(283, 116);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(148, 31);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Confirm";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(87, 116);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(135, 31);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddProject
            // 
            this.ClientSize = new System.Drawing.Size(524, 200);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "AddProject";
            this.Text = "Create Project";
            this.Load += new System.EventHandler(this.AddProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void AddProject_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void AddButton_Click(object sender, EventArgs e)
        {
            newProject.name = textBox1.Text;

            projects.Add(newProject);

            this.Close();
        }
    }
}
