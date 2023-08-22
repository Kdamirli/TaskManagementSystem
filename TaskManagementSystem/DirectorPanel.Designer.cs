namespace TaskManagementSystem
{
    partial class DirectorPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectorPanel));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_AddTask = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_AddLink = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_AddProj = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_AddDep = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_AddOrg = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_AddEmp = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ucAssignment1 = new TaskManagementSystem.User_Controls.UCAssignment();
            this.ucDepartment1 = new TaskManagementSystem.User_Controls.UCDepartment();
            this.ucEmployee1 = new TaskManagementSystem.User_Controls.UCEmployee();
            this.ucOrganization1 = new TaskManagementSystem.User_Controls.UCOrganization();
            this.ucProject1 = new TaskManagementSystem.User_Controls.UCProject();
            this.ucSearch1 = new TaskManagementSystem.User_Controls.UCSearch();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.guna2Panel1.Controls.Add(this.btn_AddTask);
            this.guna2Panel1.Controls.Add(this.btn_AddLink);
            this.guna2Panel1.Controls.Add(this.btn_AddProj);
            this.guna2Panel1.Controls.Add(this.btn_AddDep);
            this.guna2Panel1.Controls.Add(this.btn_AddOrg);
            this.guna2Panel1.Controls.Add(this.guna2ImageButton1);
            this.guna2Panel1.Controls.Add(this.btn_AddEmp);
            this.guna2Panel1.Location = new System.Drawing.Point(2, 27);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(200, 495);
            this.guna2Panel1.TabIndex = 2;
            // 
            // btn_AddTask
            // 
            this.btn_AddTask.Animated = true;
            this.btn_AddTask.BackColor = System.Drawing.Color.Transparent;
            this.btn_AddTask.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_AddTask.CheckedState.Parent = this.btn_AddTask;
            this.btn_AddTask.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_AddTask.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_AddTask.CustomImages.Parent = this.btn_AddTask;
            this.btn_AddTask.FillColor = System.Drawing.Color.Empty;
            this.btn_AddTask.FillColor2 = System.Drawing.Color.Empty;
            this.btn_AddTask.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btn_AddTask.ForeColor = System.Drawing.Color.White;
            this.btn_AddTask.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(62)))), ((int)(((byte)(103)))));
            this.btn_AddTask.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btn_AddTask.HoverState.Parent = this.btn_AddTask;
            this.btn_AddTask.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddTask.Image")));
            this.btn_AddTask.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_AddTask.Location = new System.Drawing.Point(3, 430);
            this.btn_AddTask.Name = "btn_AddTask";
            this.btn_AddTask.ShadowDecoration.Parent = this.btn_AddTask;
            this.btn_AddTask.Size = new System.Drawing.Size(197, 45);
            this.btn_AddTask.TabIndex = 7;
            this.btn_AddTask.Text = "Задания";
            this.btn_AddTask.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_AddTask.TextOffset = new System.Drawing.Point(-5, 0);
            this.btn_AddTask.UseTransparentBackground = true;
            this.btn_AddTask.Click += new System.EventHandler(this.btn_AddTask_Click);
            // 
            // btn_AddLink
            // 
            this.btn_AddLink.Animated = true;
            this.btn_AddLink.BackColor = System.Drawing.Color.Transparent;
            this.btn_AddLink.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_AddLink.CheckedState.Parent = this.btn_AddLink;
            this.btn_AddLink.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_AddLink.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_AddLink.CustomImages.Parent = this.btn_AddLink;
            this.btn_AddLink.FillColor = System.Drawing.Color.Empty;
            this.btn_AddLink.FillColor2 = System.Drawing.Color.Empty;
            this.btn_AddLink.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btn_AddLink.ForeColor = System.Drawing.Color.White;
            this.btn_AddLink.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(62)))), ((int)(((byte)(103)))));
            this.btn_AddLink.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btn_AddLink.HoverState.Parent = this.btn_AddLink;
            this.btn_AddLink.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddLink.Image")));
            this.btn_AddLink.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_AddLink.Location = new System.Drawing.Point(3, 379);
            this.btn_AddLink.Name = "btn_AddLink";
            this.btn_AddLink.ShadowDecoration.Parent = this.btn_AddLink;
            this.btn_AddLink.Size = new System.Drawing.Size(197, 45);
            this.btn_AddLink.TabIndex = 6;
            this.btn_AddLink.Text = "Поиск";
            this.btn_AddLink.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_AddLink.TextOffset = new System.Drawing.Point(-5, 0);
            this.btn_AddLink.UseTransparentBackground = true;
            this.btn_AddLink.Click += new System.EventHandler(this.btn_AddLink_Click);
            // 
            // btn_AddProj
            // 
            this.btn_AddProj.Animated = true;
            this.btn_AddProj.BackColor = System.Drawing.Color.Transparent;
            this.btn_AddProj.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_AddProj.CheckedState.Parent = this.btn_AddProj;
            this.btn_AddProj.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_AddProj.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_AddProj.CustomImages.Parent = this.btn_AddProj;
            this.btn_AddProj.FillColor = System.Drawing.Color.Empty;
            this.btn_AddProj.FillColor2 = System.Drawing.Color.Empty;
            this.btn_AddProj.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btn_AddProj.ForeColor = System.Drawing.Color.White;
            this.btn_AddProj.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(62)))), ((int)(((byte)(103)))));
            this.btn_AddProj.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btn_AddProj.HoverState.Parent = this.btn_AddProj;
            this.btn_AddProj.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddProj.Image")));
            this.btn_AddProj.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_AddProj.Location = new System.Drawing.Point(3, 328);
            this.btn_AddProj.Name = "btn_AddProj";
            this.btn_AddProj.ShadowDecoration.Parent = this.btn_AddProj;
            this.btn_AddProj.Size = new System.Drawing.Size(197, 45);
            this.btn_AddProj.TabIndex = 5;
            this.btn_AddProj.Text = "Проект";
            this.btn_AddProj.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_AddProj.TextOffset = new System.Drawing.Point(-5, 0);
            this.btn_AddProj.UseTransparentBackground = true;
            this.btn_AddProj.Click += new System.EventHandler(this.btn_AddProj_Click);
            // 
            // btn_AddDep
            // 
            this.btn_AddDep.Animated = true;
            this.btn_AddDep.BackColor = System.Drawing.Color.Transparent;
            this.btn_AddDep.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_AddDep.CheckedState.Parent = this.btn_AddDep;
            this.btn_AddDep.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_AddDep.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_AddDep.CustomImages.Parent = this.btn_AddDep;
            this.btn_AddDep.FillColor = System.Drawing.Color.Empty;
            this.btn_AddDep.FillColor2 = System.Drawing.Color.Empty;
            this.btn_AddDep.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btn_AddDep.ForeColor = System.Drawing.Color.White;
            this.btn_AddDep.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(62)))), ((int)(((byte)(103)))));
            this.btn_AddDep.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btn_AddDep.HoverState.Parent = this.btn_AddDep;
            this.btn_AddDep.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddDep.Image")));
            this.btn_AddDep.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_AddDep.Location = new System.Drawing.Point(3, 277);
            this.btn_AddDep.Name = "btn_AddDep";
            this.btn_AddDep.ShadowDecoration.Parent = this.btn_AddDep;
            this.btn_AddDep.Size = new System.Drawing.Size(197, 45);
            this.btn_AddDep.TabIndex = 4;
            this.btn_AddDep.Text = "Отделения";
            this.btn_AddDep.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_AddDep.TextOffset = new System.Drawing.Point(-5, 0);
            this.btn_AddDep.UseTransparentBackground = true;
            this.btn_AddDep.Click += new System.EventHandler(this.btn_AddDep_Click);
            // 
            // btn_AddOrg
            // 
            this.btn_AddOrg.Animated = true;
            this.btn_AddOrg.BackColor = System.Drawing.Color.Transparent;
            this.btn_AddOrg.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_AddOrg.CheckedState.Parent = this.btn_AddOrg;
            this.btn_AddOrg.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_AddOrg.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_AddOrg.CustomImages.Parent = this.btn_AddOrg;
            this.btn_AddOrg.FillColor = System.Drawing.Color.Empty;
            this.btn_AddOrg.FillColor2 = System.Drawing.Color.Empty;
            this.btn_AddOrg.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btn_AddOrg.ForeColor = System.Drawing.Color.White;
            this.btn_AddOrg.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(62)))), ((int)(((byte)(103)))));
            this.btn_AddOrg.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btn_AddOrg.HoverState.Parent = this.btn_AddOrg;
            this.btn_AddOrg.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddOrg.Image")));
            this.btn_AddOrg.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_AddOrg.Location = new System.Drawing.Point(3, 226);
            this.btn_AddOrg.Name = "btn_AddOrg";
            this.btn_AddOrg.ShadowDecoration.Parent = this.btn_AddOrg;
            this.btn_AddOrg.Size = new System.Drawing.Size(197, 45);
            this.btn_AddOrg.TabIndex = 3;
            this.btn_AddOrg.Text = "Организация";
            this.btn_AddOrg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_AddOrg.TextOffset = new System.Drawing.Point(-5, 0);
            this.btn_AddOrg.UseTransparentBackground = true;
            this.btn_AddOrg.Click += new System.EventHandler(this.btn_AddOrg_Click);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Enabled = false;
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(256, 256);
            this.guna2ImageButton1.Location = new System.Drawing.Point(-2, 3);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(200, 166);
            this.guna2ImageButton1.TabIndex = 2;
            // 
            // btn_AddEmp
            // 
            this.btn_AddEmp.Animated = true;
            this.btn_AddEmp.BackColor = System.Drawing.Color.Transparent;
            this.btn_AddEmp.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_AddEmp.CheckedState.Parent = this.btn_AddEmp;
            this.btn_AddEmp.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_AddEmp.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_AddEmp.CustomImages.Parent = this.btn_AddEmp;
            this.btn_AddEmp.FillColor = System.Drawing.Color.Empty;
            this.btn_AddEmp.FillColor2 = System.Drawing.Color.Empty;
            this.btn_AddEmp.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btn_AddEmp.ForeColor = System.Drawing.Color.White;
            this.btn_AddEmp.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(62)))), ((int)(((byte)(103)))));
            this.btn_AddEmp.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btn_AddEmp.HoverState.Parent = this.btn_AddEmp;
            this.btn_AddEmp.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddEmp.Image")));
            this.btn_AddEmp.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_AddEmp.Location = new System.Drawing.Point(3, 175);
            this.btn_AddEmp.Name = "btn_AddEmp";
            this.btn_AddEmp.ShadowDecoration.Parent = this.btn_AddEmp;
            this.btn_AddEmp.Size = new System.Drawing.Size(197, 45);
            this.btn_AddEmp.TabIndex = 1;
            this.btn_AddEmp.Text = "Работники";
            this.btn_AddEmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_AddEmp.TextOffset = new System.Drawing.Point(-5, 0);
            this.btn_AddEmp.UseTransparentBackground = true;
            this.btn_AddEmp.Click += new System.EventHandler(this.btn_AddEmp_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Controls.Add(this.guna2ControlBox3);
            this.guna2Panel2.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel2.Controls.Add(this.guna2ControlBox2);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(990, 30);
            this.guna2Panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(461, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Task Management System";
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.HoverState.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(197)))), ((int)(((byte)(210)))));
            this.guna2ControlBox3.Location = new System.Drawing.Point(924, -2);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.ShadowDecoration.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.Size = new System.Drawing.Size(33, 29);
            this.guna2ControlBox3.TabIndex = 8;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(83)))), ((int)(((byte)(102)))));
            this.guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(197)))), ((int)(((byte)(210)))));
            this.guna2ControlBox1.Location = new System.Drawing.Point(957, -2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(33, 29);
            this.guna2ControlBox1.TabIndex = 6;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(197)))), ((int)(((byte)(210)))));
            this.guna2ControlBox2.Location = new System.Drawing.Point(891, -2);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(33, 29);
            this.guna2ControlBox2.TabIndex = 7;
            // 
            // ucAssignment1
            // 
            this.ucAssignment1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.ucAssignment1.Location = new System.Drawing.Point(201, 29);
            this.ucAssignment1.Name = "ucAssignment1";
            this.ucAssignment1.Size = new System.Drawing.Size(786, 492);
            this.ucAssignment1.TabIndex = 4;
            // 
            // ucDepartment1
            // 
            this.ucDepartment1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.ucDepartment1.Location = new System.Drawing.Point(201, 29);
            this.ucDepartment1.Name = "ucDepartment1";
            this.ucDepartment1.Size = new System.Drawing.Size(786, 492);
            this.ucDepartment1.TabIndex = 5;
            // 
            // ucEmployee1
            // 
            this.ucEmployee1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.ucEmployee1.Location = new System.Drawing.Point(201, 29);
            this.ucEmployee1.Name = "ucEmployee1";
            this.ucEmployee1.Size = new System.Drawing.Size(786, 492);
            this.ucEmployee1.TabIndex = 6;
            // 
            // ucOrganization1
            // 
            this.ucOrganization1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.ucOrganization1.Location = new System.Drawing.Point(201, 30);
            this.ucOrganization1.Name = "ucOrganization1";
            this.ucOrganization1.Size = new System.Drawing.Size(786, 492);
            this.ucOrganization1.TabIndex = 7;
            // 
            // ucProject1
            // 
            this.ucProject1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.ucProject1.Location = new System.Drawing.Point(201, 29);
            this.ucProject1.Name = "ucProject1";
            this.ucProject1.Size = new System.Drawing.Size(786, 492);
            this.ucProject1.TabIndex = 8;
            // 
            // ucSearch1
            // 
            this.ucSearch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.ucSearch1.Location = new System.Drawing.Point(201, 30);
            this.ucSearch1.Name = "ucSearch1";
            this.ucSearch1.Size = new System.Drawing.Size(786, 492);
            this.ucSearch1.TabIndex = 9;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.guna2Panel2;
            // 
            // DirectorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(990, 523);
            this.Controls.Add(this.ucSearch1);
            this.Controls.Add(this.ucProject1);
            this.Controls.Add(this.ucOrganization1);
            this.Controls.Add(this.ucEmployee1);
            this.Controls.Add(this.ucDepartment1);
            this.Controls.Add(this.ucAssignment1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DirectorPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DirectorPanel";
            this.Load += new System.EventHandler(this.DirectorPanel_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_AddTask;
        private Guna.UI2.WinForms.Guna2GradientButton btn_AddLink;
        private Guna.UI2.WinForms.Guna2GradientButton btn_AddProj;
        private Guna.UI2.WinForms.Guna2GradientButton btn_AddDep;
        private Guna.UI2.WinForms.Guna2GradientButton btn_AddOrg;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_AddEmp;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private User_Controls.UCProject ucProject1;
        private User_Controls.UCOrganization ucOrganization1;
        private User_Controls.UCEmployee ucEmployee1;
        private User_Controls.UCDepartment ucDepartment1;
        private User_Controls.UCAssignment ucAssignment1;
        private User_Controls.UCSearch ucSearch1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}