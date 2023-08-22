using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TaskManagementSystem.queryViewsDSTableAdapters;
using TaskManagementSystem.viewEmployeeDSTableAdapters;
using TaskManagementSystems;

namespace TaskManagementSystem.User_Controls
{
    public partial class UCSearch : UserControl
    {
        TaskManagementSystemEntities1 db = new TaskManagementSystemEntities1();
        zap1TableAdapter zap1TableAdapter = new zap1TableAdapter();
        zap2TableAdapter zap2TableAdapter = new zap2TableAdapter();
        zap3TableAdapter zap3TableAdapter = new zap3TableAdapter();
        zap4TableAdapter zap4TableAdapter = new zap4TableAdapter();
        zap5TableAdapter zap5TableAdapter = new zap5TableAdapter();
        zap6TableAdapter zap6TableAdapter = new zap6TableAdapter();
        zap7TableAdapter zap7TableAdapter = new zap7TableAdapter();
        zap8TableAdapter zap8TableAdapter = new zap8TableAdapter();
        zap9TableAdapter zap9TableAdapter = new zap9TableAdapter();
        zap10TableAdapter zap10TableAdapter = new zap10TableAdapter();
        zap11TableAdapter zap11TableAdapter = new zap11TableAdapter();
        zap12TableAdapter zap12TableAdapter = new zap12TableAdapter();
        viewEmployeeDS viewEmployeeDS = new viewEmployeeDS();
        viewEmployeeTableAdapter viewEmployeeTableAdapter = new viewEmployeeTableAdapter();
        employee emp = new employee();
        Func func = new Func();
        SqlConnection con = new SqlConnection("data source = DESKTOP-70L43IK\\MSSQLSERVER03; database=TaskManagementSystem; integrated security = True");

        public UCSearch()
        {
            InitializeComponent();
        }

        private void cbQuery_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbQuery.SelectedIndex)
            {
                case 0:
                    guna2DataGridView1.DataSource = zap1TableAdapter.GetData();
                    MessageBox.Show("Описание запроса:\nСписок всех заданий каждого проекта", cbQuery.Text, MessageBoxButtons.OK);
                    break;
                case 1:
                    guna2DataGridView1.DataSource = zap2TableAdapter.GetData();
                    MessageBox.Show("Описание запроса:\nСписок проектов работа над которыми была начата больше месяца назад", cbQuery.Text, MessageBoxButtons.OK);
                    break;
                case 2:
                    guna2DataGridView1.DataSource = zap3TableAdapter.GetData();
                    MessageBox.Show("Описание запроса:\nСредний оклад сотрудника каждого отдела", cbQuery.Text, MessageBoxButtons.OK);
                    break;
                case 3:
                    guna2DataGridView1.DataSource = zap4TableAdapter.GetData();
                    MessageBox.Show("Описание запроса:\nКоличество проектов, выполняемых каждым отделом", cbQuery.Text, MessageBoxButtons.OK);
                    break;
                case 4:
                    guna2DataGridView1.DataSource = zap5TableAdapter.GetData();
                    MessageBox.Show("Описание запроса:\nСписок сотрудников, проектов, заданий, в выполнении которых они участвуют и дат предпологаемого выполнения ими заданий", cbQuery.Text, MessageBoxButtons.OK);
                    break;
                case 5:
                    guna2DataGridView1.DataSource = zap6TableAdapter.GetData();
                    MessageBox.Show("Описание запроса:\nСписок сотрудников, не выполнивших задания в срок по неуважительной причине", cbQuery.Text, MessageBoxButtons.OK);
                    break;
                case 6:
                    guna2DataGridView1.DataSource = zap7TableAdapter.GetData();
                    MessageBox.Show("Описание запроса:\nСписок сотрудников, не выполнивших задания в срок с указанием проектов и заданий, которые они должны были выполнить и количества дней просрочки выполнения заданий", cbQuery.Text, MessageBoxButtons.OK);
                    break;
                case 7:
                    guna2DataGridView1.DataSource = zap8TableAdapter.GetData();
                    MessageBox.Show("Описание запроса:\nСписок сотрудников, участвующих в выполнении более чем одного проекта", cbQuery.Text, MessageBoxButtons.OK);
                    break;
                case 8:
                    guna2DataGridView1.DataSource = zap9TableAdapter.GetData();
                    MessageBox.Show("Описание запроса:\nСписок проектов, в выполнении которого участвует более трех человек", cbQuery.Text, MessageBoxButtons.OK);
                    break;
                case 9:
                    guna2DataGridView1.DataSource = zap10TableAdapter.GetData();
                    MessageBox.Show("Описание запроса:\nСписок проектов, срок выполнения которых истекает сегодня, и которые включают больше трех невыполненных заданий", cbQuery.Text, MessageBoxButtons.OK);
                    break;
                case 10:
                    guna2DataGridView1.DataSource = zap11TableAdapter.GetData();
                    MessageBox.Show("Описание запроса:\nСписок отделов, сотрудники которых не выполнили задания в срок", cbQuery.Text, MessageBoxButtons.OK);
                    break;
                case 11:
                    guna2DataGridView1.DataSource = zap12TableAdapter.GetData();
                    MessageBox.Show("Описание представления:\nСодержит сведения об исполнителях, отделах, сроках выполнения заданий, включенных в проект", cbQuery.Text, MessageBoxButtons.OK);
                    break;
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("IncreaseSalaryAndPrintWarning", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@param1", SqlDbType.Float).Value = (Convert.ToDouble(tbName.Text)/100)+1;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Зарплата повышена на "+ tbName.Text +"%!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            dataGridStoredProcedure.DataSource = viewEmployeeTableAdapter.GetData();
        }

        private void tbSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GetEmployeePhoneNumber", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@employeeName", SqlDbType.NVarChar).Value = tbFIO.Text;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridSearch.DataSource = dt;
            MessageBox.Show("Работник найден", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select projectName, count(employee_id) 'count' from link join project on project.id = link.project_id group by projectName", con);
            da.Fill(dt);
            chart1.DataSource = dt;
            con.Close();
            chart1.Series["projectName"].XValueMember = "projectName";
            chart1.Series["projectName"].YValueMembers = "count";
            chart1.Titles.Add("Statistics");
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void guna2ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            cbEMP.Items.Clear();
            cbDEP.Items.Clear();
            cbNUM.Items.Clear();
            setComboBox("select name from employee", cbEMP);
            setComboBox("select nameDepartment from department", cbDEP);
            setComboBox("select telephoneNumber from department", cbNUM);
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("search", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@empName", SqlDbType.NVarChar).Value = cbEMP.Text;
            cmd.Parameters.AddWithValue("@dep", SqlDbType.NVarChar).Value = cbDEP.Text;
            cmd.Parameters.AddWithValue("@phoneNum", SqlDbType.NVarChar).Value = cbNUM.Text;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            guna2DataGridView2.DataSource = dt;
            con.Close();
        }
    }
}
