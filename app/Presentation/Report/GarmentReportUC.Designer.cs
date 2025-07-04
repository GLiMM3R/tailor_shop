﻿namespace app.Presentation.Report
{
    partial class GarmentReportUC
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
            label6 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            total_orders_pn = new TableLayoutPanel();
            total_values_lbl = new Label();
            gross_sales_pn = new TableLayoutPanel();
            total_garments_lbl = new Label();
            label1 = new Label();
            panel3 = new Panel();
            pagination_pn = new TableLayoutPanel();
            pagesize_cbb = new ComboBox();
            last_page_btn = new Button();
            next_page_btn = new Button();
            prev_page_btn = new Button();
            first_page_btn = new Button();
            page_lbl = new Label();
            from_date_dpk = new DateTimePicker();
            bottom_pn = new TableLayoutPanel();
            garment_report_dgv = new DataGridView();
            filter_pn = new Panel();
            label10 = new Label();
            panel4 = new Panel();
            report_type_cbb = new ComboBox();
            label4 = new Label();
            panel5 = new Panel();
            period_cbb = new ComboBox();
            export_btn = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            total_orders_pn.SuspendLayout();
            gross_sales_pn.SuspendLayout();
            panel3.SuspendLayout();
            pagination_pn.SuspendLayout();
            bottom_pn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)garment_report_dgv).BeginInit();
            filter_pn.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
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
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Noto Sans Lao", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(214, 50);
            label6.TabIndex = 0;
            label6.Text = "ລວມມູນຄ່າ";
            label6.TextAlign = ContentAlignment.MiddleCenter;
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
            label2.Text = "ຈຳນວນເສື້ອຜ້າ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
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
            // panel1
            // 
            panel1.Controls.Add(total_orders_pn);
            panel1.Controls.Add(gross_sales_pn);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1486, 252);
            panel1.TabIndex = 10;
            // 
            // total_orders_pn
            // 
            total_orders_pn.BackColor = Color.FromArgb(84, 119, 146);
            total_orders_pn.ColumnCount = 1;
            total_orders_pn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            total_orders_pn.Controls.Add(total_values_lbl, 0, 1);
            total_orders_pn.Controls.Add(label6, 0, 0);
            total_orders_pn.Location = new Point(252, 125);
            total_orders_pn.Name = "total_orders_pn";
            total_orders_pn.RowCount = 2;
            total_orders_pn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            total_orders_pn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            total_orders_pn.Size = new Size(220, 100);
            total_orders_pn.TabIndex = 4;
            // 
            // total_values_lbl
            // 
            total_values_lbl.Dock = DockStyle.Fill;
            total_values_lbl.Font = new Font("Noto Sans", 13.7999992F, FontStyle.Bold);
            total_values_lbl.ForeColor = Color.White;
            total_values_lbl.Location = new Point(3, 50);
            total_values_lbl.Name = "total_values_lbl";
            total_values_lbl.Size = new Size(214, 50);
            total_values_lbl.TabIndex = 2;
            total_values_lbl.Text = "0";
            total_values_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gross_sales_pn
            // 
            gross_sales_pn.BackColor = Color.FromArgb(84, 119, 146);
            gross_sales_pn.ColumnCount = 1;
            gross_sales_pn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            gross_sales_pn.Controls.Add(total_garments_lbl, 0, 1);
            gross_sales_pn.Controls.Add(label2, 0, 0);
            gross_sales_pn.Location = new Point(27, 125);
            gross_sales_pn.Name = "gross_sales_pn";
            gross_sales_pn.RowCount = 2;
            gross_sales_pn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            gross_sales_pn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            gross_sales_pn.Size = new Size(220, 100);
            gross_sales_pn.TabIndex = 2;
            // 
            // total_garments_lbl
            // 
            total_garments_lbl.Dock = DockStyle.Fill;
            total_garments_lbl.Font = new Font("Noto Sans", 13.7999992F, FontStyle.Bold);
            total_garments_lbl.ForeColor = Color.White;
            total_garments_lbl.Location = new Point(3, 50);
            total_garments_lbl.Name = "total_garments_lbl";
            total_garments_lbl.Size = new Size(214, 50);
            total_garments_lbl.TabIndex = 3;
            total_garments_lbl.Text = "0";
            total_garments_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(33, 52, 72);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Noto Sans Lao", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1486, 94);
            label1.TabIndex = 0;
            label1.Text = "ລາຍງານເສື້ອຜ້າ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(pagination_pn);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 833);
            panel3.Name = "panel3";
            panel3.Size = new Size(1486, 75);
            panel3.TabIndex = 9;
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
            pagination_pn.Location = new Point(370, 17);
            pagination_pn.Name = "pagination_pn";
            pagination_pn.RowCount = 1;
            pagination_pn.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pagination_pn.Size = new Size(746, 41);
            pagination_pn.TabIndex = 1;
            // 
            // pagesize_cbb
            // 
            pagesize_cbb.Dock = DockStyle.Fill;
            pagesize_cbb.FormattingEnabled = true;
            pagesize_cbb.Items.AddRange(new object[] { "10", "20", "30", "50", "100" });
            pagesize_cbb.Location = new Point(375, 3);
            pagesize_cbb.Name = "pagesize_cbb";
            pagesize_cbb.Size = new Size(118, 36);
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
            last_page_btn.Location = new Point(623, 3);
            last_page_btn.Name = "last_page_btn";
            last_page_btn.Size = new Size(120, 35);
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
            next_page_btn.Location = new Point(499, 3);
            next_page_btn.Name = "next_page_btn";
            next_page_btn.Size = new Size(118, 35);
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
            prev_page_btn.Location = new Point(127, 3);
            prev_page_btn.Name = "prev_page_btn";
            prev_page_btn.Size = new Size(118, 35);
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
            first_page_btn.Size = new Size(118, 35);
            first_page_btn.TabIndex = 0;
            first_page_btn.Text = "<< ທໍາອິດ";
            first_page_btn.UseVisualStyleBackColor = false;
            first_page_btn.Click += first_page_btn_Click;
            // 
            // page_lbl
            // 
            page_lbl.Dock = DockStyle.Fill;
            page_lbl.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            page_lbl.Location = new Point(251, 0);
            page_lbl.Name = "page_lbl";
            page_lbl.Size = new Size(118, 41);
            page_lbl.TabIndex = 2;
            page_lbl.Text = "1/1";
            page_lbl.TextAlign = ContentAlignment.MiddleCenter;
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
            // bottom_pn
            // 
            bottom_pn.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            bottom_pn.ColumnCount = 1;
            bottom_pn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            bottom_pn.Controls.Add(garment_report_dgv, 0, 1);
            bottom_pn.Controls.Add(filter_pn, 0, 0);
            bottom_pn.Dock = DockStyle.Fill;
            bottom_pn.Location = new Point(0, 252);
            bottom_pn.Name = "bottom_pn";
            bottom_pn.RowCount = 2;
            bottom_pn.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            bottom_pn.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            bottom_pn.Size = new Size(1486, 581);
            bottom_pn.TabIndex = 11;
            // 
            // garment_report_dgv
            // 
            garment_report_dgv.AllowUserToAddRows = false;
            garment_report_dgv.AllowUserToDeleteRows = false;
            garment_report_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            garment_report_dgv.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            garment_report_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            garment_report_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            garment_report_dgv.Dock = DockStyle.Fill;
            garment_report_dgv.Location = new Point(9, 110);
            garment_report_dgv.Margin = new Padding(8);
            garment_report_dgv.Name = "garment_report_dgv";
            garment_report_dgv.ReadOnly = true;
            garment_report_dgv.RowHeadersWidth = 10;
            garment_report_dgv.ScrollBars = ScrollBars.Vertical;
            garment_report_dgv.Size = new Size(1468, 462);
            garment_report_dgv.TabIndex = 0;
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
            filter_pn.Size = new Size(1478, 90);
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
            export_btn.Location = new Point(1273, 18);
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
            // GarmentReportUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(bottom_pn);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "GarmentReportUC";
            Size = new Size(1486, 908);
            Load += GarmentReportUC_Load;
            panel1.ResumeLayout(false);
            total_orders_pn.ResumeLayout(false);
            gross_sales_pn.ResumeLayout(false);
            panel3.ResumeLayout(false);
            pagination_pn.ResumeLayout(false);
            bottom_pn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)garment_report_dgv).EndInit();
            filter_pn.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label paid_amount_lbl;
        private DateTimePicker to_date_dpk;
        private Label label8;
        private Label label6;
        private Label total_customers_lbl;
        private TableLayoutPanel discount_pn;
        private Label discount_lbl;
        private Label label9;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private TableLayoutPanel paid_amount_pn;
        private TableLayoutPanel aov_pn;
        private Label aov_lbl;
        private Label label7;
        private TableLayoutPanel total_orders_pn;
        private Label total_values_lbl;
        private TableLayoutPanel net_sales_pn;
        private Label net_sales_lbl;
        private Label label5;
        private TableLayoutPanel gross_sales_pn;
        private Label label1;
        private Panel panel3;
        private TableLayoutPanel pagination_pn;
        private ComboBox pagesize_cbb;
        private Button last_page_btn;
        private Button next_page_btn;
        private Button prev_page_btn;
        private Button first_page_btn;
        private Label page_lbl;
        private DateTimePicker from_date_dpk;
        private TableLayoutPanel bottom_pn;
        private DataGridView garment_report_dgv;
        private Panel filter_pn;
        private Label label10;
        private Panel panel4;
        private ComboBox report_type_cbb;
        private Label label4;
        private Panel panel5;
        private ComboBox period_cbb;
        private Button export_btn;
        private Panel panel2;
        private Label total_garments_lbl;
    }
}
