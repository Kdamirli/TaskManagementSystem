﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TaskManagementSystem.viewOrganizationDSTableAdapters;

namespace TaskManagementSystem.User_Controls
{
    public partial class UCOrganization : UserControl
    {
        viewOrganizationTableAdapter viewOrganizationTableAdapter = new viewOrganizationTableAdapter();
        public UCOrganization()
        {
            InitializeComponent();
        }

        private void UCOrganization_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = viewOrganizationTableAdapter.GetData();
        }

        private void UCOrganization_Enter(object sender, EventArgs e)
        {
            UCOrganization_Load(this, null);
        }
    }
}
