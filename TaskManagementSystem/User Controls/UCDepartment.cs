using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TaskManagementSystem.viewDepartmentDSTableAdapters;

namespace TaskManagementSystem.User_Controls
{
    public partial class UCDepartment : UserControl
    {
        viewDepartmentTableAdapter viewDepartmentTableAdapter = new viewDepartmentTableAdapter();
        public UCDepartment()
        {
            InitializeComponent();
        }

        private void UCDepartment_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = viewDepartmentTableAdapter.GetData();
        }

        private void UCDepartment_Enter(object sender, EventArgs e)
        {
            UCDepartment_Load(this, null);
        }
    }
}
