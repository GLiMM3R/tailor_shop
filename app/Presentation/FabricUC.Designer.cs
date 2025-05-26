namespace app.Presentation
{
    partial class FabricUC
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
            fabric_dgv = new DataGridView();
            main_layout = new TableLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            pagination_pn = new TableLayoutPanel();
            pagesize_cbb = new ComboBox();
            last_page_btn = new Button();
            next_page_btn = new Button();
            prev_page_btn = new Button();
            first_page_btn = new Button();
            page_lbl = new Label();
            filter_pn = new Panel();
            search_pn = new Panel();
            search_txt = new TextBox();
            top_pn = new Panel();
            new_customer_btn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            total_fabric_lb = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)fabric_dgv).BeginInit();
            main_layout.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            pagination_pn.SuspendLayout();
            filter_pn.SuspendLayout();
            search_pn.SuspendLayout();
            top_pn.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // fabric_dgv
            // 
            fabric_dgv.AllowUserToAddRows = false;
            fabric_dgv.AllowUserToDeleteRows = false;
            fabric_dgv.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            fabric_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            fabric_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            fabric_dgv.Dock = DockStyle.Fill;
            fabric_dgv.Location = new Point(0, 90);
            fabric_dgv.Margin = new Padding(8);
            fabric_dgv.Name = "fabric_dgv";
            fabric_dgv.ReadOnly = true;
            fabric_dgv.RowHeadersWidth = 51;
            fabric_dgv.Size = new Size(1194, 402);
            fabric_dgv.TabIndex = 0;
            // 
            // main_layout
            // 
            main_layout.BackColor = Color.White;
            main_layout.ColumnCount = 1;
            main_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            main_layout.Controls.Add(panel1, 0, 1);
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
            // panel1
            // 
            panel1.Controls.Add(fabric_dgv);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(filter_pn);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 203);
            panel1.Name = "panel1";
            panel1.Size = new Size(1194, 562);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(pagination_pn);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 492);
            panel2.Name = "panel2";
            panel2.Size = new Size(1194, 70);
            panel2.TabIndex = 1;
            // 
            // pagination_pn
            // 
            pagination_pn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pagination_pn.ColumnCount = 6;
            pagination_pn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666718F));
            pagination_pn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            pagination_pn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            pagination_pn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            pagination_pn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            pagination_pn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            pagination_pn.Controls.Add(pagesize_cbb, 3, 0);
            pagination_pn.Controls.Add(last_page_btn, 5, 0);
            pagination_pn.Controls.Add(next_page_btn, 4, 0);
            pagination_pn.Controls.Add(prev_page_btn, 1, 0);
            pagination_pn.Controls.Add(first_page_btn, 0, 0);
            pagination_pn.Controls.Add(page_lbl, 2, 0);
            pagination_pn.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pagination_pn.Location = new Point(335, 15);
            pagination_pn.Name = "pagination_pn";
            pagination_pn.RowCount = 1;
            pagination_pn.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pagination_pn.Size = new Size(524, 40);
            pagination_pn.TabIndex = 3;
            // 
            // pagesize_cbb
            // 
            pagesize_cbb.Dock = DockStyle.Fill;
            pagesize_cbb.FormattingEnabled = true;
            pagesize_cbb.Items.AddRange(new object[] { "10", "20", "30", "50", "100" });
            pagesize_cbb.Location = new Point(264, 3);
            pagesize_cbb.Name = "pagesize_cbb";
            pagesize_cbb.Size = new Size(81, 36);
            pagesize_cbb.TabIndex = 7;
            pagesize_cbb.SelectedIndexChanged += pagesize_cbb_SelectedIndexChanged;
            // 
            // last_page_btn
            // 
            last_page_btn.BackColor = Color.LightGray;
            last_page_btn.Cursor = Cursors.Hand;
            last_page_btn.Dock = DockStyle.Fill;
            last_page_btn.FlatStyle = FlatStyle.Flat;
            last_page_btn.Font = new Font("Noto Sans Lao", 7.79999971F);
            last_page_btn.Location = new Point(438, 3);
            last_page_btn.Name = "last_page_btn";
            last_page_btn.Size = new Size(83, 34);
            last_page_btn.TabIndex = 4;
            last_page_btn.Text = "ສຸດທ້າຍ >>";
            last_page_btn.UseVisualStyleBackColor = false;
            last_page_btn.Click += last_page_btn_Click;
            // 
            // next_page_btn
            // 
            next_page_btn.BackColor = Color.LightGray;
            next_page_btn.Cursor = Cursors.Hand;
            next_page_btn.Dock = DockStyle.Fill;
            next_page_btn.FlatStyle = FlatStyle.Flat;
            next_page_btn.Font = new Font("Noto Sans Lao", 7.79999971F);
            next_page_btn.Location = new Point(351, 3);
            next_page_btn.Name = "next_page_btn";
            next_page_btn.Size = new Size(81, 34);
            next_page_btn.TabIndex = 3;
            next_page_btn.Text = "ຖັດໄປ >";
            next_page_btn.UseVisualStyleBackColor = false;
            next_page_btn.Click += next_page_btn_Click;
            // 
            // prev_page_btn
            // 
            prev_page_btn.BackColor = Color.LightGray;
            prev_page_btn.Cursor = Cursors.Hand;
            prev_page_btn.Dock = DockStyle.Fill;
            prev_page_btn.FlatStyle = FlatStyle.Flat;
            prev_page_btn.Font = new Font("Noto Sans Lao", 7.79999971F);
            prev_page_btn.Location = new Point(90, 3);
            prev_page_btn.Name = "prev_page_btn";
            prev_page_btn.Size = new Size(81, 34);
            prev_page_btn.TabIndex = 1;
            prev_page_btn.Text = "< ກັບຄືນ";
            prev_page_btn.UseVisualStyleBackColor = false;
            prev_page_btn.Click += prev_page_btn_Click;
            // 
            // first_page_btn
            // 
            first_page_btn.BackColor = Color.LightGray;
            first_page_btn.Cursor = Cursors.Hand;
            first_page_btn.Dock = DockStyle.Fill;
            first_page_btn.FlatStyle = FlatStyle.Flat;
            first_page_btn.Font = new Font("Noto Sans Lao", 7.79999971F);
            first_page_btn.Location = new Point(3, 3);
            first_page_btn.Name = "first_page_btn";
            first_page_btn.Size = new Size(81, 34);
            first_page_btn.TabIndex = 0;
            first_page_btn.Text = "<< ທໍາອິດ";
            first_page_btn.UseVisualStyleBackColor = false;
            first_page_btn.Click += first_page_btn_Click;
            // 
            // page_lbl
            // 
            page_lbl.Dock = DockStyle.Fill;
            page_lbl.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            page_lbl.Location = new Point(177, 0);
            page_lbl.Name = "page_lbl";
            page_lbl.Size = new Size(81, 40);
            page_lbl.TabIndex = 2;
            page_lbl.Text = "1/1";
            page_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // filter_pn
            // 
            filter_pn.Controls.Add(search_pn);
            filter_pn.Dock = DockStyle.Top;
            filter_pn.Location = new Point(0, 0);
            filter_pn.Name = "filter_pn";
            filter_pn.Size = new Size(1194, 90);
            filter_pn.TabIndex = 1;
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
            search_txt.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search_txt.Location = new Point(7, 6);
            search_txt.Name = "search_txt";
            search_txt.PlaceholderText = "ຄົ້ນຫາ...";
            search_txt.Size = new Size(259, 33);
            search_txt.TabIndex = 0;
            search_txt.TextChanged += search_txt_TextChanged;
            // 
            // top_pn
            // 
            top_pn.Controls.Add(new_customer_btn);
            top_pn.Controls.Add(tableLayoutPanel1);
            top_pn.Dock = DockStyle.Fill;
            top_pn.Location = new Point(3, 3);
            top_pn.Name = "top_pn";
            top_pn.Size = new Size(1194, 194);
            top_pn.TabIndex = 1;
            // 
            // new_customer_btn
            // 
            new_customer_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            new_customer_btn.BackColor = Color.FromArgb(33, 52, 72);
            new_customer_btn.Cursor = Cursors.Hand;
            new_customer_btn.FlatStyle = FlatStyle.Flat;
            new_customer_btn.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            new_customer_btn.ForeColor = Color.White;
            new_customer_btn.Location = new Point(985, 64);
            new_customer_btn.Name = "new_customer_btn";
            new_customer_btn.Size = new Size(178, 66);
            new_customer_btn.TabIndex = 2;
            new_customer_btn.Text = "ສ້າງຜ້າໃໝ່";
            new_customer_btn.UseVisualStyleBackColor = false;
            new_customer_btn.Click += new_fabric_btn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(84, 119, 146);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(total_fabric_lb, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Location = new Point(42, 35);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(337, 129);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // total_fabric_lb
            // 
            total_fabric_lb.Dock = DockStyle.Fill;
            total_fabric_lb.Font = new Font("Noto Sans Lao", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total_fabric_lb.ForeColor = Color.White;
            total_fabric_lb.Location = new Point(3, 64);
            total_fabric_lb.Name = "total_fabric_lb";
            total_fabric_lb.Size = new Size(331, 65);
            total_fabric_lb.TabIndex = 2;
            total_fabric_lb.Text = "0";
            total_fabric_lb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Noto Sans Lao", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(331, 64);
            label2.TabIndex = 0;
            label2.Text = "ຈຳນວນຜ້າ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FabricUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(main_layout);
            Name = "FabricUC";
            Size = new Size(1200, 768);
            Load += FabricUC_Load;
            ((System.ComponentModel.ISupportInitialize)fabric_dgv).EndInit();
            main_layout.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            pagination_pn.ResumeLayout(false);
            filter_pn.ResumeLayout(false);
            search_pn.ResumeLayout(false);
            search_pn.PerformLayout();
            top_pn.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView fabric_dgv;
        private TableLayoutPanel main_layout;
        private Panel filter_pn;
        private Panel search_pn;
        private TextBox search_txt;
        private Panel top_pn;
        private TableLayoutPanel tableLayoutPanel1;
        private Label total_fabric_lb;
        private Label label2;
        private Button new_customer_btn;
        private Panel panel1;
        private Panel panel2;
        private TableLayoutPanel pagination_pn;
        private ComboBox pagesize_cbb;
        private Button last_page_btn;
        private Button next_page_btn;
        private Button prev_page_btn;
        private Button first_page_btn;
        private Label page_lbl;
    }
}
