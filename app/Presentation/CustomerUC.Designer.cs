namespace app.Presentation
{
    partial class CustomerUC
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
            main_layout = new TableLayoutPanel();
            bottom_pn = new TableLayoutPanel();
            customer_dgv = new DataGridView();
            filter_pn = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            gender_cb = new ComboBox();
            search_pn = new Panel();
            search_txt = new TextBox();
            top_pn = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            total_customer_lb = new Label();
            label2 = new Label();
            new_customer_btn = new Button();
            main_layout.SuspendLayout();
            bottom_pn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customer_dgv).BeginInit();
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
            main_layout.TabIndex = 1;
            // 
            // bottom_pn
            // 
            bottom_pn.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            bottom_pn.ColumnCount = 1;
            bottom_pn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            bottom_pn.Controls.Add(customer_dgv, 0, 1);
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
            // customer_dgv
            // 
            customer_dgv.AllowUserToAddRows = false;
            customer_dgv.AllowUserToDeleteRows = false;
            customer_dgv.BackgroundColor = Color.White;
            customer_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customer_dgv.Dock = DockStyle.Fill;
            customer_dgv.Location = new Point(9, 110);
            customer_dgv.Margin = new Padding(8);
            customer_dgv.Name = "customer_dgv";
            customer_dgv.ReadOnly = true;
            customer_dgv.RowHeadersWidth = 51;
            customer_dgv.Size = new Size(1176, 443);
            customer_dgv.TabIndex = 0;
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
            label1.Text = "Gender";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(gender_cb);
            panel1.Location = new Point(406, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(198, 47);
            panel1.TabIndex = 1;
            // 
            // gender_cb
            // 
            gender_cb.FlatStyle = FlatStyle.Flat;
            gender_cb.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gender_cb.FormattingEnabled = true;
            gender_cb.Items.AddRange(new object[] { "All", "Male", "Female", "Other", "PreferNotToSay" });
            gender_cb.Location = new Point(3, 7);
            gender_cb.Name = "gender_cb";
            gender_cb.Size = new Size(190, 31);
            gender_cb.TabIndex = 1;
            gender_cb.SelectedValueChanged += gender_cb_SelectedValueChanged;
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
            top_pn.Controls.Add(tableLayoutPanel1);
            top_pn.Controls.Add(new_customer_btn);
            top_pn.Dock = DockStyle.Fill;
            top_pn.Location = new Point(3, 3);
            top_pn.Name = "top_pn";
            top_pn.Size = new Size(1194, 194);
            top_pn.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(84, 119, 146);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(total_customer_lb, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Location = new Point(42, 35);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(337, 129);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // total_customer_lb
            // 
            total_customer_lb.Dock = DockStyle.Fill;
            total_customer_lb.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total_customer_lb.ForeColor = Color.White;
            total_customer_lb.Location = new Point(3, 64);
            total_customer_lb.Name = "total_customer_lb";
            total_customer_lb.Size = new Size(331, 65);
            total_customer_lb.TabIndex = 2;
            total_customer_lb.Text = "0";
            total_customer_lb.TextAlign = ContentAlignment.MiddleCenter;
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
            label2.Text = "Total Customers";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // new_customer_btn
            // 
            new_customer_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            new_customer_btn.BackColor = Color.FromArgb(33, 52, 72);
            new_customer_btn.FlatStyle = FlatStyle.Flat;
            new_customer_btn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            new_customer_btn.ForeColor = Color.White;
            new_customer_btn.Location = new Point(985, 64);
            new_customer_btn.Name = "new_customer_btn";
            new_customer_btn.Size = new Size(178, 66);
            new_customer_btn.TabIndex = 0;
            new_customer_btn.Text = "New Customer";
            new_customer_btn.UseVisualStyleBackColor = false;
            new_customer_btn.Click += new_customer_btn_Click;
            // 
            // CustomerUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(main_layout);
            Name = "CustomerUC";
            Size = new Size(1200, 768);
            Load += Customer_Load;
            main_layout.ResumeLayout(false);
            bottom_pn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)customer_dgv).EndInit();
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
        private Panel top_pn;
        private Button new_customer_btn;
        private Panel filter_pn;
        private DataGridView customer_dgv;
        private TableLayoutPanel bottom_pn;
        private ComboBox gender_cb;
        private Panel search_pn;
        private TextBox search_txt;
        private Panel panel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label total_customer_lb;
    }
}
