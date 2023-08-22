using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TaskManagementSystem.viewProjectDSTableAdapters;

namespace TaskManagementSystem.User_Controls
{
    public partial class UCProject : UserControl
    {
        viewProjectTableAdapter viewProjectTableAdapter = new viewProjectTableAdapter();
        public UCProject()
        {
            InitializeComponent();
        }

        private void UCProject_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = viewProjectTableAdapter.GetData();
        }

        private void UCProject_Enter(object sender, EventArgs e)
        {
            UCProject_Load(this, null);
        }
    }
}
