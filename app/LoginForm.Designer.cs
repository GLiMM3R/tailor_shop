namespace app
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            layout_pn = new Panel();
            setting_btn = new Button();
            label1 = new Label();
            exit_btn = new Button();
            form_layout_pn = new TableLayoutPanel();
            password_pn = new Panel();
            password_txt = new TextBox();
            login_btn = new Button();
            username_pn = new Panel();
            username_txt = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            layout_pn.SuspendLayout();
            form_layout_pn.SuspendLayout();
            password_pn.SuspendLayout();
            username_pn.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // layout_pn
            // 
            layout_pn.BackColor = Color.Bisque;
            layout_pn.Controls.Add(setting_btn);
            layout_pn.Controls.Add(label1);
            layout_pn.Controls.Add(exit_btn);
            layout_pn.Controls.Add(form_layout_pn);
            layout_pn.Dock = DockStyle.Fill;
            layout_pn.Location = new Point(400, 0);
            layout_pn.Margin = new Padding(0);
            layout_pn.Name = "layout_pn";
            layout_pn.Size = new Size(400, 600);
            layout_pn.TabIndex = 0;
            // 
            // setting_btn
            // 
            setting_btn.BackColor = Color.Gray;
            setting_btn.Cursor = Cursors.Hand;
            setting_btn.FlatAppearance.BorderSize = 0;
            setting_btn.FlatStyle = FlatStyle.Flat;
            setting_btn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            setting_btn.ForeColor = SystemColors.ControlText;
            setting_btn.Image = (Image)resources.GetObject("setting_btn.Image");
            setting_btn.Location = new Point(271, 12);
            setting_btn.Name = "setting_btn";
            setting_btn.Size = new Size(50, 49);
            setting_btn.TabIndex = 3;
            setting_btn.UseVisualStyleBackColor = false;
            setting_btn.Click += setting_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(67, 134);
            label1.Name = "label1";
            label1.Size = new Size(266, 46);
            label1.TabIndex = 2;
            label1.Text = "Tailor's Shop";
            // 
            // exit_btn
            // 
            exit_btn.BackColor = Color.Red;
            exit_btn.Cursor = Cursors.Hand;
            exit_btn.FlatAppearance.BorderSize = 0;
            exit_btn.FlatStyle = FlatStyle.Flat;
            exit_btn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exit_btn.Image = (Image)resources.GetObject("exit_btn.Image");
            exit_btn.Location = new Point(338, 12);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(50, 49);
            exit_btn.TabIndex = 1;
            exit_btn.UseVisualStyleBackColor = false;
            exit_btn.Click += exit_btn_Click;
            // 
            // form_layout_pn
            // 
            form_layout_pn.ColumnCount = 1;
            form_layout_pn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            form_layout_pn.Controls.Add(password_pn, 0, 1);
            form_layout_pn.Controls.Add(login_btn, 0, 2);
            form_layout_pn.Controls.Add(username_pn, 0, 0);
            form_layout_pn.Location = new Point(23, 206);
            form_layout_pn.Name = "form_layout_pn";
            form_layout_pn.RowCount = 3;
            form_layout_pn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            form_layout_pn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            form_layout_pn.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            form_layout_pn.Size = new Size(358, 248);
            form_layout_pn.TabIndex = 0;
            // 
            // password_pn
            // 
            password_pn.BackColor = Color.White;
            password_pn.Controls.Add(password_txt);
            password_pn.Dock = DockStyle.Fill;
            password_pn.Location = new Point(3, 82);
            password_pn.Name = "password_pn";
            password_pn.Size = new Size(352, 73);
            password_pn.TabIndex = 1;
            // 
            // password_txt
            // 
            password_txt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            password_txt.BorderStyle = BorderStyle.None;
            password_txt.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            password_txt.Location = new Point(11, 19);
            password_txt.MaxLength = 30;
            password_txt.Name = "password_txt";
            password_txt.PlaceholderText = "Password";
            password_txt.Size = new Size(330, 35);
            password_txt.TabIndex = 1;
            password_txt.TextAlign = HorizontalAlignment.Center;
            password_txt.UseSystemPasswordChar = true;
            // 
            // login_btn
            // 
            login_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            login_btn.BackColor = Color.FromArgb(33, 52, 72);
            login_btn.Cursor = Cursors.Hand;
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.Font = new Font("Noto Sans Lao", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_btn.ForeColor = Color.White;
            login_btn.Location = new Point(3, 172);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(352, 73);
            login_btn.TabIndex = 2;
            login_btn.Text = "ເຂົ້າສູ້ລະບົບ";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // username_pn
            // 
            username_pn.BackColor = Color.White;
            username_pn.Controls.Add(username_txt);
            username_pn.Dock = DockStyle.Fill;
            username_pn.Location = new Point(3, 3);
            username_pn.Name = "username_pn";
            username_pn.Padding = new Padding(4);
            username_pn.Size = new Size(352, 73);
            username_pn.TabIndex = 0;
            // 
            // username_txt
            // 
            username_txt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            username_txt.BorderStyle = BorderStyle.None;
            username_txt.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            username_txt.Location = new Point(11, 19);
            username_txt.MaxLength = 30;
            username_txt.Name = "username_txt";
            username_txt.PlaceholderText = "Username";
            username_txt.Size = new Size(330, 35);
            username_txt.TabIndex = 0;
            username_txt.TextAlign = HorizontalAlignment.Center;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(layout_pn, 1, 0);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(800, 600);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.bg;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 600);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginForm_Load;
            layout_pn.ResumeLayout(false);
            layout_pn.PerformLayout();
            form_layout_pn.ResumeLayout(false);
            password_pn.ResumeLayout(false);
            password_pn.PerformLayout();
            username_pn.ResumeLayout(false);
            username_pn.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel layout_pn;
        private TableLayoutPanel form_layout_pn;
        private Panel password_pn;
        private Panel username_pn;
        private TextBox username_txt;
        private TextBox password_txt;
        private Button login_btn;
        private Button exit_btn;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private Button setting_btn;
    }
}