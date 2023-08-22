using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TaskManagementSystem;

namespace TaskManagementSystem.User_Controls
{
    public partial class UCAddProject : UserControl
    {
        TaskManagementSystemEntities1 db;
        project project = new project();

        public UCAddProject()
        {
            InitializeComponent();
        }

        private void UCAddProject_Load(object sender, EventArgs e)
        {
            this.viewProjectTableAdapter.Fill(this.viewProjectDS.viewProject);
            db = new TaskManagementSystemEntities1();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if(tbName.Text != "")
            {
                project.projectName = tbName.Text.Trim();
                db.project.Add(project);
                db.SaveChanges();
                MessageBox.Show("Проект добавлен!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UCAddProject_Load(this, null);
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}