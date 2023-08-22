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
    public partial class DirectorPanel : Form
    {
        public DirectorPanel()
        {
            InitializeComponent();
        }

        private void btn_AddEmp_Click(object sender, EventArgs e)
        {
            ucAssignment1.Visible = false;
            ucDepartment1.Visible = false;
            ucEmployee1.Visible = true;
            ucOrganization1.Visible = false;
            ucProject1.Visible = false;
            ucSearch1.Visible = false;
            BringToFront();
        }

        private void btn_AddOrg_Click(object sender, EventArgs e)
        {
            ucAssignment1.Visible = false;
            ucDepartment1.Visible = false;
            ucEmployee1.Visible = false;
            ucOrganization1.Visible = true;
            ucProject1.Visible = false;
            ucSearch1.Visible = false;
            BringToFront();
        }

        private void btn_AddDep_Click(object sender, EventArgs e)
        {
            ucAssignment1.Visible = false;
            ucDepartment1.Visible = true;
            ucEmployee1.Visible = false;
            ucOrganization1.Visible = false;
            ucProject1.Visible = false;
            ucSearch1.Visible = false;
            BringToFront();
        }

        private void btn_AddProj_Click(object sender, EventArgs e)
        {
            ucAssignment1.Visible = false;
            ucDepartment1.Visible = false;
            ucEmployee1.Visible = false;
            ucOrganization1.Visible = false;
            ucProject1.Visible = true;
            ucSearch1.Visible = false;
            BringToFront();
        }

        private void btn_AddLink_Click(object sender, EventArgs e)
        {
            ucAssignment1.Visible = false;
            ucDepartment1.Visible = false;
            ucEmployee1.Visible = false;
            ucOrganization1.Visible = false;
            ucProject1.Visible = false;
            ucSearch1.Visible = true;
            BringToFront();
        }

        private void btn_AddTask_Click(object sender, EventArgs e)
        {
            ucAssignment1.Visible = true;
            ucDepartment1.Visible = false;
            ucEmployee1.Visible = false;
            ucOrganization1.Visible = false;
            ucProject1.Visible = false;
            ucSearch1.Visible = false;
            BringToFront();
        }

        private void DirectorPanel_Load(object sender, EventArgs e)
        {
            ucAssignment1.Visible = false;
            ucDepartment1.Visible = false;
            ucEmployee1.Visible = false;
            ucOrganization1.Visible = false;
            ucProject1.Visible = false;
            ucSearch1.Visible = false;
        }
    }
}
