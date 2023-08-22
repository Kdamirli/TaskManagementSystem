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
    public partial class UCAddAssignment : UserControl
    {
        TaskManagementSystemEntities1 db;
        Assignment asg = new Assignment();
        Func func = new Func();
        public UCAddAssignment()
        {
            InitializeComponent();
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

        private void UCAddAssignment_Load(object sender, EventArgs e)
        {
            db = new TaskManagementSystemEntities1();
            this.viewAssignmentTableAdapter.Fill(this.ucAssignment.viewAssignment);
            cbEmp.Items.Clear();
            cbProject.Items.Clear();
            setComboBox("select name from employee", cbEmp);
            setComboBox("select projectName from project", cbProject);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            int im = 0;
            if(cbEmp.Text != "" &&  cbDue.Text != "" && cbReason.Text != "" && cbProject.Text != "")
            {
                asg.employee_id = cbEmp.SelectedIndex + 1;
                asg.startDate = Convert.ToDateTime(dtStart.Text.Trim());
                asg.dueDate = Convert.ToInt32(cbDue.Text);
                if (checkBoxStatus.Checked)
                {
                    im = 1;
                }
                asg.implementationMark = Convert.ToBoolean(im);
                asg.controlDate = Convert.ToDateTime(dtControl.Text.Trim());
                asg.reasonsDefault = cbReason.Text;
                asg.project_id = cbProject.SelectedIndex + 1;
                db.Assignment.Add(asg);
                db.SaveChanges();
                MessageBox.Show("Задание назначено", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UCAddAssignment_Load(this, null);
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
