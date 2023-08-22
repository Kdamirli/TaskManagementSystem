using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TaskManagementSystem.viewEmployeeDSTableAdapters;

namespace TaskManagementSystem.User_Controls
{
    public partial class UCEmployee : UserControl
    {
        viewEmployeeTableAdapter viewEmployeeTableAdapter = new viewEmployeeTableAdapter();
        public UCEmployee()
        {
            InitializeComponent();
        }

        private void UCEmployee_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = viewEmployeeTableAdapter.GetData();
        }

        private void UCEmployee_Enter(object sender, EventArgs e)
        {
            UCEmployee_Load(this, null);
        }
    }
}
