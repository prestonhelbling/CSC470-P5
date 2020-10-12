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


namespace P5_Code
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            FakeAppUserRepository userDatabase = new FakeAppUserRepository();
            Project projectTest = new Project();
            
            FormLogin formLogin = new FormLogin();
            SelectProject selectProject = new SelectProject();
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
            this.Text = "Main -" + projectTest.name;
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void countByAssigneeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        
    }
}
