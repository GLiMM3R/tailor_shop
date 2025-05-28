namespace app
{
    partial class ConnectionSettingsForm
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
            panel1 = new Panel();
            close_btn = new Button();
            test_btn = new Button();
            save_btn = new Button();
            panel3 = new Panel();
            trust_server_certificate_cb = new CheckBox();
            intergrated_security_cb = new CheckBox();
            form_layout = new TableLayoutPanel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            database_txt = new TextBox();
            address_pn = new Panel();
            password_txt = new TextBox();
            phone_pn = new Panel();
            username_txt = new TextBox();
            name_pn = new Panel();
            server_txt = new TextBox();
            name_lb = new Label();
            header_lb = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            form_layout.SuspendLayout();
            panel2.SuspendLayout();
            address_pn.SuspendLayout();
            phone_pn.SuspendLayout();
            name_pn.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(close_btn);
            panel1.Controls.Add(test_btn);
            panel1.Controls.Add(save_btn);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(form_layout);
            panel1.Controls.Add(header_lb);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(646, 581);
            panel1.TabIndex = 0;
            // 
            // close_btn
            // 
            close_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            close_btn.BackColor = Color.White;
            close_btn.Cursor = Cursors.Hand;
            close_btn.FlatStyle = FlatStyle.Flat;
            close_btn.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold);
            close_btn.ForeColor = Color.Black;
            close_btn.Location = new Point(320, 498);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(129, 55);
            close_btn.TabIndex = 17;
            close_btn.Text = "Close";
            close_btn.UseVisualStyleBackColor = false;
            close_btn.Click += button1_Click;
            // 
            // test_btn
            // 
            test_btn.BackColor = Color.White;
            test_btn.Cursor = Cursors.Hand;
            test_btn.FlatStyle = FlatStyle.Flat;
            test_btn.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold);
            test_btn.Location = new Point(60, 498);
            test_btn.Name = "test_btn";
            test_btn.Size = new Size(187, 55);
            test_btn.TabIndex = 15;
            test_btn.Text = "Test Connection";
            test_btn.UseVisualStyleBackColor = false;
            test_btn.Click += test_btn_Click;
            // 
            // save_btn
            // 
            save_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            save_btn.BackColor = Color.FromArgb(33, 52, 72);
            save_btn.Cursor = Cursors.Hand;
            save_btn.FlatAppearance.BorderColor = Color.Black;
            save_btn.FlatStyle = FlatStyle.Flat;
            save_btn.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold);
            save_btn.ForeColor = Color.White;
            save_btn.Location = new Point(455, 498);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(129, 55);
            save_btn.TabIndex = 16;
            save_btn.Text = "Save";
            save_btn.UseVisualStyleBackColor = false;
            save_btn.Click += save_btn_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(trust_server_certificate_cb);
            panel3.Controls.Add(intergrated_security_cb);
            panel3.Location = new Point(60, 415);
            panel3.Margin = new Padding(0, 0, 0, 16);
            panel3.Name = "panel3";
            panel3.Size = new Size(524, 64);
            panel3.TabIndex = 14;
            // 
            // trust_server_certificate_cb
            // 
            trust_server_certificate_cb.AutoSize = true;
            trust_server_certificate_cb.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            trust_server_certificate_cb.Location = new Point(270, 16);
            trust_server_certificate_cb.Name = "trust_server_certificate_cb";
            trust_server_certificate_cb.Size = new Size(216, 32);
            trust_server_certificate_cb.TabIndex = 1;
            trust_server_certificate_cb.Text = "Trust Server Certificate";
            trust_server_certificate_cb.UseVisualStyleBackColor = true;
            // 
            // intergrated_security_cb
            // 
            intergrated_security_cb.AutoSize = true;
            intergrated_security_cb.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            intergrated_security_cb.Location = new Point(38, 16);
            intergrated_security_cb.Name = "intergrated_security_cb";
            intergrated_security_cb.Size = new Size(188, 32);
            intergrated_security_cb.TabIndex = 0;
            intergrated_security_cb.Text = "Integrated Security";
            intergrated_security_cb.UseVisualStyleBackColor = true;
            intergrated_security_cb.CheckedChanged += intergrated_security_cb_CheckedChanged;
            // 
            // form_layout
            // 
            form_layout.BackColor = Color.White;
            form_layout.ColumnCount = 2;
            form_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            form_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            form_layout.Controls.Add(label3, 0, 3);
            form_layout.Controls.Add(label2, 0, 2);
            form_layout.Controls.Add(label1, 0, 1);
            form_layout.Controls.Add(panel2, 1, 1);
            form_layout.Controls.Add(address_pn, 1, 3);
            form_layout.Controls.Add(phone_pn, 1, 2);
            form_layout.Controls.Add(name_pn, 1, 0);
            form_layout.Controls.Add(name_lb, 0, 0);
            form_layout.Location = new Point(60, 105);
            form_layout.Name = "form_layout";
            form_layout.RowCount = 4;
            form_layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            form_layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            form_layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            form_layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            form_layout.Size = new Size(524, 307);
            form_layout.TabIndex = 3;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold);
            label3.Location = new Point(3, 240);
            label3.Margin = new Padding(3, 0, 3, 16);
            label3.Name = "label3";
            label3.Size = new Size(134, 64);
            label3.TabIndex = 11;
            label3.Text = "Password";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold);
            label2.Location = new Point(3, 160);
            label2.Margin = new Padding(3, 0, 3, 16);
            label2.Name = "label2";
            label2.Size = new Size(134, 64);
            label2.TabIndex = 10;
            label2.Text = "Username";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold);
            label1.Location = new Point(3, 80);
            label1.Margin = new Padding(3, 0, 3, 16);
            label1.Name = "label1";
            label1.Size = new Size(134, 64);
            label1.TabIndex = 9;
            label1.Text = "Database";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(database_txt);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(140, 80);
            panel2.Margin = new Padding(0, 0, 0, 16);
            panel2.Name = "panel2";
            panel2.Size = new Size(384, 64);
            panel2.TabIndex = 8;
            // 
            // database_txt
            // 
            database_txt.BorderStyle = BorderStyle.None;
            database_txt.Cursor = Cursors.IBeam;
            database_txt.Font = new Font("Noto Sans Lao", 11.999999F);
            database_txt.Location = new Point(8, 15);
            database_txt.MaxLength = 100;
            database_txt.Name = "database_txt";
            database_txt.Size = new Size(370, 33);
            database_txt.TabIndex = 0;
            // 
            // address_pn
            // 
            address_pn.BackColor = Color.White;
            address_pn.BorderStyle = BorderStyle.FixedSingle;
            address_pn.Controls.Add(password_txt);
            address_pn.Dock = DockStyle.Fill;
            address_pn.Location = new Point(140, 240);
            address_pn.Margin = new Padding(0, 0, 0, 16);
            address_pn.Name = "address_pn";
            address_pn.Size = new Size(384, 64);
            address_pn.TabIndex = 7;
            // 
            // password_txt
            // 
            password_txt.BorderStyle = BorderStyle.None;
            password_txt.Cursor = Cursors.IBeam;
            password_txt.Font = new Font("Noto Sans Lao", 11.999999F);
            password_txt.Location = new Point(6, 15);
            password_txt.MaxLength = 200;
            password_txt.Name = "password_txt";
            password_txt.Size = new Size(370, 33);
            password_txt.TabIndex = 1;
            password_txt.UseSystemPasswordChar = true;
            // 
            // phone_pn
            // 
            phone_pn.BackColor = Color.White;
            phone_pn.BorderStyle = BorderStyle.FixedSingle;
            phone_pn.Controls.Add(username_txt);
            phone_pn.Dock = DockStyle.Fill;
            phone_pn.Location = new Point(140, 160);
            phone_pn.Margin = new Padding(0, 0, 0, 18);
            phone_pn.Name = "phone_pn";
            phone_pn.Size = new Size(384, 62);
            phone_pn.TabIndex = 5;
            // 
            // username_txt
            // 
            username_txt.BorderStyle = BorderStyle.None;
            username_txt.Cursor = Cursors.IBeam;
            username_txt.Font = new Font("Noto Sans Lao", 11.999999F);
            username_txt.Location = new Point(6, 14);
            username_txt.MaxLength = 12;
            username_txt.Name = "username_txt";
            username_txt.Size = new Size(370, 33);
            username_txt.TabIndex = 1;
            // 
            // name_pn
            // 
            name_pn.BackColor = Color.White;
            name_pn.BorderStyle = BorderStyle.FixedSingle;
            name_pn.Controls.Add(server_txt);
            name_pn.Dock = DockStyle.Fill;
            name_pn.Location = new Point(140, 0);
            name_pn.Margin = new Padding(0, 0, 0, 16);
            name_pn.Name = "name_pn";
            name_pn.Size = new Size(384, 64);
            name_pn.TabIndex = 0;
            // 
            // server_txt
            // 
            server_txt.BorderStyle = BorderStyle.None;
            server_txt.Cursor = Cursors.IBeam;
            server_txt.Font = new Font("Noto Sans Lao", 11.999999F);
            server_txt.Location = new Point(8, 14);
            server_txt.MaxLength = 100;
            server_txt.Name = "server_txt";
            server_txt.Size = new Size(370, 33);
            server_txt.TabIndex = 0;
            // 
            // name_lb
            // 
            name_lb.Dock = DockStyle.Top;
            name_lb.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold);
            name_lb.Location = new Point(3, 0);
            name_lb.Margin = new Padding(3, 0, 3, 16);
            name_lb.Name = "name_lb";
            name_lb.Size = new Size(134, 64);
            name_lb.TabIndex = 1;
            name_lb.Text = "Server";
            name_lb.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // header_lb
            // 
            header_lb.BackColor = Color.FromArgb(33, 52, 72);
            header_lb.Dock = DockStyle.Top;
            header_lb.Font = new Font("Noto Sans Lao", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            header_lb.ForeColor = Color.White;
            header_lb.Location = new Point(0, 0);
            header_lb.Name = "header_lb";
            header_lb.Size = new Size(646, 83);
            header_lb.TabIndex = 5;
            header_lb.Text = "Connection Settings";
            header_lb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ConnectionSettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 581);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ConnectionSettingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConnectionSettingsForm";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            form_layout.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            address_pn.ResumeLayout(false);
            address_pn.PerformLayout();
            phone_pn.ResumeLayout(false);
            phone_pn.PerformLayout();
            name_pn.ResumeLayout(false);
            name_pn.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel form_layout;
        private Panel address_pn;
        private TextBox password_txt;
        private Panel phone_pn;
        private TextBox username_txt;
        private Panel name_pn;
        private TextBox server_txt;
        private Label name_lb;
        private Label header_lb;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private TextBox database_txt;
        private Panel panel3;
        private CheckBox trust_server_certificate_cb;
        private CheckBox intergrated_security_cb;
        private Button test_btn;
        private Button save_btn;
        private Button close_btn;
    }
}