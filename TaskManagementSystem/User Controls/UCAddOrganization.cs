using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TaskManagementSystems;

namespace TaskManagementSystem.User_Controls
{
    public partial class UCAddOrganization : UserControl
    {
        TaskManagementSystemEntities1 db;
        organization org = new organization();

        public UCAddOrganization()
        {
            InitializeComponent();
        }

        private void UCAddOrganization_Load(object sender, EventArgs e)
        {
            this.viewOrganizationTableAdapter.Fill(this.viewOrganizationDS.viewOrganization);
            db = new TaskManagementSystemEntities1();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if(tbAddress.Text != "" && tbName.Text != "")
            {
                org.nameOrganization = tbName.Text.Trim();
                org.address = tbAddress.Text.Trim();
                db.organization.Add(org);
                db.SaveChanges();
                MessageBox.Show("Организация добавлено!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UCAddOrganization_Load(this, null);
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
