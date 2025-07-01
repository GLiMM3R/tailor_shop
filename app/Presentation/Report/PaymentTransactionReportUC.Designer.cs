namespace app.Presentation.Report
{
    partial class PaymentTransactionReportUC
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
            gross_sales_pn = new TableLayoutPanel();
            total_transactions_lbl = new Label();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            pagination_pn = new TableLayoutPanel();
            pagesize_cbb = new ComboBox();
            last_page_btn = new Button();
            next_page_btn = new Button();
            prev_page_btn = new Button();
            first_page_btn = new Button();
            page_lbl = new Label();
            bottom_pn = new TableLayoutPanel();
            payment_report_dgv = new DataGridView();
            filter_pn = new Panel();
            label4 = new Label();
            panel5 = new Panel();
            period_cbb = new ComboBox();
            export_btn = new Button();
            panel2 = new Panel();
            to_date_dpk = new DateTimePicker();
            label3 = new Label();
            from_date_dpk = new DateTimePicker();
            total_bank_lbl = new Label();
            label8 = new Label();
            label6 = new Label();
            discount_pn = new TableLayoutPanel();
            total_deposit_lbl = new Label();
            label9 = new Label();
            panel1 = new Panel();
            back_btn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            total_avg_lbl = new Label();
            label11 = new Label();
            paid_amount_pn = new TableLayoutPanel();
            aov_pn = new TableLayoutPanel();
            total_cash_lbl = new Label();
            label7 = new Label();
            total_orders_pn = new TableLayoutPanel();
            total_paid_amount_lbl = new Label();
            gross_sales_pn.SuspendLayout();
            panel3.SuspendLayout();
            pagination_pn.SuspendLayout();
            bottom_pn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)payment_report_dgv).BeginInit();
            filter_pn.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            discount_pn.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            paid_amount_pn.SuspendLayout();
            aov_pn.SuspendLayout();
            total_orders_pn.SuspendLayout();
            SuspendLayout();
            // 
            // gross_sales_pn
            // 
            gross_sales_pn.BackColor = Color.FromArgb(84, 119, 146);
            gross_sales_pn.ColumnCount = 1;
            gross_sales_pn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            gross_sales_pn.Controls.Add(total_transactions_lbl, 0, 1);
            gross_sales_pn.Controls.Add(label2, 0, 0);
            gross_sales_pn.Location = new Point(27, 125);
            gross_sales_pn.Name = "gross_sales_pn";
            gross_sales_pn.RowCount = 2;
            gross_sales_pn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            gross_sales_pn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            gross_sales_pn.Size = new Size(220, 100);
            gross_sales_pn.TabIndex = 2;
            // 
            // total_transactions_lbl
            // 
            total_transactions_lbl.Dock = DockStyle.Fill;
            total_transactions_lbl.Font = new Font("Noto Sans", 13.7999992F, FontStyle.Bold);
            total_transactions_lbl.ForeColor = Color.White;
            total_transactions_lbl.Location = new Point(3, 50);
            total_transactions_lbl.Name = "total_transactions_lbl";
            total_transactions_lbl.Size = new Size(214, 50);
            total_transactions_lbl.TabIndex = 2;
            total_transactions_lbl.Text = "0";
            total_transactions_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Noto Sans Lao", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(214, 50);
            label2.TabIndex = 0;
            label2.Text = "ຈຳນວນທຸລະກຳ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(33, 52, 72);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Noto Sans Lao", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1627, 94);
            label1.TabIndex = 0;
            label1.Text = "ລາຍງານການຊຳລະເງິນ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(pagination_pn);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 823);
            panel3.Name = "panel3";
            panel3.Size = new Size(1627, 75);
            panel3.TabIndex = 12;
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
            pagination_pn.Location = new Point(376, 17);
            pagination_pn.Name = "pagination_pn";
            pagination_pn.RowCount = 1;
            pagination_pn.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pagination_pn.Size = new Size(875, 41);
            pagination_pn.TabIndex = 1;
            // 
            // pagesize_cbb
            // 
            pagesize_cbb.Dock = DockStyle.Fill;
            pagesize_cbb.FormattingEnabled = true;
            pagesize_cbb.Items.AddRange(new object[] { "10", "20", "30", "50", "100" });
            pagesize_cbb.Location = new Point(438, 3);
            pagesize_cbb.Name = "pagesize_cbb";
            pagesize_cbb.Size = new Size(139, 36);
            pagesize_cbb.TabIndex = 7;
            // 
            // last_page_btn
            // 
            last_page_btn.BackColor = Color.LightGray;
            last_page_btn.Cursor = Cursors.Hand;
            last_page_btn.Dock = DockStyle.Fill;
            last_page_btn.FlatStyle = FlatStyle.Flat;
            last_page_btn.Font = new Font("Noto Sans Lao", 7.79999971F);
            last_page_btn.Location = new Point(728, 3);
            last_page_btn.Name = "last_page_btn";
            last_page_btn.Size = new Size(144, 35);
            last_page_btn.TabIndex = 4;
            last_page_btn.Text = "ສຸດທ້າຍ >>";
            last_page_btn.UseVisualStyleBackColor = false;
            // 
            // next_page_btn
            // 
            next_page_btn.BackColor = Color.LightGray;
            next_page_btn.Cursor = Cursors.Hand;
            next_page_btn.Dock = DockStyle.Fill;
            next_page_btn.FlatStyle = FlatStyle.Flat;
            next_page_btn.Font = new Font("Noto Sans Lao", 7.79999971F);
            next_page_btn.Location = new Point(583, 3);
            next_page_btn.Name = "next_page_btn";
            next_page_btn.Size = new Size(139, 35);
            next_page_btn.TabIndex = 3;
            next_page_btn.Text = "ຖັດໄປ >";
            next_page_btn.UseVisualStyleBackColor = false;
            // 
            // prev_page_btn
            // 
            prev_page_btn.BackColor = Color.LightGray;
            prev_page_btn.Cursor = Cursors.Hand;
            prev_page_btn.Dock = DockStyle.Fill;
            prev_page_btn.FlatStyle = FlatStyle.Flat;
            prev_page_btn.Font = new Font("Noto Sans Lao", 7.79999971F);
            prev_page_btn.Location = new Point(148, 3);
            prev_page_btn.Name = "prev_page_btn";
            prev_page_btn.Size = new Size(139, 35);
            prev_page_btn.TabIndex = 1;
            prev_page_btn.Text = "< ກັບຄືນ";
            prev_page_btn.UseVisualStyleBackColor = false;
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
            first_page_btn.Size = new Size(139, 35);
            first_page_btn.TabIndex = 0;
            first_page_btn.Text = "<< ທໍາອິດ";
            first_page_btn.UseVisualStyleBackColor = false;
            // 
            // page_lbl
            // 
            page_lbl.Dock = DockStyle.Fill;
            page_lbl.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            page_lbl.Location = new Point(293, 0);
            page_lbl.Name = "page_lbl";
            page_lbl.Size = new Size(139, 41);
            page_lbl.TabIndex = 2;
            page_lbl.Text = "1/1";
            page_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bottom_pn
            // 
            bottom_pn.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            bottom_pn.ColumnCount = 1;
            bottom_pn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            bottom_pn.Controls.Add(payment_report_dgv, 0, 1);
            bottom_pn.Controls.Add(filter_pn, 0, 0);
            bottom_pn.Dock = DockStyle.Fill;
            bottom_pn.Location = new Point(0, 252);
            bottom_pn.Name = "bottom_pn";
            bottom_pn.RowCount = 2;
            bottom_pn.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            bottom_pn.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            bottom_pn.Size = new Size(1627, 571);
            bottom_pn.TabIndex = 14;
            // 
            // payment_report_dgv
            // 
            payment_report_dgv.AllowUserToAddRows = false;
            payment_report_dgv.AllowUserToDeleteRows = false;
            payment_report_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            payment_report_dgv.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            payment_report_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            payment_report_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            payment_report_dgv.Dock = DockStyle.Fill;
            payment_report_dgv.Location = new Point(9, 110);
            payment_report_dgv.Margin = new Padding(8);
            payment_report_dgv.Name = "payment_report_dgv";
            payment_report_dgv.ReadOnly = true;
            payment_report_dgv.RowHeadersWidth = 10;
            payment_report_dgv.ScrollBars = ScrollBars.Vertical;
            payment_report_dgv.Size = new Size(1609, 452);
            payment_report_dgv.TabIndex = 0;
            // 
            // filter_pn
            // 
            filter_pn.Controls.Add(label4);
            filter_pn.Controls.Add(panel5);
            filter_pn.Controls.Add(export_btn);
            filter_pn.Controls.Add(panel2);
            filter_pn.Dock = DockStyle.Top;
            filter_pn.Location = new Point(4, 4);
            filter_pn.Name = "filter_pn";
            filter_pn.Size = new Size(1619, 90);
            filter_pn.TabIndex = 1;
            // 
            // label4
            // 
            label4.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 25);
            label4.Name = "label4";
            label4.Size = new Size(131, 40);
            label4.TabIndex = 7;
            label4.Text = "ຕົວເລຶອກຊ່ວງເວລາ";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(period_cbb);
            panel5.Location = new Point(160, 25);
            panel5.Name = "panel5";
            panel5.Size = new Size(204, 40);
            panel5.TabIndex = 6;
            // 
            // period_cbb
            // 
            period_cbb.FlatStyle = FlatStyle.Flat;
            period_cbb.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            period_cbb.FormattingEnabled = true;
            period_cbb.Items.AddRange(new object[] { "All", "User", "Admin" });
            period_cbb.Location = new Point(3, 1);
            period_cbb.Name = "period_cbb";
            period_cbb.Size = new Size(196, 36);
            period_cbb.TabIndex = 1;
            period_cbb.SelectedIndexChanged += period_cbb_SelectedIndexChanged;
            // 
            // export_btn
            // 
            export_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            export_btn.BackColor = Color.FromArgb(33, 52, 72);
            export_btn.Cursor = Cursors.Hand;
            export_btn.FlatStyle = FlatStyle.Flat;
            export_btn.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            export_btn.ForeColor = Color.White;
            export_btn.Location = new Point(1418, 16);
            export_btn.Name = "export_btn";
            export_btn.Size = new Size(180, 59);
            export_btn.TabIndex = 5;
            export_btn.Text = "Export to Excel";
            export_btn.UseVisualStyleBackColor = false;
            export_btn.Click += export_btn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(to_date_dpk);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(from_date_dpk);
            panel2.Location = new Point(394, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(422, 45);
            panel2.TabIndex = 2;
            // 
            // to_date_dpk
            // 
            to_date_dpk.CustomFormat = "dd/MM/yyyy";
            to_date_dpk.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            to_date_dpk.Format = DateTimePickerFormat.Custom;
            to_date_dpk.Location = new Point(262, 2);
            to_date_dpk.Name = "to_date_dpk";
            to_date_dpk.Size = new Size(157, 40);
            to_date_dpk.TabIndex = 4;
            to_date_dpk.ValueChanged += to_date_dpk_ValueChanged;
            // 
            // label3
            // 
            label3.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(163, 2);
            label3.Name = "label3";
            label3.Size = new Size(93, 40);
            label3.TabIndex = 3;
            label3.Text = "ຫາວັນທີ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // from_date_dpk
            // 
            from_date_dpk.CustomFormat = "dd/MM/yyyy";
            from_date_dpk.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            from_date_dpk.Format = DateTimePickerFormat.Custom;
            from_date_dpk.Location = new Point(0, 2);
            from_date_dpk.Name = "from_date_dpk";
            from_date_dpk.Size = new Size(157, 40);
            from_date_dpk.TabIndex = 1;
            from_date_dpk.ValueChanged += from_date_dpk_ValueChanged;
            // 
            // total_bank_lbl
            // 
            total_bank_lbl.Dock = DockStyle.Fill;
            total_bank_lbl.Font = new Font("Noto Sans", 13.7999992F, FontStyle.Bold);
            total_bank_lbl.ForeColor = Color.White;
            total_bank_lbl.Location = new Point(3, 50);
            total_bank_lbl.Name = "total_bank_lbl";
            total_bank_lbl.Size = new Size(214, 50);
            total_bank_lbl.TabIndex = 2;
            total_bank_lbl.Text = "0";
            total_bank_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Noto Sans Lao", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(214, 50);
            label8.TabIndex = 0;
            label8.Text = "ລວມໂອນ";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Noto Sans Lao", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(214, 50);
            label6.TabIndex = 0;
            label6.Text = "ຈຳນວນຈ່າຍແລ້ວ";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // discount_pn
            // 
            discount_pn.BackColor = Color.FromArgb(84, 119, 146);
            discount_pn.ColumnCount = 1;
            discount_pn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            discount_pn.Controls.Add(total_deposit_lbl, 0, 1);
            discount_pn.Controls.Add(label9, 0, 0);
            discount_pn.Location = new Point(931, 125);
            discount_pn.Name = "discount_pn";
            discount_pn.RowCount = 2;
            discount_pn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            discount_pn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            discount_pn.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            discount_pn.Size = new Size(220, 100);
            discount_pn.TabIndex = 7;
            // 
            // total_deposit_lbl
            // 
            total_deposit_lbl.Dock = DockStyle.Fill;
            total_deposit_lbl.Font = new Font("Noto Sans", 13.7999992F, FontStyle.Bold);
            total_deposit_lbl.ForeColor = Color.White;
            total_deposit_lbl.Location = new Point(3, 50);
            total_deposit_lbl.Name = "total_deposit_lbl";
            total_deposit_lbl.Size = new Size(214, 50);
            total_deposit_lbl.TabIndex = 2;
            total_deposit_lbl.Text = "0";
            total_deposit_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Noto Sans Lao", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(214, 50);
            label9.TabIndex = 0;
            label9.Text = "ລວມມັດຈຳ";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(back_btn);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(discount_pn);
            panel1.Controls.Add(paid_amount_pn);
            panel1.Controls.Add(aov_pn);
            panel1.Controls.Add(total_orders_pn);
            panel1.Controls.Add(gross_sales_pn);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1627, 252);
            panel1.TabIndex = 13;
            // 
            // back_btn
            // 
            back_btn.Cursor = Cursors.Hand;
            back_btn.FlatStyle = FlatStyle.Flat;
            back_btn.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            back_btn.Location = new Point(30, 27);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(94, 45);
            back_btn.TabIndex = 9;
            back_btn.Text = "ກັບຄືນ";
            back_btn.UseVisualStyleBackColor = true;
            back_btn.Click += back_btn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(84, 119, 146);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(total_avg_lbl, 0, 1);
            tableLayoutPanel1.Controls.Add(label11, 0, 0);
            tableLayoutPanel1.Location = new Point(1157, 125);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(220, 100);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // total_avg_lbl
            // 
            total_avg_lbl.Dock = DockStyle.Fill;
            total_avg_lbl.Font = new Font("Noto Sans", 13.7999992F, FontStyle.Bold);
            total_avg_lbl.ForeColor = Color.White;
            total_avg_lbl.Location = new Point(3, 50);
            total_avg_lbl.Name = "total_avg_lbl";
            total_avg_lbl.Size = new Size(214, 50);
            total_avg_lbl.TabIndex = 2;
            total_avg_lbl.Text = "0";
            total_avg_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.Dock = DockStyle.Fill;
            label11.Font = new Font("Noto Sans Lao", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(3, 0);
            label11.Name = "label11";
            label11.Size = new Size(214, 50);
            label11.TabIndex = 0;
            label11.Text = "ສະເລ່ຍ";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // paid_amount_pn
            // 
            paid_amount_pn.BackColor = Color.FromArgb(84, 119, 146);
            paid_amount_pn.ColumnCount = 1;
            paid_amount_pn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            paid_amount_pn.Controls.Add(total_bank_lbl, 0, 1);
            paid_amount_pn.Controls.Add(label8, 0, 0);
            paid_amount_pn.Location = new Point(705, 125);
            paid_amount_pn.Name = "paid_amount_pn";
            paid_amount_pn.RowCount = 2;
            paid_amount_pn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            paid_amount_pn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            paid_amount_pn.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            paid_amount_pn.Size = new Size(220, 100);
            paid_amount_pn.TabIndex = 6;
            // 
            // aov_pn
            // 
            aov_pn.BackColor = Color.FromArgb(84, 119, 146);
            aov_pn.ColumnCount = 1;
            aov_pn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            aov_pn.Controls.Add(total_cash_lbl, 0, 1);
            aov_pn.Controls.Add(label7, 0, 0);
            aov_pn.Location = new Point(479, 125);
            aov_pn.Name = "aov_pn";
            aov_pn.RowCount = 2;
            aov_pn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            aov_pn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            aov_pn.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            aov_pn.Size = new Size(220, 100);
            aov_pn.TabIndex = 5;
            // 
            // total_cash_lbl
            // 
            total_cash_lbl.Dock = DockStyle.Fill;
            total_cash_lbl.Font = new Font("Noto Sans", 13.7999992F, FontStyle.Bold);
            total_cash_lbl.ForeColor = Color.White;
            total_cash_lbl.Location = new Point(3, 50);
            total_cash_lbl.Name = "total_cash_lbl";
            total_cash_lbl.Size = new Size(214, 50);
            total_cash_lbl.TabIndex = 2;
            total_cash_lbl.Text = "0";
            total_cash_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Noto Sans Lao", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(214, 50);
            label7.TabIndex = 0;
            label7.Text = "ລວມເງິນສົດ";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // total_orders_pn
            // 
            total_orders_pn.BackColor = Color.FromArgb(84, 119, 146);
            total_orders_pn.ColumnCount = 1;
            total_orders_pn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            total_orders_pn.Controls.Add(total_paid_amount_lbl, 0, 1);
            total_orders_pn.Controls.Add(label6, 0, 0);
            total_orders_pn.Location = new Point(253, 125);
            total_orders_pn.Name = "total_orders_pn";
            total_orders_pn.RowCount = 2;
            total_orders_pn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            total_orders_pn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            total_orders_pn.Size = new Size(220, 100);
            total_orders_pn.TabIndex = 4;
            // 
            // total_paid_amount_lbl
            // 
            total_paid_amount_lbl.Dock = DockStyle.Fill;
            total_paid_amount_lbl.Font = new Font("Noto Sans", 13.7999992F, FontStyle.Bold);
            total_paid_amount_lbl.ForeColor = Color.White;
            total_paid_amount_lbl.Location = new Point(3, 50);
            total_paid_amount_lbl.Name = "total_paid_amount_lbl";
            total_paid_amount_lbl.Size = new Size(214, 50);
            total_paid_amount_lbl.TabIndex = 2;
            total_paid_amount_lbl.Text = "0";
            total_paid_amount_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PaymentTransactionReportUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(bottom_pn);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "PaymentTransactionReportUC";
            Size = new Size(1627, 898);
            Load += PaymentTransactionReportUC_Load;
            gross_sales_pn.ResumeLayout(false);
            panel3.ResumeLayout(false);
            pagination_pn.ResumeLayout(false);
            bottom_pn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)payment_report_dgv).EndInit();
            filter_pn.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            discount_pn.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            paid_amount_pn.ResumeLayout(false);
            aov_pn.ResumeLayout(false);
            total_orders_pn.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel gross_sales_pn;
        private Label total_transactions_lbl;
        private Label label2;
        private Label label1;
        private Panel panel3;
        private TableLayoutPanel pagination_pn;
        private ComboBox pagesize_cbb;
        private Button last_page_btn;
        private Button next_page_btn;
        private Button prev_page_btn;
        private Button first_page_btn;
        private Label page_lbl;
        private TableLayoutPanel bottom_pn;
        private DataGridView payment_report_dgv;
        private Panel filter_pn;
        private Label label4;
        private Panel panel5;
        private ComboBox period_cbb;
        private Button export_btn;
        private Panel panel2;
        private DateTimePicker to_date_dpk;
        private Label label3;
        private DateTimePicker from_date_dpk;
        private Label total_bank_lbl;
        private Label label8;
        private Label label6;
        private TableLayoutPanel discount_pn;
        private Label total_deposit_lbl;
        private Label label9;
        private Panel panel1;
        private TableLayoutPanel paid_amount_pn;
        private TableLayoutPanel aov_pn;
        private Label total_cash_lbl;
        private Label label7;
        private TableLayoutPanel total_orders_pn;
        private Label total_paid_amount_lbl;
        private TableLayoutPanel tableLayoutPanel1;
        private Label total_avg_lbl;
        private Label label11;
        private Button back_btn;
    }
}
