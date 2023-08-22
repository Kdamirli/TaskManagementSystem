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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ucAddEmployee1_Load(object sender, EventArgs e)
        {
            ucAddEmployee1.Visible = false;
            ucAddDepartment1.Visible = false;
            ucAddAssignment1.Visible = false;
            ucSearch1.Visible = false;
            ucAddOrganization1.Visible = false;
            ucAddProject1.Visible = false;
            BringToFront();

        }

        private void btn_AddRoom_Click(object sender, EventArgs e)
        {
            ucAddEmployee1.Visible = true;
            ucAddDepartment1.Visible = false;
            ucAddAssignment1.Visible = false;
            ucSearch1.Visible = false;
            ucAddOrganization1.Visible = false;
            ucAddProject1.Visible = false;
            BringToFront();
        }

        private void btn_AddOrg_Click(object sender, EventArgs e)
        {
            ucAddEmployee1.Visible = false;
            ucAddDepartment1.Visible = false;
            ucAddAssignment1.Visible = false;
            ucSearch1.Visible = false;
            ucAddOrganization1.Visible = true;
            ucAddProject1.Visible = false;
            BringToFront();
        }

        private void btn_AddDep_Click(object sender, EventArgs e)
        {
            ucAddEmployee1.Visible = false;
            ucAddDepartment1.Visible = true;
            ucAddAssignment1.Visible = false;
            ucSearch1.Visible = false;
            ucAddOrganization1.Visible = false;
            ucAddProject1.Visible = false;
            BringToFront();
        }

        private void btn_AddProj_Click(object sender, EventArgs e)
        {
            ucAddEmployee1.Visible = false;
            ucAddDepartment1.Visible = false;
            ucAddAssignment1.Visible = false;
            ucSearch1.Visible = false;
            ucAddOrganization1.Visible = false;
            ucAddProject1.Visible = true;
            BringToFront();
        }

        private void btn_AddLink_Click(object sender, EventArgs e)
        {
            ucAddEmployee1.Visible = false;
            ucAddDepartment1.Visible = false;
            ucAddAssignment1.Visible = false;
            ucSearch1.Visible = true;
            ucAddOrganization1.Visible = false;
            ucAddProject1.Visible = false;
            BringToFront();
        }

        private void btn_AddTask_Click(object sender, EventArgs e)
        {
            ucAddEmployee1.Visible = false;
            ucAddDepartment1.Visible = false;
            ucAddAssignment1.Visible = true;
            ucSearch1.Visible = false;
            ucAddOrganization1.Visible = false;
            ucAddProject1.Visible = false;
            BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ucAddEmployee1.Visible = false;
            ucAddDepartment1.Visible = false;
            ucAddAssignment1.Visible = false;
            ucSearch1.Visible = false;
            ucAddOrganization1.Visible = false;
            ucAddProject1.Visible = false;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
