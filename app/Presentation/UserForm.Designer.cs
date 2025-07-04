﻿namespace app.Presentation
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            header_lb = new Label();
            cancel_btn = new Button();
            action_layout = new TableLayoutPanel();
            add_btn = new Button();
            name_lb = new Label();
            username_txt = new TextBox();
            phone_lb = new Label();
            gender_lb = new Label();
            form_layout = new TableLayoutPanel();
            panel1 = new Panel();
            admin_rb = new RadioButton();
            user_rb = new RadioButton();
            phone_pn = new Panel();
            password_txt = new TextBox();
            name_pn = new Panel();
            root_layout = new Panel();
            action_layout.SuspendLayout();
            form_layout.SuspendLayout();
            panel1.SuspendLayout();
            phone_pn.SuspendLayout();
            name_pn.SuspendLayout();
            root_layout.SuspendLayout();
            SuspendLayout();
            // 
            // header_lb
            // 
            header_lb.BackColor = Color.FromArgb(33, 52, 72);
            header_lb.Dock = DockStyle.Top;
            header_lb.Font = new Font("Noto Sans Lao", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            header_lb.ForeColor = Color.White;
            header_lb.Location = new Point(0, 0);
            header_lb.Name = "header_lb";
            header_lb.Size = new Size(571, 60);
            header_lb.TabIndex = 2;
            header_lb.Text = "ຟອມຜູ້ໃຊ້ລະບົບ";
            header_lb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cancel_btn
            // 
            cancel_btn.BackColor = Color.White;
            cancel_btn.Cursor = Cursors.Hand;
            cancel_btn.FlatStyle = FlatStyle.Flat;
            cancel_btn.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold);
            cancel_btn.Location = new Point(3, 3);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(141, 55);
            cancel_btn.TabIndex = 0;
            cancel_btn.Text = "ຍົກເລີກ";
            cancel_btn.UseVisualStyleBackColor = false;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // action_layout
            // 
            action_layout.BackColor = Color.White;
            action_layout.ColumnCount = 2;
            action_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            action_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            action_layout.Controls.Add(cancel_btn, 0, 0);
            action_layout.Controls.Add(add_btn, 1, 0);
            action_layout.Location = new Point(31, 319);
            action_layout.Name = "action_layout";
            action_layout.RowCount = 1;
            action_layout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            action_layout.Size = new Size(506, 61);
            action_layout.TabIndex = 5;
            // 
            // add_btn
            // 
            add_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            add_btn.BackColor = Color.FromArgb(33, 52, 72);
            add_btn.Cursor = Cursors.Hand;
            add_btn.FlatStyle = FlatStyle.Flat;
            add_btn.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold);
            add_btn.ForeColor = Color.White;
            add_btn.Location = new Point(367, 3);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(136, 55);
            add_btn.TabIndex = 1;
            add_btn.Text = "ເພີ່ມ";
            add_btn.UseVisualStyleBackColor = false;
            add_btn.Click += add_btn_Click;
            // 
            // name_lb
            // 
            name_lb.Font = new Font("Noto Sans Lao", 10.1999989F);
            name_lb.Location = new Point(3, 0);
            name_lb.Margin = new Padding(3, 0, 3, 16);
            name_lb.Name = "name_lb";
            name_lb.Size = new Size(114, 52);
            name_lb.TabIndex = 1;
            name_lb.Text = "ຊື່ຜູ້ໃຊ້";
            name_lb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // username_txt
            // 
            username_txt.BorderStyle = BorderStyle.None;
            username_txt.Cursor = Cursors.IBeam;
            username_txt.Font = new Font("Noto Sans Lao", 10.1999989F);
            username_txt.Location = new Point(16, 12);
            username_txt.MaxLength = 100;
            username_txt.Name = "username_txt";
            username_txt.Size = new Size(355, 28);
            username_txt.TabIndex = 0;
            // 
            // phone_lb
            // 
            phone_lb.Font = new Font("Noto Sans Lao", 10.1999989F);
            phone_lb.Location = new Point(3, 68);
            phone_lb.Margin = new Padding(3, 0, 3, 16);
            phone_lb.Name = "phone_lb";
            phone_lb.Size = new Size(114, 50);
            phone_lb.TabIndex = 4;
            phone_lb.Text = "ລະຫັດຜ່ານ";
            phone_lb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gender_lb
            // 
            gender_lb.Font = new Font("Noto Sans Lao", 10.1999989F);
            gender_lb.Location = new Point(3, 136);
            gender_lb.Margin = new Padding(3, 0, 3, 16);
            gender_lb.Name = "gender_lb";
            gender_lb.Size = new Size(114, 52);
            gender_lb.TabIndex = 2;
            gender_lb.Text = "ພາລະບົດບາດ";
            gender_lb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // form_layout
            // 
            form_layout.BackColor = Color.White;
            form_layout.ColumnCount = 2;
            form_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            form_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            form_layout.Controls.Add(panel1, 1, 2);
            form_layout.Controls.Add(phone_pn, 1, 1);
            form_layout.Controls.Add(name_pn, 1, 0);
            form_layout.Controls.Add(name_lb, 0, 0);
            form_layout.Controls.Add(phone_lb, 0, 1);
            form_layout.Controls.Add(gender_lb, 0, 2);
            form_layout.Location = new Point(32, 100);
            form_layout.Name = "form_layout";
            form_layout.RowCount = 3;
            form_layout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            form_layout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            form_layout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            form_layout.Size = new Size(506, 206);
            form_layout.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(admin_rb);
            panel1.Controls.Add(user_rb);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(120, 136);
            panel1.Margin = new Padding(0, 0, 0, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(386, 52);
            panel1.TabIndex = 7;
            // 
            // admin_rb
            // 
            admin_rb.AutoSize = true;
            admin_rb.Font = new Font("Noto Sans Lao", 10.1999989F);
            admin_rb.Location = new Point(211, 10);
            admin_rb.Name = "admin_rb";
            admin_rb.Size = new Size(113, 32);
            admin_rb.TabIndex = 1;
            admin_rb.TabStop = true;
            admin_rb.Text = "ຜູ້ດູແລລະບົບ";
            admin_rb.UseVisualStyleBackColor = true;
            // 
            // user_rb
            // 
            user_rb.AutoSize = true;
            user_rb.Font = new Font("Noto Sans Lao", 10.1999989F);
            user_rb.Location = new Point(90, 10);
            user_rb.Name = "user_rb";
            user_rb.Size = new Size(60, 32);
            user_rb.TabIndex = 0;
            user_rb.TabStop = true;
            user_rb.Text = "ຜູ້ໃຊ້";
            user_rb.UseVisualStyleBackColor = true;
            // 
            // phone_pn
            // 
            phone_pn.BackColor = Color.White;
            phone_pn.BorderStyle = BorderStyle.FixedSingle;
            phone_pn.Controls.Add(password_txt);
            phone_pn.Dock = DockStyle.Fill;
            phone_pn.Location = new Point(120, 68);
            phone_pn.Margin = new Padding(0, 0, 0, 18);
            phone_pn.Name = "phone_pn";
            phone_pn.Size = new Size(386, 50);
            phone_pn.TabIndex = 6;
            // 
            // password_txt
            // 
            password_txt.BorderStyle = BorderStyle.None;
            password_txt.Cursor = Cursors.IBeam;
            password_txt.Font = new Font("Noto Sans Lao", 10.1999989F);
            password_txt.Location = new Point(15, 11);
            password_txt.MaxLength = 12;
            password_txt.Name = "password_txt";
            password_txt.Size = new Size(356, 28);
            password_txt.TabIndex = 1;
            password_txt.UseSystemPasswordChar = true;
            // 
            // name_pn
            // 
            name_pn.BackColor = Color.White;
            name_pn.BorderStyle = BorderStyle.FixedSingle;
            name_pn.Controls.Add(username_txt);
            name_pn.Dock = DockStyle.Fill;
            name_pn.Location = new Point(120, 0);
            name_pn.Margin = new Padding(0, 0, 0, 16);
            name_pn.Name = "name_pn";
            name_pn.Size = new Size(386, 52);
            name_pn.TabIndex = 0;
            // 
            // root_layout
            // 
            root_layout.BackColor = Color.White;
            root_layout.BorderStyle = BorderStyle.FixedSingle;
            root_layout.Controls.Add(form_layout);
            root_layout.Controls.Add(action_layout);
            root_layout.Controls.Add(header_lb);
            root_layout.Dock = DockStyle.Fill;
            root_layout.Location = new Point(0, 0);
            root_layout.Name = "root_layout";
            root_layout.Size = new Size(573, 414);
            root_layout.TabIndex = 6;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 414);
            Controls.Add(root_layout);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserForm";
            Load += UserForm_Load;
            action_layout.ResumeLayout(false);
            form_layout.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            phone_pn.ResumeLayout(false);
            phone_pn.PerformLayout();
            name_pn.ResumeLayout(false);
            name_pn.PerformLayout();
            root_layout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label header_lb;
        private Button cancel_btn;
        private TableLayoutPanel action_layout;
        private Button add_btn;
        private Label name_lb;
        private TextBox username_txt;
        private Label phone_lb;
        private Label gender_lb;
        private TableLayoutPanel form_layout;
        private Panel panel1;
        private RadioButton admin_rb;
        private RadioButton user_rb;
        private Panel phone_pn;
        private TextBox password_txt;
        private Panel name_pn;
        private Panel root_layout;
    }
}