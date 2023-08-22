using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TaskManagementSystem.ucAssignmentTableAdapters;

namespace TaskManagementSystem.User_Controls
{
    public partial class UCAssignment : UserControl
    {
        viewAssignmentTableAdapter viewAssignmentTableAdapter = new viewAssignmentTableAdapter();
        public UCAssignment()
        {
            InitializeComponent();
        }

        private void UCAssignment_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = viewAssignmentTableAdapter.GetData();
        }

        private void UCAssignment_Enter(object sender, EventArgs e)
        {
            UCAssignment_Load(this, null);
        }
    }
}
