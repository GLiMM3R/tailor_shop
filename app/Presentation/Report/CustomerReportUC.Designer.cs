﻿namespace app.Presentation.Report
{
    partial class CustomerReportUC
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
            to_date_dpk = new DateTimePicker();
            from_date_dpk = new DateTimePicker();
            panel3 = new Panel();
            pagination_pn = new TableLayoutPanel();
            pagesize_cbb = new ComboBox();
            last_page_btn = new Button();
            next_page_btn = new Button();
            prev_page_btn = new Button();
            first_page_btn = new Button();
            page_lbl = new Label();
            total_orders_pn = new TableLayoutPanel();
            repeat_customers_lbl = new Label();
            label6 = new Label();
            net_sales_pn = new TableLayoutPanel();
            new_customers_lbl = new Label();
            label5 = new Label();
            bottom_pn = new TableLayoutPanel();
            customer_report_dgv = new DataGridView();
            filter_pn = new Panel();
            label10 = new Label();
            panel4 = new Panel();
            report_type_cbb = new ComboBox();
            label4 = new Label();
            panel5 = new Panel();
            period_cbb = new ComboBox();
            export_btn = new Button();
            panel2 = new Panel();
            label3 = new Label();
            gross_sales_pn = new TableLayoutPanel();
            total_customers_lbl = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            panel3.SuspendLayout();
            pagination_pn.SuspendLayout();
            total_orders_pn.SuspendLayout();
            net_sales_pn.SuspendLayout();
            bottom_pn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customer_report_dgv).BeginInit();
            filter_pn.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            gross_sales_pn.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
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
            // panel3
            // 
            panel3.Controls.Add(pagination_pn);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 819);
            panel3.Name = "panel3";
            panel3.Size = new Size(1504, 75);
            panel3.TabIndex = 3;
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
            pagination_pn.Location = new Point(391, 17);
            pagination_pn.Name = "pagination_pn";
            pagination_pn.RowCount = 1;
            pagination_pn.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pagination_pn.Size = new Size(723, 41);
            pagination_pn.TabIndex = 1;
            // 
            // pagesize_cbb
            // 
            pagesize_cbb.Dock = DockStyle.Fill;
            pagesize_cbb.FormattingEnabled = true;
            pagesize_cbb.Items.AddRange(new object[] { "10", "20", "30", "50", "100" });
            pagesize_cbb.Location = new Point(363, 3);
            pagesize_cbb.Name = "pagesize_cbb";
            pagesize_cbb.Size = new Size(114, 36);
            pagesize_cbb.TabIndex = 7;
            pagesize_cbb.Click += pagesize_cbb_SelectedIndexChanged;
            // 
            // last_page_btn
            // 
            last_page_btn.BackColor = Color.LightGray;
            last_page_btn.Cursor = Cursors.Hand;
            last_page_btn.Dock = DockStyle.Fill;
            last_page_btn.FlatStyle = FlatStyle.Flat;
            last_page_btn.Font = new Font("Noto Sans Lao", 7.79999971F);
            last_page_btn.Location = new Point(603, 3);
            last_page_btn.Name = "last_page_btn";
            last_page_btn.Size = new Size(117, 35);
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
            next_page_btn.Location = new Point(483, 3);
            next_page_btn.Name = "next_page_btn";
            next_page_btn.Size = new Size(114, 35);
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
            prev_page_btn.Location = new Point(123, 3);
            prev_page_btn.Name = "prev_page_btn";
            prev_page_btn.Size = new Size(114, 35);
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
            first_page_btn.Size = new Size(114, 35);
            first_page_btn.TabIndex = 0;
            first_page_btn.Text = "<< ທໍາອິດ";
            first_page_btn.UseVisualStyleBackColor = false;
            first_page_btn.Click += first_page_btn_Click;
            // 
            // page_lbl
            // 
            page_lbl.Dock = DockStyle.Fill;
            page_lbl.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            page_lbl.Location = new Point(243, 0);
            page_lbl.Name = "page_lbl";
            page_lbl.Size = new Size(114, 41);
            page_lbl.TabIndex = 2;
            page_lbl.Text = "1/1";
            page_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // total_orders_pn
            // 
            total_orders_pn.BackColor = Color.FromArgb(84, 119, 146);
            total_orders_pn.ColumnCount = 1;
            total_orders_pn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            total_orders_pn.Controls.Add(repeat_customers_lbl, 0, 1);
            total_orders_pn.Controls.Add(label6, 0, 0);
            total_orders_pn.Location = new Point(472, 125);
            total_orders_pn.Name = "total_orders_pn";
            total_orders_pn.RowCount = 2;
            total_orders_pn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            total_orders_pn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            total_orders_pn.Size = new Size(200, 100);
            total_orders_pn.TabIndex = 4;
            // 
            // repeat_customers_lbl
            // 
            repeat_customers_lbl.Dock = DockStyle.Fill;
            repeat_customers_lbl.Font = new Font("Noto Sans", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            repeat_customers_lbl.ForeColor = Color.White;
            repeat_customers_lbl.Location = new Point(3, 50);
            repeat_customers_lbl.Name = "repeat_customers_lbl";
            repeat_customers_lbl.Size = new Size(194, 50);
            repeat_customers_lbl.TabIndex = 2;
            repeat_customers_lbl.Text = "0";
            repeat_customers_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Noto Sans Lao", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(194, 50);
            label6.TabIndex = 0;
            label6.Text = "ລູກຄ້າປະຈຳ";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // net_sales_pn
            // 
            net_sales_pn.BackColor = Color.FromArgb(84, 119, 146);
            net_sales_pn.ColumnCount = 1;
            net_sales_pn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            net_sales_pn.Controls.Add(new_customers_lbl, 0, 1);
            net_sales_pn.Controls.Add(label5, 0, 0);
            net_sales_pn.Location = new Point(249, 125);
            net_sales_pn.Name = "net_sales_pn";
            net_sales_pn.RowCount = 2;
            net_sales_pn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            net_sales_pn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            net_sales_pn.Size = new Size(200, 100);
            net_sales_pn.TabIndex = 3;
            // 
            // new_customers_lbl
            // 
            new_customers_lbl.Dock = DockStyle.Fill;
            new_customers_lbl.Font = new Font("Noto Sans", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            new_customers_lbl.ForeColor = Color.White;
            new_customers_lbl.Location = new Point(3, 50);
            new_customers_lbl.Name = "new_customers_lbl";
            new_customers_lbl.Size = new Size(194, 50);
            new_customers_lbl.TabIndex = 2;
            new_customers_lbl.Text = "0";
            new_customers_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Noto Sans Lao", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(194, 50);
            label5.TabIndex = 0;
            label5.Text = "ລູກຄ້າໃໝ່";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bottom_pn
            // 
            bottom_pn.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            bottom_pn.ColumnCount = 1;
            bottom_pn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            bottom_pn.Controls.Add(customer_report_dgv, 0, 1);
            bottom_pn.Controls.Add(filter_pn, 0, 0);
            bottom_pn.Dock = DockStyle.Fill;
            bottom_pn.Location = new Point(0, 252);
            bottom_pn.Name = "bottom_pn";
            bottom_pn.RowCount = 2;
            bottom_pn.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            bottom_pn.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            bottom_pn.Size = new Size(1504, 567);
            bottom_pn.TabIndex = 5;
            // 
            // customer_report_dgv
            // 
            customer_report_dgv.AllowUserToAddRows = false;
            customer_report_dgv.AllowUserToDeleteRows = false;
            customer_report_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            customer_report_dgv.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            customer_report_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            customer_report_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customer_report_dgv.Dock = DockStyle.Fill;
            customer_report_dgv.Location = new Point(9, 110);
            customer_report_dgv.Margin = new Padding(8);
            customer_report_dgv.Name = "customer_report_dgv";
            customer_report_dgv.ReadOnly = true;
            customer_report_dgv.RowHeadersWidth = 10;
            customer_report_dgv.ScrollBars = ScrollBars.Vertical;
            customer_report_dgv.Size = new Size(1486, 448);
            customer_report_dgv.TabIndex = 0;
            // 
            // filter_pn
            // 
            filter_pn.Controls.Add(label10);
            filter_pn.Controls.Add(panel4);
            filter_pn.Controls.Add(label4);
            filter_pn.Controls.Add(panel5);
            filter_pn.Controls.Add(export_btn);
            filter_pn.Controls.Add(panel2);
            filter_pn.Dock = DockStyle.Top;
            filter_pn.Location = new Point(4, 4);
            filter_pn.Name = "filter_pn";
            filter_pn.Size = new Size(1496, 90);
            filter_pn.TabIndex = 1;
            // 
            // label10
            // 
            label10.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(6, 23);
            label10.Name = "label10";
            label10.Size = new Size(131, 40);
            label10.TabIndex = 9;
            label10.Text = "ປະເພດລາຍງານ";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(report_type_cbb);
            panel4.Location = new Point(143, 23);
            panel4.Name = "panel4";
            panel4.Size = new Size(204, 40);
            panel4.TabIndex = 8;
            // 
            // report_type_cbb
            // 
            report_type_cbb.FlatStyle = FlatStyle.Flat;
            report_type_cbb.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            report_type_cbb.FormattingEnabled = true;
            report_type_cbb.Location = new Point(3, 1);
            report_type_cbb.Name = "report_type_cbb";
            report_type_cbb.Size = new Size(196, 36);
            report_type_cbb.TabIndex = 1;
            report_type_cbb.SelectedIndexChanged += report_type_cbb_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(353, 25);
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
            panel5.Location = new Point(490, 25);
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
            export_btn.Location = new Point(1287, 16);
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
            panel2.Location = new Point(724, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(422, 45);
            panel2.TabIndex = 2;
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
            // gross_sales_pn
            // 
            gross_sales_pn.BackColor = Color.FromArgb(84, 119, 146);
            gross_sales_pn.ColumnCount = 1;
            gross_sales_pn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            gross_sales_pn.Controls.Add(total_customers_lbl, 0, 1);
            gross_sales_pn.Controls.Add(label2, 0, 0);
            gross_sales_pn.Location = new Point(27, 125);
            gross_sales_pn.Name = "gross_sales_pn";
            gross_sales_pn.RowCount = 2;
            gross_sales_pn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            gross_sales_pn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            gross_sales_pn.Size = new Size(200, 100);
            gross_sales_pn.TabIndex = 2;
            // 
            // total_customers_lbl
            // 
            total_customers_lbl.Dock = DockStyle.Fill;
            total_customers_lbl.Font = new Font("Noto Sans", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total_customers_lbl.ForeColor = Color.White;
            total_customers_lbl.Location = new Point(3, 50);
            total_customers_lbl.Name = "total_customers_lbl";
            total_customers_lbl.Size = new Size(194, 50);
            total_customers_lbl.TabIndex = 2;
            total_customers_lbl.Text = "0";
            total_customers_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Noto Sans Lao", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(194, 50);
            label2.TabIndex = 0;
            label2.Text = "ຈຳນວນລູກຄ້າ";
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
            label1.Size = new Size(1504, 94);
            label1.TabIndex = 0;
            label1.Text = "ລາຍງານລູກຄ້າ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(total_orders_pn);
            panel1.Controls.Add(net_sales_pn);
            panel1.Controls.Add(gross_sales_pn);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1504, 252);
            panel1.TabIndex = 4;
            // 
            // CustomerReportUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(bottom_pn);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "CustomerReportUC";
            Size = new Size(1504, 894);
            Load += CustomerReportUC_Load;
            panel3.ResumeLayout(false);
            pagination_pn.ResumeLayout(false);
            total_orders_pn.ResumeLayout(false);
            net_sales_pn.ResumeLayout(false);
            bottom_pn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)customer_report_dgv).EndInit();
            filter_pn.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            gross_sales_pn.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker to_date_dpk;
        private DateTimePicker from_date_dpk;
        private Panel panel3;
        private TableLayoutPanel pagination_pn;
        private ComboBox pagesize_cbb;
        private Button last_page_btn;
        private Button next_page_btn;
        private Button prev_page_btn;
        private Button first_page_btn;
        private Label page_lbl;
        private TableLayoutPanel total_orders_pn;
        private Label repeat_customers_lbl;
        private Label label6;
        private TableLayoutPanel net_sales_pn;
        private Label new_customers_lbl;
        private Label label5;
        private TableLayoutPanel bottom_pn;
        private DataGridView customer_report_dgv;
        private Panel filter_pn;
        private Label label4;
        private Panel panel5;
        private ComboBox period_cbb;
        private Button export_btn;
        private Panel panel2;
        private Label label3;
        private TableLayoutPanel gross_sales_pn;
        private Label total_customers_lbl;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label label10;
        private Panel panel4;
        private ComboBox report_type_cbb;
    }
}
