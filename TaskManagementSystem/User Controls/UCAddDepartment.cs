using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TaskManagementSystems;

namespace TaskManagementSystem.User_Controls
{
    public partial class UCAddDepartment : UserControl
    {
        TaskManagementSystemEntities1 db;
        department dep = new department();
        Func func = new Func();
        public UCAddDepartment()
        {
            InitializeComponent();
        }

        public void clearAll()
        {
            tbName.Clear();
            tbPhonNo.Clear();
            cbOrganization.SelectedIndex = -1;
        }

        public void setComboBox(String query, ComboBox combo)
        {
            SqlDataReader sdr = func.getForCombo(query);
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
        }

        private void UCAddDepartment_Load(object sender, EventArgs e)
        {
            db = new TaskManagementSystemEntities1();
            this.viewDepartmentTableAdapter.Fill(this.viewDepartmentDS.viewDepartment);
            cbOrganization.Items.Clear();
            setComboBox("select nameOrganization from organization", cbOrganization);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if(tbName.Text != "" && tbPhonNo.Text != "" && cbOrganization.Text != "")
            {
                dep.nameDepartment = tbName.Text.Trim();
                dep.telephoneNumber = tbPhonNo.Text.Trim();
                dep.organization_id = cbOrganization.SelectedIndex + 1;
                db.department.Add(dep);
                db.SaveChanges();
                MessageBox.Show("Отделение добавлено!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UCAddDepartment_Load(this, null);
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UCAddDepartment_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UCAddDepartment_Enter(object sender, EventArgs e)
        {
            UCAddDepartment_Load(this, null);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены?", "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {

                var entry = db.Entry(dep);
                if (entry.State == EntityState.Detached)
                {
                    db.department.Attach(dep);
                }
                db.department.Remove(dep);
                db.SaveChanges();
                UCAddDepartment_Load(this, null);
                MessageBox.Show("Отделение удалено!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        

        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Вы уверены?", "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                MessageBox.Show(Convert.ToString(Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["названиеОтеделенияDataGridViewTextBoxColumn"].RowIndex + 1)));
                string query = "delete from department where id = " + Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["названиеОтеделенияDataGridViewTextBoxColumn"].RowIndex + 1) + "";
                UCAddDepartment_Load(this, null);
                MessageBox.Show("Отделение удалено!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
