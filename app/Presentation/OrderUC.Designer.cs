namespace app.Presentation
{
    partial class OrderUC
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
                _dbContext?.Dispose();
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
            order_dgv = new DataGridView();
            filter_pn = new Panel();
            clear_btn = new Button();
            label1 = new Label();
            panel1 = new Panel();
            status_cbb = new ComboBox();
            search_pn = new Panel();
            search_txt = new TextBox();
            main_layout = new TableLayoutPanel();
            panel2 = new Panel();
            panel3 = new Panel();
            pagination_pn = new TableLayoutPanel();
            pagesize_cbb = new ComboBox();
            last_page_btn = new Button();
            next_page_btn = new Button();
            prev_page_btn = new Button();
            first_page_btn = new Button();
            page_lbl = new Label();
            top_pn = new Panel();
            new_order_btn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            total_order_lbl = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)order_dgv).BeginInit();
            filter_pn.SuspendLayout();
            panel1.SuspendLayout();
            search_pn.SuspendLayout();
            main_layout.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            pagination_pn.SuspendLayout();
            top_pn.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // order_dgv
            // 
            order_dgv.AllowUserToAddRows = false;
            order_dgv.AllowUserToDeleteRows = false;
            order_dgv.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            order_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            order_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            order_dgv.Dock = DockStyle.Fill;
            order_dgv.Location = new Point(0, 90);
            order_dgv.Margin = new Padding(8);
            order_dgv.Name = "order_dgv";
            order_dgv.ReadOnly = true;
            order_dgv.RowHeadersWidth = 51;
            order_dgv.Size = new Size(1060, 285);
            order_dgv.TabIndex = 0;
            // 
            // filter_pn
            // 
            filter_pn.Controls.Add(clear_btn);
            filter_pn.Controls.Add(label1);
            filter_pn.Controls.Add(panel1);
            filter_pn.Controls.Add(search_pn);
            filter_pn.Dock = DockStyle.Top;
            filter_pn.Location = new Point(0, 0);
            filter_pn.Name = "filter_pn";
            filter_pn.Size = new Size(1060, 90);
            filter_pn.TabIndex = 1;
            // 
            // clear_btn
            // 
            clear_btn.BackColor = Color.LightGray;
            clear_btn.Cursor = Cursors.Hand;
            clear_btn.FlatStyle = FlatStyle.Flat;
            clear_btn.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clear_btn.Location = new Point(666, 23);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(94, 47);
            clear_btn.TabIndex = 5;
            clear_btn.Text = "ລຶບ";
            clear_btn.UseVisualStyleBackColor = false;
            clear_btn.Click += clear_btn_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(350, 22);
            label1.Name = "label1";
            label1.Size = new Size(72, 47);
            label1.TabIndex = 4;
            label1.Text = "ສະຖານະ";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(status_cbb);
            panel1.Location = new Point(424, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(204, 47);
            panel1.TabIndex = 3;
            // 
            // status_cbb
            // 
            status_cbb.FlatStyle = FlatStyle.Flat;
            status_cbb.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            status_cbb.FormattingEnabled = true;
            status_cbb.Items.AddRange(new object[] { "All", "User", "Admin" });
            status_cbb.Location = new Point(6, 2);
            status_cbb.Name = "status_cbb";
            status_cbb.Size = new Size(190, 41);
            status_cbb.TabIndex = 1;
            status_cbb.SelectedIndexChanged += status_cbb_SelectedIndexChanged;
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
            // main_layout
            // 
            main_layout.BackColor = Color.White;
            main_layout.ColumnCount = 1;
            main_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            main_layout.Controls.Add(panel2, 0, 1);
            main_layout.Controls.Add(top_pn, 0, 0);
            main_layout.Dock = DockStyle.Fill;
            main_layout.Location = new Point(0, 0);
            main_layout.Name = "main_layout";
            main_layout.RowCount = 1;
            main_layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            main_layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 0F));
            main_layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            main_layout.Size = new Size(1066, 651);
            main_layout.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(order_dgv);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(filter_pn);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 203);
            panel2.Name = "panel2";
            panel2.Size = new Size(1060, 445);
            panel2.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Controls.Add(pagination_pn);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 375);
            panel3.Name = "panel3";
            panel3.Size = new Size(1060, 70);
            panel3.TabIndex = 6;
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
            pagination_pn.Location = new Point(268, 15);
            pagination_pn.Name = "pagination_pn";
            pagination_pn.RowCount = 1;
            pagination_pn.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pagination_pn.Size = new Size(524, 40);
            pagination_pn.TabIndex = 5;
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
            // top_pn
            // 
            top_pn.Controls.Add(new_order_btn);
            top_pn.Controls.Add(tableLayoutPanel1);
            top_pn.Dock = DockStyle.Fill;
            top_pn.Location = new Point(3, 3);
            top_pn.Name = "top_pn";
            top_pn.Size = new Size(1060, 194);
            top_pn.TabIndex = 1;
            // 
            // new_order_btn
            // 
            new_order_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            new_order_btn.BackColor = Color.FromArgb(33, 52, 72);
            new_order_btn.Cursor = Cursors.Hand;
            new_order_btn.FlatStyle = FlatStyle.Flat;
            new_order_btn.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            new_order_btn.ForeColor = Color.White;
            new_order_btn.Location = new Point(850, 64);
            new_order_btn.Name = "new_order_btn";
            new_order_btn.Size = new Size(178, 66);
            new_order_btn.TabIndex = 3;
            new_order_btn.Text = "ສ້າງອໍເດີໃໝ່";
            new_order_btn.UseVisualStyleBackColor = false;
            new_order_btn.Click += new_order_btn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(84, 119, 146);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(total_order_lbl, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Location = new Point(42, 35);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(337, 129);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // total_order_lbl
            // 
            total_order_lbl.Dock = DockStyle.Fill;
            total_order_lbl.Font = new Font("Noto Sans Lao", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total_order_lbl.ForeColor = Color.White;
            total_order_lbl.Location = new Point(3, 64);
            total_order_lbl.Name = "total_order_lbl";
            total_order_lbl.Size = new Size(331, 65);
            total_order_lbl.TabIndex = 2;
            total_order_lbl.Text = "0";
            total_order_lbl.TextAlign = ContentAlignment.MiddleCenter;
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
            label2.Text = "ຈຳນວນການສັ່ງຕັດ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OrderUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(main_layout);
            Name = "OrderUC";
            Size = new Size(1066, 651);
            Load += OrderUC_Load;
            ((System.ComponentModel.ISupportInitialize)order_dgv).EndInit();
            filter_pn.ResumeLayout(false);
            panel1.ResumeLayout(false);
            search_pn.ResumeLayout(false);
            search_pn.PerformLayout();
            main_layout.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            pagination_pn.ResumeLayout(false);
            top_pn.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView order_dgv;
        private Panel filter_pn;
        private Panel search_pn;
        private TextBox search_txt;
        private TableLayoutPanel main_layout;
        private Panel top_pn;
        private TableLayoutPanel tableLayoutPanel1;
        private Label total_order_lbl;
        private Label label2;
        private Button new_order_btn;
        private Label label1;
        private Panel panel1;
        private ComboBox status_cbb;
        private Button clear_btn;
        private Panel panel2;
        private Panel panel3;
        private TableLayoutPanel pagination_pn;
        private ComboBox pagesize_cbb;
        private Button last_page_btn;
        private Button next_page_btn;
        private Button prev_page_btn;
        private Button first_page_btn;
        private Label page_lbl;
    }
}
