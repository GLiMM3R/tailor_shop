namespace app.Presentation.Report
{
    partial class SaleReportUC
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
            label1 = new Label();
            in_progress_lbl = new Label();
            label5 = new Label();
            bottom_pn = new TableLayoutPanel();
            sale_report_dgv = new DataGridView();
            filter_pn = new Panel();
            search_pn = new Panel();
            search_txt = new TextBox();
            label4 = new Label();
            panel5 = new Panel();
            period_cbb = new ComboBox();
            export_btn = new Button();
            panel2 = new Panel();
            to_date_dpk = new DateTimePicker();
            label3 = new Label();
            from_date_dpk = new DateTimePicker();
            gross_sales_pn = new TableLayoutPanel();
            total_orders_lbl = new Label();
            label2 = new Label();
            net_sales_pn = new TableLayoutPanel();
            panel1 = new Panel();
            back_btn = new Button();
            paid_amount_pn = new TableLayoutPanel();
            canceled_lbl = new Label();
            label8 = new Label();
            aov_pn = new TableLayoutPanel();
            pick_up_lbl = new Label();
            label7 = new Label();
            total_orders_pn = new TableLayoutPanel();
            complete_lbl = new Label();
            label6 = new Label();
            panel3 = new Panel();
            pagination_pn = new TableLayoutPanel();
            pagesize_cbb = new ComboBox();
            last_page_btn = new Button();
            next_page_btn = new Button();
            prev_page_btn = new Button();
            first_page_btn = new Button();
            page_lbl = new Label();
            bottom_pn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sale_report_dgv).BeginInit();
            filter_pn.SuspendLayout();
            search_pn.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            gross_sales_pn.SuspendLayout();
            net_sales_pn.SuspendLayout();
            panel1.SuspendLayout();
            paid_amount_pn.SuspendLayout();
            aov_pn.SuspendLayout();
            total_orders_pn.SuspendLayout();
            panel3.SuspendLayout();
            pagination_pn.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(33, 52, 72);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Noto Sans Lao", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1510, 94);
            label1.TabIndex = 0;
            label1.Text = "ລາຍງານການສັ່ງຕັດ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // in_progress_lbl
            // 
            in_progress_lbl.Dock = DockStyle.Fill;
            in_progress_lbl.Font = new Font("Noto Sans", 13.7999992F, FontStyle.Bold);
            in_progress_lbl.ForeColor = Color.White;
            in_progress_lbl.Location = new Point(3, 50);
            in_progress_lbl.Name = "in_progress_lbl";
            in_progress_lbl.Size = new Size(214, 50);
            in_progress_lbl.TabIndex = 2;
            in_progress_lbl.Text = "0";
            in_progress_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Noto Sans Lao", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(214, 50);
            label5.TabIndex = 0;
            label5.Text = "ກຳລັງເຮັດ";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bottom_pn
            // 
            bottom_pn.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            bottom_pn.ColumnCount = 1;
            bottom_pn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            bottom_pn.Controls.Add(sale_report_dgv, 0, 1);
            bottom_pn.Controls.Add(filter_pn, 0, 0);
            bottom_pn.Dock = DockStyle.Fill;
            bottom_pn.Location = new Point(0, 252);
            bottom_pn.Name = "bottom_pn";
            bottom_pn.RowCount = 2;
            bottom_pn.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            bottom_pn.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            bottom_pn.Size = new Size(1510, 562);
            bottom_pn.TabIndex = 8;
            // 
            // sale_report_dgv
            // 
            sale_report_dgv.AllowUserToAddRows = false;
            sale_report_dgv.AllowUserToDeleteRows = false;
            sale_report_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            sale_report_dgv.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            sale_report_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            sale_report_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sale_report_dgv.Dock = DockStyle.Fill;
            sale_report_dgv.Location = new Point(9, 110);
            sale_report_dgv.Margin = new Padding(8);
            sale_report_dgv.Name = "sale_report_dgv";
            sale_report_dgv.ReadOnly = true;
            sale_report_dgv.RowHeadersWidth = 10;
            sale_report_dgv.ScrollBars = ScrollBars.Vertical;
            sale_report_dgv.Size = new Size(1492, 443);
            sale_report_dgv.TabIndex = 0;
            // 
            // filter_pn
            // 
            filter_pn.Controls.Add(search_pn);
            filter_pn.Controls.Add(label4);
            filter_pn.Controls.Add(panel5);
            filter_pn.Controls.Add(export_btn);
            filter_pn.Controls.Add(panel2);
            filter_pn.Dock = DockStyle.Top;
            filter_pn.Location = new Point(4, 4);
            filter_pn.Name = "filter_pn";
            filter_pn.Size = new Size(1502, 90);
            filter_pn.TabIndex = 1;
            // 
            // search_pn
            // 
            search_pn.BorderStyle = BorderStyle.FixedSingle;
            search_pn.Controls.Add(search_txt);
            search_pn.Location = new Point(25, 22);
            search_pn.Name = "search_pn";
            search_pn.Size = new Size(275, 47);
            search_pn.TabIndex = 8;
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
            // label4
            // 
            label4.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(336, 25);
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
            panel5.Location = new Point(473, 25);
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
            export_btn.Location = new Point(1301, 14);
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
            panel2.Location = new Point(712, 23);
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
            // gross_sales_pn
            // 
            gross_sales_pn.BackColor = Color.FromArgb(84, 119, 146);
            gross_sales_pn.ColumnCount = 1;
            gross_sales_pn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            gross_sales_pn.Controls.Add(total_orders_lbl, 0, 1);
            gross_sales_pn.Controls.Add(label2, 0, 0);
            gross_sales_pn.Location = new Point(26, 125);
            gross_sales_pn.Name = "gross_sales_pn";
            gross_sales_pn.RowCount = 2;
            gross_sales_pn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            gross_sales_pn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            gross_sales_pn.Size = new Size(220, 100);
            gross_sales_pn.TabIndex = 2;
            // 
            // total_orders_lbl
            // 
            total_orders_lbl.Dock = DockStyle.Fill;
            total_orders_lbl.Font = new Font("Noto Sans", 13.7999992F, FontStyle.Bold);
            total_orders_lbl.ForeColor = Color.White;
            total_orders_lbl.Location = new Point(3, 50);
            total_orders_lbl.Name = "total_orders_lbl";
            total_orders_lbl.Size = new Size(214, 50);
            total_orders_lbl.TabIndex = 2;
            total_orders_lbl.Text = "0";
            total_orders_lbl.TextAlign = ContentAlignment.MiddleCenter;
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
            label2.Text = "ຈຳນວນສັ່ງຕັດ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // net_sales_pn
            // 
            net_sales_pn.BackColor = Color.FromArgb(84, 119, 146);
            net_sales_pn.ColumnCount = 1;
            net_sales_pn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            net_sales_pn.Controls.Add(in_progress_lbl, 0, 1);
            net_sales_pn.Controls.Add(label5, 0, 0);
            net_sales_pn.Location = new Point(249, 125);
            net_sales_pn.Name = "net_sales_pn";
            net_sales_pn.RowCount = 2;
            net_sales_pn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            net_sales_pn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            net_sales_pn.Size = new Size(220, 100);
            net_sales_pn.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(back_btn);
            panel1.Controls.Add(paid_amount_pn);
            panel1.Controls.Add(aov_pn);
            panel1.Controls.Add(total_orders_pn);
            panel1.Controls.Add(net_sales_pn);
            panel1.Controls.Add(gross_sales_pn);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1510, 252);
            panel1.TabIndex = 7;
            // 
            // back_btn
            // 
            back_btn.Cursor = Cursors.Hand;
            back_btn.FlatStyle = FlatStyle.Flat;
            back_btn.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            back_btn.Location = new Point(30, 27);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(94, 45);
            back_btn.TabIndex = 10;
            back_btn.Text = "ກັບຄືນ";
            back_btn.UseVisualStyleBackColor = true;
            back_btn.Click += back_btn_Click;
            // 
            // paid_amount_pn
            // 
            paid_amount_pn.BackColor = Color.FromArgb(84, 119, 146);
            paid_amount_pn.ColumnCount = 1;
            paid_amount_pn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            paid_amount_pn.Controls.Add(canceled_lbl, 0, 1);
            paid_amount_pn.Controls.Add(label8, 0, 0);
            paid_amount_pn.Location = new Point(921, 125);
            paid_amount_pn.Name = "paid_amount_pn";
            paid_amount_pn.RowCount = 2;
            paid_amount_pn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            paid_amount_pn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            paid_amount_pn.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            paid_amount_pn.Size = new Size(220, 100);
            paid_amount_pn.TabIndex = 6;
            // 
            // canceled_lbl
            // 
            canceled_lbl.Dock = DockStyle.Fill;
            canceled_lbl.Font = new Font("Noto Sans", 13.7999992F, FontStyle.Bold);
            canceled_lbl.ForeColor = Color.White;
            canceled_lbl.Location = new Point(3, 50);
            canceled_lbl.Name = "canceled_lbl";
            canceled_lbl.Size = new Size(214, 50);
            canceled_lbl.TabIndex = 2;
            canceled_lbl.Text = "0";
            canceled_lbl.TextAlign = ContentAlignment.MiddleCenter;
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
            label8.Text = "ຍົກເລີກ";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // aov_pn
            // 
            aov_pn.BackColor = Color.FromArgb(84, 119, 146);
            aov_pn.ColumnCount = 1;
            aov_pn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            aov_pn.Controls.Add(pick_up_lbl, 0, 1);
            aov_pn.Controls.Add(label7, 0, 0);
            aov_pn.Location = new Point(696, 125);
            aov_pn.Name = "aov_pn";
            aov_pn.RowCount = 2;
            aov_pn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            aov_pn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            aov_pn.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            aov_pn.Size = new Size(220, 100);
            aov_pn.TabIndex = 5;
            // 
            // pick_up_lbl
            // 
            pick_up_lbl.Dock = DockStyle.Fill;
            pick_up_lbl.Font = new Font("Noto Sans", 13.7999992F, FontStyle.Bold);
            pick_up_lbl.ForeColor = Color.White;
            pick_up_lbl.Location = new Point(3, 50);
            pick_up_lbl.Name = "pick_up_lbl";
            pick_up_lbl.Size = new Size(214, 50);
            pick_up_lbl.TabIndex = 2;
            pick_up_lbl.Text = "0";
            pick_up_lbl.TextAlign = ContentAlignment.MiddleCenter;
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
            label7.Text = "ຮັບແລ້ວ";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // total_orders_pn
            // 
            total_orders_pn.BackColor = Color.FromArgb(84, 119, 146);
            total_orders_pn.ColumnCount = 1;
            total_orders_pn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            total_orders_pn.Controls.Add(complete_lbl, 0, 1);
            total_orders_pn.Controls.Add(label6, 0, 0);
            total_orders_pn.Location = new Point(472, 125);
            total_orders_pn.Name = "total_orders_pn";
            total_orders_pn.RowCount = 2;
            total_orders_pn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            total_orders_pn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            total_orders_pn.Size = new Size(220, 100);
            total_orders_pn.TabIndex = 4;
            // 
            // complete_lbl
            // 
            complete_lbl.Dock = DockStyle.Fill;
            complete_lbl.Font = new Font("Noto Sans", 13.7999992F, FontStyle.Bold);
            complete_lbl.ForeColor = Color.White;
            complete_lbl.Location = new Point(3, 50);
            complete_lbl.Name = "complete_lbl";
            complete_lbl.Size = new Size(214, 50);
            complete_lbl.TabIndex = 2;
            complete_lbl.Text = "0";
            complete_lbl.TextAlign = ContentAlignment.MiddleCenter;
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
            label6.Text = "ສຳເລັດ";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(pagination_pn);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 814);
            panel3.Name = "panel3";
            panel3.Size = new Size(1510, 75);
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
            pagination_pn.Location = new Point(394, 17);
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
            // SaleReportUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(bottom_pn);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "SaleReportUC";
            Size = new Size(1510, 889);
            Load += SaleReportUC_Load;
            bottom_pn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sale_report_dgv).EndInit();
            filter_pn.ResumeLayout(false);
            search_pn.ResumeLayout(false);
            search_pn.PerformLayout();
            panel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            gross_sales_pn.ResumeLayout(false);
            net_sales_pn.ResumeLayout(false);
            panel1.ResumeLayout(false);
            paid_amount_pn.ResumeLayout(false);
            aov_pn.ResumeLayout(false);
            total_orders_pn.ResumeLayout(false);
            panel3.ResumeLayout(false);
            pagination_pn.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label in_progress_lbl;
        private Label label5;
        private TableLayoutPanel bottom_pn;
        private DataGridView sale_report_dgv;
        private Panel filter_pn;
        private Label label4;
        private Panel panel5;
        private ComboBox period_cbb;
        private Button export_btn;
        private Panel panel2;
        private DateTimePicker to_date_dpk;
        private Label label3;
        private DateTimePicker from_date_dpk;
        private TableLayoutPanel gross_sales_pn;
        private Label total_orders_lbl;
        private Label label2;
        private TableLayoutPanel net_sales_pn;
        private Panel panel1;
        private TableLayoutPanel paid_amount_pn;
        private Label canceled_lbl;
        private Label label8;
        private TableLayoutPanel aov_pn;
        private Label pick_up_lbl;
        private Label label7;
        private TableLayoutPanel total_orders_pn;
        private Label complete_lbl;
        private Label label6;
        private Panel panel3;
        private TableLayoutPanel pagination_pn;
        private ComboBox pagesize_cbb;
        private Button last_page_btn;
        private Button next_page_btn;
        private Button prev_page_btn;
        private Button first_page_btn;
        private Label page_lbl;
        private Panel search_pn;
        private TextBox search_txt;
        private Button back_btn;
    }
}
