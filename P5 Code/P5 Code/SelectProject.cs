﻿using System;
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
        public Project projectTest = new Project();
        private Button SelectButton;
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
            this.SelectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(30, 29);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(422, 251);
            this.listBox2.TabIndex = 0;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(283, 316);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(169, 42);
            this.SelectButton.TabIndex = 1;
            this.SelectButton.Text = "Select Project";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // SelectProject
            // 
            this.ClientSize = new System.Drawing.Size(489, 404);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.listBox2);
            this.Name = "SelectProject";
            this.Text = "Select Project";
            this.ResumeLayout(false);

        }

        private void SelectProject_Load(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            string name = listBox2.SelectedItem.ToString();
            foreach (var project in projects)
            {
                if (project.name == name)
                {
                    projectTest.name = project.name;
                    projectTest.id = project.id;
                }
            }

            this.Close();
        }
    }
}
