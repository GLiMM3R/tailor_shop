namespace app
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            root_layout = new TableLayoutPanel();
            sidebar_pn = new Panel();
            sidebar_buttons_layout = new FlowLayoutPanel();
            home_btn = new Button();
            order_btn = new Button();
            customer_btn = new Button();
            user_btn = new Button();
            fabric_btn = new Button();
            report_btn = new Button();
            logout_btn = new Button();
            logoPn = new Panel();
            logoLb = new Label();
            main_pn = new Panel();
            content_pn = new Panel();
            topbar_pn = new Panel();
            root_layout.SuspendLayout();
            sidebar_pn.SuspendLayout();
            sidebar_buttons_layout.SuspendLayout();
            logoPn.SuspendLayout();
            main_pn.SuspendLayout();
            SuspendLayout();
            // 
            // root_layout
            // 
            root_layout.ColumnCount = 2;
            root_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 280F));
            root_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            root_layout.Controls.Add(sidebar_pn, 0, 0);
            root_layout.Controls.Add(main_pn, 1, 0);
            root_layout.Dock = DockStyle.Fill;
            root_layout.Location = new Point(0, 0);
            root_layout.Margin = new Padding(0);
            root_layout.Name = "root_layout";
            root_layout.RowCount = 1;
            root_layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            root_layout.Size = new Size(1292, 616);
            root_layout.TabIndex = 0;
            // 
            // sidebar_pn
            // 
            sidebar_pn.BackColor = Color.FromArgb(33, 52, 72);
            sidebar_pn.Controls.Add(sidebar_buttons_layout);
            sidebar_pn.Controls.Add(logout_btn);
            sidebar_pn.Controls.Add(logoPn);
            sidebar_pn.Dock = DockStyle.Fill;
            sidebar_pn.Location = new Point(0, 0);
            sidebar_pn.Margin = new Padding(0);
            sidebar_pn.Name = "sidebar_pn";
            sidebar_pn.Size = new Size(280, 616);
            sidebar_pn.TabIndex = 0;
            // 
            // sidebar_buttons_layout
            // 
            sidebar_buttons_layout.Controls.Add(home_btn);
            sidebar_buttons_layout.Controls.Add(order_btn);
            sidebar_buttons_layout.Controls.Add(customer_btn);
            sidebar_buttons_layout.Controls.Add(user_btn);
            sidebar_buttons_layout.Controls.Add(fabric_btn);
            sidebar_buttons_layout.Controls.Add(report_btn);
            sidebar_buttons_layout.Dock = DockStyle.Fill;
            sidebar_buttons_layout.Location = new Point(0, 201);
            sidebar_buttons_layout.Name = "sidebar_buttons_layout";
            sidebar_buttons_layout.Size = new Size(280, 353);
            sidebar_buttons_layout.TabIndex = 3;
            // 
            // home_btn
            // 
            home_btn.AutoSize = true;
            home_btn.BackColor = Color.Transparent;
            home_btn.BackgroundImageLayout = ImageLayout.None;
            home_btn.Cursor = Cursors.Hand;
            home_btn.Dock = DockStyle.Top;
            home_btn.FlatAppearance.BorderSize = 0;
            home_btn.FlatStyle = FlatStyle.Flat;
            home_btn.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            home_btn.ForeColor = Color.White;
            home_btn.ImageAlign = ContentAlignment.MiddleLeft;
            home_btn.Location = new Point(0, 0);
            home_btn.Margin = new Padding(0);
            home_btn.Name = "home_btn";
            home_btn.Size = new Size(280, 60);
            home_btn.TabIndex = 0;
            home_btn.Text = "Home";
            home_btn.UseVisualStyleBackColor = false;
            home_btn.Click += home_btn_Click;
            // 
            // order_btn
            // 
            order_btn.BackColor = Color.Transparent;
            order_btn.Cursor = Cursors.Hand;
            order_btn.Dock = DockStyle.Top;
            order_btn.FlatAppearance.BorderSize = 0;
            order_btn.FlatStyle = FlatStyle.Flat;
            order_btn.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            order_btn.ForeColor = Color.White;
            order_btn.Location = new Point(0, 60);
            order_btn.Margin = new Padding(0);
            order_btn.Name = "order_btn";
            order_btn.Size = new Size(280, 60);
            order_btn.TabIndex = 1;
            order_btn.Text = "Order";
            order_btn.UseVisualStyleBackColor = false;
            order_btn.Click += order_btn_Click;
            // 
            // customer_btn
            // 
            customer_btn.BackColor = Color.Transparent;
            customer_btn.Cursor = Cursors.Hand;
            customer_btn.Dock = DockStyle.Top;
            customer_btn.FlatAppearance.BorderSize = 0;
            customer_btn.FlatStyle = FlatStyle.Flat;
            customer_btn.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customer_btn.ForeColor = Color.White;
            customer_btn.Location = new Point(0, 120);
            customer_btn.Margin = new Padding(0);
            customer_btn.Name = "customer_btn";
            customer_btn.Size = new Size(280, 60);
            customer_btn.TabIndex = 2;
            customer_btn.Text = "Customer";
            customer_btn.UseVisualStyleBackColor = false;
            customer_btn.Click += customer_btn_Click;
            // 
            // user_btn
            // 
            user_btn.BackColor = Color.Transparent;
            user_btn.Cursor = Cursors.Hand;
            user_btn.Dock = DockStyle.Top;
            user_btn.FlatAppearance.BorderSize = 0;
            user_btn.FlatStyle = FlatStyle.Flat;
            user_btn.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            user_btn.ForeColor = Color.White;
            user_btn.ImageAlign = ContentAlignment.MiddleLeft;
            user_btn.Location = new Point(0, 180);
            user_btn.Margin = new Padding(0);
            user_btn.Name = "user_btn";
            user_btn.Size = new Size(280, 60);
            user_btn.TabIndex = 3;
            user_btn.Text = "User";
            user_btn.UseVisualStyleBackColor = false;
            user_btn.Click += user_btn_Click;
            // 
            // fabric_btn
            // 
            fabric_btn.BackColor = Color.Transparent;
            fabric_btn.Cursor = Cursors.Hand;
            fabric_btn.Dock = DockStyle.Top;
            fabric_btn.FlatAppearance.BorderSize = 0;
            fabric_btn.FlatStyle = FlatStyle.Flat;
            fabric_btn.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fabric_btn.ForeColor = Color.White;
            fabric_btn.ImageAlign = ContentAlignment.MiddleLeft;
            fabric_btn.Location = new Point(0, 240);
            fabric_btn.Margin = new Padding(0);
            fabric_btn.Name = "fabric_btn";
            fabric_btn.Size = new Size(280, 60);
            fabric_btn.TabIndex = 4;
            fabric_btn.Text = "Fabric";
            fabric_btn.UseVisualStyleBackColor = false;
            fabric_btn.Click += fabric_btn_Click;
            // 
            // report_btn
            // 
            report_btn.BackColor = Color.Transparent;
            report_btn.Cursor = Cursors.Hand;
            report_btn.Dock = DockStyle.Top;
            report_btn.FlatAppearance.BorderSize = 0;
            report_btn.FlatStyle = FlatStyle.Flat;
            report_btn.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            report_btn.ForeColor = Color.White;
            report_btn.ImageAlign = ContentAlignment.MiddleLeft;
            report_btn.Location = new Point(0, 300);
            report_btn.Margin = new Padding(0);
            report_btn.Name = "report_btn";
            report_btn.Size = new Size(280, 60);
            report_btn.TabIndex = 5;
            report_btn.Text = "Report";
            report_btn.UseVisualStyleBackColor = false;
            // 
            // logout_btn
            // 
            logout_btn.BackColor = Color.Gray;
            logout_btn.Cursor = Cursors.Hand;
            logout_btn.Dock = DockStyle.Bottom;
            logout_btn.FlatAppearance.BorderSize = 0;
            logout_btn.FlatStyle = FlatStyle.Flat;
            logout_btn.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logout_btn.ForeColor = Color.White;
            logout_btn.Location = new Point(0, 554);
            logout_btn.Margin = new Padding(0);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(280, 62);
            logout_btn.TabIndex = 2;
            logout_btn.Text = "Logout";
            logout_btn.UseVisualStyleBackColor = false;
            logout_btn.Click += logout_btn_Click;
            // 
            // logoPn
            // 
            logoPn.Controls.Add(logoLb);
            logoPn.Dock = DockStyle.Top;
            logoPn.Location = new Point(0, 0);
            logoPn.Name = "logoPn";
            logoPn.Size = new Size(280, 201);
            logoPn.TabIndex = 0;
            // 
            // logoLb
            // 
            logoLb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            logoLb.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoLb.ForeColor = Color.FromArgb(236, 239, 202);
            logoLb.Location = new Point(6, 86);
            logoLb.Name = "logoLb";
            logoLb.Size = new Size(266, 40);
            logoLb.TabIndex = 0;
            logoLb.Text = "Tailor's shop";
            logoLb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // main_pn
            // 
            main_pn.Controls.Add(content_pn);
            main_pn.Controls.Add(topbar_pn);
            main_pn.Dock = DockStyle.Fill;
            main_pn.Location = new Point(280, 0);
            main_pn.Margin = new Padding(0);
            main_pn.Name = "main_pn";
            main_pn.Size = new Size(1012, 616);
            main_pn.TabIndex = 1;
            // 
            // content_pn
            // 
            content_pn.Dock = DockStyle.Fill;
            content_pn.Location = new Point(0, 72);
            content_pn.Name = "content_pn";
            content_pn.Size = new Size(1012, 544);
            content_pn.TabIndex = 1;
            // 
            // topbar_pn
            // 
            topbar_pn.BackColor = Color.FromArgb(84, 119, 146);
            topbar_pn.Dock = DockStyle.Top;
            topbar_pn.Location = new Point(0, 0);
            topbar_pn.Margin = new Padding(0);
            topbar_pn.Name = "topbar_pn";
            topbar_pn.Size = new Size(1012, 72);
            topbar_pn.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1292, 616);
            Controls.Add(root_layout);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trailorinng Shop";
            WindowState = FormWindowState.Maximized;
            FormClosed += Dashboard_FormClosed;
            Load += Dashboard_Load;
            root_layout.ResumeLayout(false);
            sidebar_pn.ResumeLayout(false);
            sidebar_buttons_layout.ResumeLayout(false);
            sidebar_buttons_layout.PerformLayout();
            logoPn.ResumeLayout(false);
            main_pn.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel root_layout;
        private Panel sidebar_pn;
        private Panel logoPn;
        private Button home_btn;
        private Label logoLb;
        private Button order_btn;
        private Panel main_pn;
        private Button logout_btn;
        private Button customer_btn;
        private Panel content_pn;
        private Panel topbar_pn;
        private Button user_btn;
        private FlowLayoutPanel sidebar_buttons_layout;
        private Button fabric_btn;
        private Button report_btn;
    }
}
