using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace P5_Code
{
    public partial class RemoveProject : Form
    {
        private static List<Project> projects;
        private object removedProject;

        public RemoveProject(FakeProjectRepository projectDatabase)
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void YouSure_TextChanged(object sender, EventArgs e)
        {

        }

        private void DontRemove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemoveIt_Click(object sender, EventArgs e)
        {
            object selectedItem = SelectProject.SelectedItem;
            removedProject = selectedItem;
            projects.Remove((Project)removedProject);

            this.Close();
        }
    }
}
