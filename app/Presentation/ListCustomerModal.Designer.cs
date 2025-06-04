namespace app.Presentation
{
    partial class ListCustomerModal
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            root_pn = new Panel();
            content_pn = new Panel();
            customer_dgv = new DataGridView();
            pagination_pn = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            pagesize_cbb = new ComboBox();
            last_page_btn = new Button();
            next_page_btn = new Button();
            prev_page_btn = new Button();
            first_page_btn = new Button();
            page_lbl = new Label();
            filter_pn = new Panel();
            select_customer_btn = new Button();
            add_new_customer_btn = new Button();
            label1 = new Label();
            panel2 = new Panel();
            gender_cb = new ComboBox();
            search_pn = new Panel();
            search_txt = new TextBox();
            root_pn.SuspendLayout();
            content_pn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customer_dgv).BeginInit();
            pagination_pn.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            filter_pn.SuspendLayout();
            panel2.SuspendLayout();
            search_pn.SuspendLayout();
            SuspendLayout();
            // 
            // root_pn
            // 
            root_pn.BackColor = Color.White;
            root_pn.Controls.Add(content_pn);
            root_pn.Controls.Add(pagination_pn);
            root_pn.Controls.Add(filter_pn);
            root_pn.Dock = DockStyle.Fill;
            root_pn.Location = new Point(0, 0);
            root_pn.Name = "root_pn";
            root_pn.Size = new Size(900, 558);
            root_pn.TabIndex = 0;
            // 
            // content_pn
            // 
            content_pn.Controls.Add(customer_dgv);
            content_pn.Dock = DockStyle.Fill;
            content_pn.Location = new Point(0, 90);
            content_pn.Name = "content_pn";
            content_pn.Size = new Size(900, 398);
            content_pn.TabIndex = 1;
            // 
            // customer_dgv
            // 
            customer_dgv.AllowUserToAddRows = false;
            customer_dgv.AllowUserToDeleteRows = false;
            customer_dgv.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            customer_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            customer_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customer_dgv.Dock = DockStyle.Fill;
            customer_dgv.Location = new Point(0, 0);
            customer_dgv.Margin = new Padding(8);
            customer_dgv.Name = "customer_dgv";
            customer_dgv.ReadOnly = true;
            customer_dgv.RowHeadersWidth = 51;
            customer_dgv.Size = new Size(900, 398);
            customer_dgv.TabIndex = 1;
            // 
            // pagination_pn
            // 
            pagination_pn.Controls.Add(tableLayoutPanel1);
            pagination_pn.Dock = DockStyle.Bottom;
            pagination_pn.Location = new Point(0, 488);
            pagination_pn.Name = "pagination_pn";
            pagination_pn.Size = new Size(900, 70);
            pagination_pn.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666718F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.Controls.Add(pagesize_cbb, 3, 0);
            tableLayoutPanel1.Controls.Add(last_page_btn, 5, 0);
            tableLayoutPanel1.Controls.Add(next_page_btn, 4, 0);
            tableLayoutPanel1.Controls.Add(prev_page_btn, 1, 0);
            tableLayoutPanel1.Controls.Add(first_page_btn, 0, 0);
            tableLayoutPanel1.Controls.Add(page_lbl, 2, 0);
            tableLayoutPanel1.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel1.Location = new Point(188, 15);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(524, 40);
            tableLayoutPanel1.TabIndex = 4;
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
            filter_pn.Controls.Add(select_customer_btn);
            filter_pn.Controls.Add(add_new_customer_btn);
            filter_pn.Controls.Add(label1);
            filter_pn.Controls.Add(panel2);
            filter_pn.Controls.Add(search_pn);
            filter_pn.Dock = DockStyle.Top;
            filter_pn.Location = new Point(0, 0);
            filter_pn.Name = "filter_pn";
            filter_pn.Size = new Size(900, 90);
            filter_pn.TabIndex = 2;
            // 
            // select_customer_btn
            // 
            select_customer_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            select_customer_btn.BackColor = Color.FromArgb(33, 52, 72);
            select_customer_btn.Cursor = Cursors.Hand;
            select_customer_btn.FlatStyle = FlatStyle.Flat;
            select_customer_btn.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            select_customer_btn.ForeColor = Color.White;
            select_customer_btn.Location = new Point(769, 22);
            select_customer_btn.Name = "select_customer_btn";
            select_customer_btn.Size = new Size(110, 47);
            select_customer_btn.TabIndex = 3;
            select_customer_btn.Text = "ເລືອກ";
            select_customer_btn.UseVisualStyleBackColor = false;
            select_customer_btn.Click += select_customer_btn_Click;
            // 
            // add_new_customer_btn
            // 
            add_new_customer_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            add_new_customer_btn.BackColor = Color.FromArgb(33, 52, 72);
            add_new_customer_btn.Cursor = Cursors.Hand;
            add_new_customer_btn.FlatStyle = FlatStyle.Flat;
            add_new_customer_btn.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_new_customer_btn.ForeColor = Color.White;
            add_new_customer_btn.Location = new Point(594, 22);
            add_new_customer_btn.Name = "add_new_customer_btn";
            add_new_customer_btn.Size = new Size(156, 47);
            add_new_customer_btn.TabIndex = 4;
            add_new_customer_btn.Text = "ເພີ່ມລູກຄ້າໃໝ່";
            add_new_customer_btn.UseVisualStyleBackColor = false;
            add_new_customer_btn.Click += add_new_customer_btn_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(315, 22);
            label1.Name = "label1";
            label1.Size = new Size(49, 47);
            label1.TabIndex = 2;
            label1.Text = "ເພດ";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(gender_cb);
            panel2.Location = new Point(366, 22);
            panel2.Name = "panel2";
            panel2.Size = new Size(198, 47);
            panel2.TabIndex = 1;
            // 
            // gender_cb
            // 
            gender_cb.FlatStyle = FlatStyle.Flat;
            gender_cb.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gender_cb.FormattingEnabled = true;
            gender_cb.Items.AddRange(new object[] { "All", "Male", "Female", "Other", "PreferNotToSay" });
            gender_cb.Location = new Point(3, 2);
            gender_cb.Name = "gender_cb";
            gender_cb.Size = new Size(190, 41);
            gender_cb.TabIndex = 1;
            gender_cb.SelectedIndexChanged += gender_cb_SelectedValueChanged;
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
            // ListCustomerModal
            // 
            AutoScaleDimensions = new SizeF(9F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 558);
            Controls.Add(root_pn);
            Font = new Font("Noto Sans Lao", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ListCustomerModal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ລາຍຊື່ລູກຄ້າ";
            Load += ListCustomerModal_Load;
            root_pn.ResumeLayout(false);
            content_pn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)customer_dgv).EndInit();
            pagination_pn.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            filter_pn.ResumeLayout(false);
            panel2.ResumeLayout(false);
            search_pn.ResumeLayout(false);
            search_pn.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel root_pn;
        private Panel content_pn;
        private Panel pagination_pn;
        private Panel filter_pn;
        private Label label1;
        private Panel panel2;
        private ComboBox gender_cb;
        private Panel search_pn;
        private TextBox search_txt;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox pagesize_cbb;
        private Button last_page_btn;
        private Button next_page_btn;
        private Button prev_page_btn;
        private Button first_page_btn;
        private Label page_lbl;
        private Button select_customer_btn;
        private DataGridView customer_dgv;
        private Button add_new_customer_btn;
    }
}