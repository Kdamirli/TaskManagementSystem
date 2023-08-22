using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaskManagementSystem
{
    public partial class MakeAChoice : Form
    {
        public MakeAChoice()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            AdminReg adminReg = new AdminReg();
            this.Hide();
            adminReg.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DirectorReg directorReg = new DirectorReg();
            this.Hide();
            directorReg.Show();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
