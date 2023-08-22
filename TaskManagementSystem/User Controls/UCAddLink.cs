using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TaskManagementSystems;

namespace TaskManagementSystem.User_Controls
{
    public partial class UCAddLink : UserControl
    {
        Func func = new Func();
        TaskManagementSystemEntities1 db;
        link link = new link();

        public UCAddLink()
        {
            InitializeComponent();
        }

        public void clearAll()
        {
            cbProject.SelectedIndex = -1;
            cbDepartment.SelectedIndex = -1;
            cbEmployee.SelectedIndex = -1;
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

        private void UCAddLink_Load(object sender, EventArgs e)
        {
            this.viewLinkTableAdapter.Fill(this.viewLinkDS.viewLink);
            db = new TaskManagementSystemEntities1();
            cbProject.Items.Clear();
            cbDepartment.Items.Clear();
            cbEmployee.Items.Clear();
            setComboBox("select projectName from project", cbProject);
            setComboBox("select nameDepartment from department", cbDepartment);
            setComboBox("select name from employee", cbEmployee);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if(cbProject.Text != "" && cbDepartment.Text != "" && cbEmployee.Text != "")
            {
                link.project_id = cbProject.SelectedIndex + 1;
                link.department_id = cbDepartment.SelectedIndex + 1;
                link.employee_id = cbEmployee.SelectedIndex + 1;
                db.link.Add(link);
                db.SaveChanges();
                MessageBox.Show("Связь добавлена!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UCAddLink_Load(this, null);
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UCAddLink_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UCAddLink_Enter(object sender, EventArgs e)
        {
            UCAddLink_Load(this, null);
        }
    }
}
