using TaskManagementSystems;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TaskManagementSystem.User_Controls
{
    public partial class UCAddEmployee : UserControl
    {
        TaskManagementSystemEntities1 db;
        employee emp = new employee();
        Func func = new Func();
        String query;
        public UCAddEmployee()
        {
            InitializeComponent();
        }

        public void clearAll()
        {
            tbName.Clear();
            tbSalary.Clear();
            cbDepartment.SelectedIndex = -1;
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

        private void UCAddEmployee_Load(object sender, EventArgs e)
        {
            db = new TaskManagementSystemEntities1();
            this.viewEmployeeTableAdapter.Fill(this.viewEmployeeDS.viewEmployee);
            cbDepartment.Items.Clear();
            setComboBox("select nameDepartment from department", cbDepartment);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if(tbName.Text != "" && tbSalary.Text != "" && cbDepartment.Text != "")
            {
                emp.name = tbName.Text.Trim();
                emp.salary = Convert.ToDouble(tbSalary.Text.Trim());
                emp.department_id = cbDepartment.SelectedIndex + 1;
                db.employee.Add(emp);
                db.SaveChanges();
                MessageBox.Show("Работник добавлен!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UCAddEmployee_Load(this, null);
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UCAddEmployee_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UCAddEmployee_Enter(object sender, EventArgs e)
        {
            UCAddEmployee_Load(this, null);
        }
    }
}