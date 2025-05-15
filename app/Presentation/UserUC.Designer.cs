namespace app.Presentation
{
    partial class UserUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            main_layout = new TableLayoutPanel();
            bottom_pn = new TableLayoutPanel();
            user_dgv = new DataGridView();
            filter_pn = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            role_cb = new ComboBox();
            search_pn = new Panel();
            search_txt = new TextBox();
            top_pn = new Panel();
            new_user_btn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            total_users_lb = new Label();
            label2 = new Label();
            main_layout.SuspendLayout();
            bottom_pn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)user_dgv).BeginInit();
            filter_pn.SuspendLayout();
            panel1.SuspendLayout();
            search_pn.SuspendLayout();
            top_pn.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // main_layout
            // 
            main_layout.BackColor = Color.White;
            main_layout.ColumnCount = 1;
            main_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            main_layout.Controls.Add(bottom_pn, 0, 2);
            main_layout.Controls.Add(top_pn, 0, 0);
            main_layout.Dock = DockStyle.Fill;
            main_layout.Location = new Point(0, 0);
            main_layout.Name = "main_layout";
            main_layout.RowCount = 1;
            main_layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            main_layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 0F));
            main_layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            main_layout.Size = new Size(1200, 768);
            main_layout.TabIndex = 2;
            // 
            // bottom_pn
            // 
            bottom_pn.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            bottom_pn.ColumnCount = 1;
            bottom_pn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            bottom_pn.Controls.Add(user_dgv, 0, 1);
            bottom_pn.Controls.Add(filter_pn, 0, 0);
            bottom_pn.Dock = DockStyle.Fill;
            bottom_pn.Location = new Point(3, 203);
            bottom_pn.Name = "bottom_pn";
            bottom_pn.RowCount = 2;
            bottom_pn.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            bottom_pn.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            bottom_pn.Size = new Size(1194, 562);
            bottom_pn.TabIndex = 1;
            // 
            // user_dgv
            // 
            user_dgv.AllowUserToAddRows = false;
            user_dgv.AllowUserToDeleteRows = false;
            user_dgv.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            user_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            user_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            user_dgv.Dock = DockStyle.Fill;
            user_dgv.Location = new Point(9, 110);
            user_dgv.Margin = new Padding(8);
            user_dgv.Name = "user_dgv";
            user_dgv.ReadOnly = true;
            user_dgv.RowHeadersWidth = 51;
            user_dgv.Size = new Size(1176, 443);
            user_dgv.TabIndex = 0;
            user_dgv.CellContentClick += user_dgv_CellContentClick;
            // 
            // filter_pn
            // 
            filter_pn.Controls.Add(label1);
            filter_pn.Controls.Add(panel1);
            filter_pn.Controls.Add(search_pn);
            filter_pn.Dock = DockStyle.Top;
            filter_pn.Location = new Point(4, 4);
            filter_pn.Name = "filter_pn";
            filter_pn.Size = new Size(1186, 90);
            filter_pn.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(332, 22);
            label1.Name = "label1";
            label1.Size = new Size(72, 47);
            label1.TabIndex = 2;
            label1.Text = "Role";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(role_cb);
            panel1.Location = new Point(406, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(198, 47);
            panel1.TabIndex = 1;
            // 
            // role_cb
            // 
            role_cb.FlatStyle = FlatStyle.Flat;
            role_cb.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            role_cb.FormattingEnabled = true;
            role_cb.Items.AddRange(new object[] { "All", "User", "Admin" });
            role_cb.Location = new Point(3, 7);
            role_cb.Name = "role_cb";
            role_cb.Size = new Size(190, 31);
            role_cb.TabIndex = 1;
            role_cb.SelectedValueChanged += role_cb_SelectedValueChanged;
            // 
            // search_pn
            // 
            search_pn.BorderStyle = BorderStyle.FixedSingle;
            search_pn.Controls.Add(search_txt);
            search_pn.Location = new Point(30, 22);
            search_pn.Name = "search_pn";
            search_pn.Size = new Size(275, 47);
            search_pn.TabIndex = 0;
            // 
            // search_txt
            // 
            search_txt.BorderStyle = BorderStyle.None;
            search_txt.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search_txt.Location = new Point(7, 11);
            search_txt.Name = "search_txt";
            search_txt.PlaceholderText = "Search...";
            search_txt.Size = new Size(259, 23);
            search_txt.TabIndex = 0;
            search_txt.TextChanged += search_txt_TextChanged;
            // 
            // top_pn
            // 
            top_pn.Controls.Add(new_user_btn);
            top_pn.Controls.Add(tableLayoutPanel1);
            top_pn.Dock = DockStyle.Fill;
            top_pn.Location = new Point(3, 3);
            top_pn.Name = "top_pn";
            top_pn.Size = new Size(1194, 194);
            top_pn.TabIndex = 1;
            // 
            // new_user_btn
            // 
            new_user_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            new_user_btn.BackColor = Color.FromArgb(33, 52, 72);
            new_user_btn.Cursor = Cursors.Hand;
            new_user_btn.FlatStyle = FlatStyle.Flat;
            new_user_btn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            new_user_btn.ForeColor = Color.White;
            new_user_btn.Location = new Point(985, 64);
            new_user_btn.Name = "new_user_btn";
            new_user_btn.Size = new Size(178, 66);
            new_user_btn.TabIndex = 2;
            new_user_btn.Text = "New User";
            new_user_btn.UseVisualStyleBackColor = false;
            new_user_btn.Click += new_user_btn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(84, 119, 146);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(total_users_lb, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Location = new Point(42, 35);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(337, 129);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // total_users_lb
            // 
            total_users_lb.Dock = DockStyle.Fill;
            total_users_lb.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total_users_lb.ForeColor = Color.White;
            total_users_lb.Location = new Point(3, 64);
            total_users_lb.Name = "total_users_lb";
            total_users_lb.Size = new Size(331, 65);
            total_users_lb.TabIndex = 2;
            total_users_lb.Text = "0";
            total_users_lb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(331, 64);
            label2.TabIndex = 0;
            label2.Text = "Total Users";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(main_layout);
            Name = "UserUC";
            Size = new Size(1200, 768);
            Load += UserUC_Load;
            main_layout.ResumeLayout(false);
            bottom_pn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)user_dgv).EndInit();
            filter_pn.ResumeLayout(false);
            panel1.ResumeLayout(false);
            search_pn.ResumeLayout(false);
            search_pn.PerformLayout();
            top_pn.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel main_layout;
        private TableLayoutPanel bottom_pn;
        private DataGridView user_dgv;
        private Panel filter_pn;
        private Label label1;
        private Panel panel1;
        private ComboBox role_cb;
        private Panel search_pn;
        private TextBox search_txt;
        private Panel top_pn;
        private TableLayoutPanel tableLayoutPanel1;
        private Label total_users_lb;
        private Label label2;
        private Button new_user_btn;
    }
}
