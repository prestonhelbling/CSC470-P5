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

    public partial class ModifyProject : Form
    {
        public static List<Project> projects;

        public ModifyProject()
        {
        InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {

        }

        private void ModifyProject_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            object selectedItem = SelectProject.SelectedItem.ToString();
            string name = textBox1.Text;
            selectedItem = name;
        }
    }
}
