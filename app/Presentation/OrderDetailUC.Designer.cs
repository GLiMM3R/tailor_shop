namespace app.Presentation
{
    partial class OrderDetailUC
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
            measurement_pn = new Panel();
            order_items_dgv = new DataGridView();
            label4 = new Label();
            bottom_pn = new Panel();
            label13 = new Label();
            summary_pn = new Panel();
            line = new Panel();
            label16 = new Label();
            amount_to_be_paid_lbl = new Label();
            discount_lb = new Label();
            label12 = new Label();
            deposit_amount_val_lb = new Label();
            deposit_amount_lb = new Label();
            label7 = new Label();
            label9 = new Label();
            total_amount_lb = new Label();
            label11 = new Label();
            subtotal_val_lb = new Label();
            subtotal_title_lb = new Label();
            notes_txt = new TextBox();
            summary_and_note_lb = new Label();
            action_pn = new Panel();
            print_invoice_btn = new Button();
            pay_btn = new Button();
            pick_up_btn = new Button();
            root_layout = new Panel();
            order_detail_pn = new Panel();
            information_gb = new GroupBox();
            status_cbb = new ComboBox();
            garment_lb = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            label21 = new Label();
            order_date_lbl = new Label();
            label23 = new Label();
            due_date_lbl = new Label();
            label25 = new Label();
            pick_up_date_lbl = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label5 = new Label();
            customer_name_lbl = new Label();
            label3 = new Label();
            order_number_lbl = new Label();
            label2 = new Label();
            customer_phone_lbl = new Label();
            header_pn = new Panel();
            back_btn = new Button();
            measurement_pn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)order_items_dgv).BeginInit();
            bottom_pn.SuspendLayout();
            summary_pn.SuspendLayout();
            action_pn.SuspendLayout();
            root_layout.SuspendLayout();
            order_detail_pn.SuspendLayout();
            information_gb.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            header_pn.SuspendLayout();
            SuspendLayout();
            // 
            // measurement_pn
            // 
            measurement_pn.BackColor = Color.White;
            measurement_pn.Controls.Add(order_items_dgv);
            measurement_pn.Controls.Add(label4);
            measurement_pn.Dock = DockStyle.Fill;
            measurement_pn.Location = new Point(0, 277);
            measurement_pn.Margin = new Padding(0);
            measurement_pn.Name = "measurement_pn";
            measurement_pn.Padding = new Padding(8, 16, 8, 4);
            measurement_pn.Size = new Size(1546, 311);
            measurement_pn.TabIndex = 2;
            // 
            // order_items_dgv
            // 
            order_items_dgv.AllowUserToAddRows = false;
            order_items_dgv.AllowUserToDeleteRows = false;
            order_items_dgv.AllowUserToResizeColumns = false;
            order_items_dgv.AllowUserToResizeRows = false;
            order_items_dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            order_items_dgv.BackgroundColor = Color.White;
            order_items_dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
            order_items_dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            order_items_dgv.ColumnHeadersHeight = 48;
            order_items_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            order_items_dgv.Location = new Point(8, 52);
            order_items_dgv.MultiSelect = false;
            order_items_dgv.Name = "order_items_dgv";
            order_items_dgv.ReadOnly = true;
            order_items_dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            order_items_dgv.RowHeadersVisible = false;
            order_items_dgv.RowHeadersWidth = 51;
            order_items_dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            order_items_dgv.RowTemplate.Height = 50;
            order_items_dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            order_items_dgv.Size = new Size(1527, 259);
            order_items_dgv.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 16);
            label4.Name = "label4";
            label4.Size = new Size(79, 33);
            label4.TabIndex = 2;
            label4.Text = "ລາຍການ";
            // 
            // bottom_pn
            // 
            bottom_pn.BackColor = Color.White;
            bottom_pn.Controls.Add(label13);
            bottom_pn.Controls.Add(summary_pn);
            bottom_pn.Controls.Add(notes_txt);
            bottom_pn.Controls.Add(summary_and_note_lb);
            bottom_pn.Dock = DockStyle.Bottom;
            bottom_pn.Location = new Point(0, 588);
            bottom_pn.Margin = new Padding(0);
            bottom_pn.Name = "bottom_pn";
            bottom_pn.Size = new Size(1546, 206);
            bottom_pn.TabIndex = 3;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(997, 19);
            label13.Name = "label13";
            label13.Size = new Size(62, 33);
            label13.TabIndex = 11;
            label13.Text = "ສະຫຼຸບ";
            // 
            // summary_pn
            // 
            summary_pn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            summary_pn.Controls.Add(line);
            summary_pn.Controls.Add(label16);
            summary_pn.Controls.Add(amount_to_be_paid_lbl);
            summary_pn.Controls.Add(discount_lb);
            summary_pn.Controls.Add(label12);
            summary_pn.Controls.Add(deposit_amount_val_lb);
            summary_pn.Controls.Add(deposit_amount_lb);
            summary_pn.Controls.Add(label7);
            summary_pn.Controls.Add(label9);
            summary_pn.Controls.Add(total_amount_lb);
            summary_pn.Controls.Add(label11);
            summary_pn.Controls.Add(subtotal_val_lb);
            summary_pn.Controls.Add(subtotal_title_lb);
            summary_pn.Location = new Point(997, 58);
            summary_pn.Name = "summary_pn";
            summary_pn.Size = new Size(517, 131);
            summary_pn.TabIndex = 10;
            // 
            // line
            // 
            line.BackColor = Color.LightGray;
            line.Location = new Point(-2, 95);
            line.Name = "line";
            line.Size = new Size(520, 2);
            line.TabIndex = 24;
            // 
            // label16
            // 
            label16.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold);
            label16.ForeColor = Color.Gray;
            label16.Location = new Point(448, 33);
            label16.Name = "label16";
            label16.Size = new Size(64, 28);
            label16.TabIndex = 23;
            label16.Text = "LAK";
            label16.TextAlign = ContentAlignment.MiddleRight;
            // 
            // amount_to_be_paid_lbl
            // 
            amount_to_be_paid_lbl.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold);
            amount_to_be_paid_lbl.ForeColor = Color.Red;
            amount_to_be_paid_lbl.Location = new Point(195, 101);
            amount_to_be_paid_lbl.Name = "amount_to_be_paid_lbl";
            amount_to_be_paid_lbl.Size = new Size(256, 28);
            amount_to_be_paid_lbl.TabIndex = 22;
            amount_to_be_paid_lbl.Text = "0";
            amount_to_be_paid_lbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // discount_lb
            // 
            discount_lb.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold);
            discount_lb.ForeColor = Color.Red;
            discount_lb.Location = new Point(1, 101);
            discount_lb.Name = "discount_lb";
            discount_lb.Size = new Size(200, 28);
            discount_lb.TabIndex = 21;
            discount_lb.Text = "ຈຳນວນຕ້ອງຊຳລະ:";
            discount_lb.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            label12.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(448, 101);
            label12.Name = "label12";
            label12.Size = new Size(64, 28);
            label12.TabIndex = 20;
            label12.Text = "LAK";
            label12.TextAlign = ContentAlignment.MiddleRight;
            // 
            // deposit_amount_val_lb
            // 
            deposit_amount_val_lb.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold);
            deposit_amount_val_lb.ForeColor = Color.Gray;
            deposit_amount_val_lb.Location = new Point(194, 33);
            deposit_amount_val_lb.Name = "deposit_amount_val_lb";
            deposit_amount_val_lb.Size = new Size(256, 28);
            deposit_amount_val_lb.TabIndex = 19;
            deposit_amount_val_lb.Text = "0";
            deposit_amount_val_lb.TextAlign = ContentAlignment.MiddleRight;
            // 
            // deposit_amount_lb
            // 
            deposit_amount_lb.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold);
            deposit_amount_lb.ForeColor = Color.Gray;
            deposit_amount_lb.Location = new Point(0, 33);
            deposit_amount_lb.Name = "deposit_amount_lb";
            deposit_amount_lb.Size = new Size(200, 28);
            deposit_amount_lb.TabIndex = 18;
            deposit_amount_lb.Text = "ມັດຈຳ:";
            deposit_amount_lb.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold);
            label7.ForeColor = Color.RoyalBlue;
            label7.Location = new Point(448, 63);
            label7.Name = "label7";
            label7.Size = new Size(64, 28);
            label7.TabIndex = 17;
            label7.Text = "LAK";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold);
            label9.Location = new Point(448, 0);
            label9.Name = "label9";
            label9.Size = new Size(64, 28);
            label9.TabIndex = 16;
            label9.Text = "LAK";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // total_amount_lb
            // 
            total_amount_lb.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold);
            total_amount_lb.ForeColor = Color.RoyalBlue;
            total_amount_lb.Location = new Point(194, 63);
            total_amount_lb.Name = "total_amount_lb";
            total_amount_lb.Size = new Size(256, 28);
            total_amount_lb.TabIndex = 14;
            total_amount_lb.Text = "0";
            total_amount_lb.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold);
            label11.ForeColor = Color.RoyalBlue;
            label11.Location = new Point(0, 63);
            label11.Name = "label11";
            label11.Size = new Size(200, 28);
            label11.TabIndex = 13;
            label11.Text = "ຍອດລວມສຸດທິ:";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // subtotal_val_lb
            // 
            subtotal_val_lb.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold);
            subtotal_val_lb.Location = new Point(194, 0);
            subtotal_val_lb.Name = "subtotal_val_lb";
            subtotal_val_lb.Size = new Size(256, 28);
            subtotal_val_lb.TabIndex = 1;
            subtotal_val_lb.Text = "0";
            subtotal_val_lb.TextAlign = ContentAlignment.MiddleRight;
            // 
            // subtotal_title_lb
            // 
            subtotal_title_lb.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold);
            subtotal_title_lb.Location = new Point(0, 0);
            subtotal_title_lb.Name = "subtotal_title_lb";
            subtotal_title_lb.Size = new Size(200, 28);
            subtotal_title_lb.TabIndex = 0;
            subtotal_title_lb.Text = "ຍອດຂາຍລວມ:";
            subtotal_title_lb.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // notes_txt
            // 
            notes_txt.BorderStyle = BorderStyle.FixedSingle;
            notes_txt.Font = new Font("Noto Sans Lao", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            notes_txt.Location = new Point(17, 50);
            notes_txt.Multiline = true;
            notes_txt.Name = "notes_txt";
            notes_txt.Size = new Size(505, 153);
            notes_txt.TabIndex = 0;
            // 
            // summary_and_note_lb
            // 
            summary_and_note_lb.AutoSize = true;
            summary_and_note_lb.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            summary_and_note_lb.Location = new Point(21, 11);
            summary_and_note_lb.Name = "summary_and_note_lb";
            summary_and_note_lb.Size = new Size(104, 33);
            summary_and_note_lb.TabIndex = 8;
            summary_and_note_lb.Text = "ລາຍລະອຽດ";
            // 
            // action_pn
            // 
            action_pn.BackColor = Color.White;
            action_pn.Controls.Add(print_invoice_btn);
            action_pn.Controls.Add(pay_btn);
            action_pn.Dock = DockStyle.Bottom;
            action_pn.Location = new Point(0, 794);
            action_pn.Name = "action_pn";
            action_pn.Size = new Size(1546, 91);
            action_pn.TabIndex = 12;
            // 
            // print_invoice_btn
            // 
            print_invoice_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            print_invoice_btn.BackColor = Color.FromArgb(33, 52, 72);
            print_invoice_btn.Cursor = Cursors.Hand;
            print_invoice_btn.FlatStyle = FlatStyle.Flat;
            print_invoice_btn.Font = new Font("Noto Sans Lao", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            print_invoice_btn.ForeColor = Color.White;
            print_invoice_btn.Location = new Point(1130, 3);
            print_invoice_btn.Name = "print_invoice_btn";
            print_invoice_btn.Size = new Size(178, 68);
            print_invoice_btn.TabIndex = 5;
            print_invoice_btn.Text = "ພິມໃບຮັບເຄື່ອງ";
            print_invoice_btn.UseVisualStyleBackColor = false;
            print_invoice_btn.Click += print_btn_Click;
            // 
            // pay_btn
            // 
            pay_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pay_btn.BackColor = Color.FromArgb(33, 52, 72);
            pay_btn.Cursor = Cursors.Hand;
            pay_btn.FlatStyle = FlatStyle.Flat;
            pay_btn.Font = new Font("Noto Sans Lao", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pay_btn.ForeColor = Color.White;
            pay_btn.Location = new Point(1336, 3);
            pay_btn.Name = "pay_btn";
            pay_btn.Size = new Size(178, 68);
            pay_btn.TabIndex = 4;
            pay_btn.Text = "ຊຳລະເງິນ";
            pay_btn.UseVisualStyleBackColor = false;
            pay_btn.Click += pay_btn_Click;
            // 
            // pick_up_btn
            // 
            pick_up_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pick_up_btn.BackColor = Color.FromArgb(33, 52, 72);
            pick_up_btn.Cursor = Cursors.Hand;
            pick_up_btn.FlatStyle = FlatStyle.Flat;
            pick_up_btn.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pick_up_btn.ForeColor = Color.White;
            pick_up_btn.Location = new Point(1414, 99);
            pick_up_btn.Name = "pick_up_btn";
            pick_up_btn.Size = new Size(96, 40);
            pick_up_btn.TabIndex = 18;
            pick_up_btn.Text = "ບັນທຶກ";
            pick_up_btn.UseVisualStyleBackColor = false;
            pick_up_btn.Click += pick_up_btn_Click;
            // 
            // root_layout
            // 
            root_layout.BorderStyle = BorderStyle.FixedSingle;
            root_layout.Controls.Add(measurement_pn);
            root_layout.Controls.Add(bottom_pn);
            root_layout.Controls.Add(action_pn);
            root_layout.Controls.Add(order_detail_pn);
            root_layout.Controls.Add(header_pn);
            root_layout.Dock = DockStyle.Fill;
            root_layout.Location = new Point(0, 0);
            root_layout.Name = "root_layout";
            root_layout.Size = new Size(1548, 887);
            root_layout.TabIndex = 4;
            // 
            // order_detail_pn
            // 
            order_detail_pn.BackColor = Color.White;
            order_detail_pn.Controls.Add(information_gb);
            order_detail_pn.Dock = DockStyle.Top;
            order_detail_pn.Location = new Point(0, 61);
            order_detail_pn.Margin = new Padding(0);
            order_detail_pn.Name = "order_detail_pn";
            order_detail_pn.Padding = new Padding(8, 16, 8, 4);
            order_detail_pn.Size = new Size(1546, 216);
            order_detail_pn.TabIndex = 1;
            // 
            // information_gb
            // 
            information_gb.Controls.Add(status_cbb);
            information_gb.Controls.Add(pick_up_btn);
            information_gb.Controls.Add(garment_lb);
            information_gb.Controls.Add(tableLayoutPanel3);
            information_gb.Controls.Add(tableLayoutPanel1);
            information_gb.Dock = DockStyle.Fill;
            information_gb.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            information_gb.Location = new Point(8, 16);
            information_gb.Name = "information_gb";
            information_gb.Size = new Size(1530, 196);
            information_gb.TabIndex = 0;
            information_gb.TabStop = false;
            information_gb.Text = "ຂໍ້ມູນການສັ່ງຕັດ";
            // 
            // status_cbb
            // 
            status_cbb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            status_cbb.Location = new Point(1221, 98);
            status_cbb.Name = "status_cbb";
            status_cbb.Size = new Size(187, 41);
            status_cbb.TabIndex = 19;
            // 
            // garment_lb
            // 
            garment_lb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            garment_lb.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            garment_lb.Location = new Point(1221, 58);
            garment_lb.Name = "garment_lb";
            garment_lb.Size = new Size(114, 31);
            garment_lb.TabIndex = 16;
            garment_lb.Text = "ສະຖານະ";
            garment_lb.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label21, 0, 0);
            tableLayoutPanel3.Controls.Add(order_date_lbl, 1, 0);
            tableLayoutPanel3.Controls.Add(label23, 0, 1);
            tableLayoutPanel3.Controls.Add(due_date_lbl, 1, 1);
            tableLayoutPanel3.Controls.Add(label25, 0, 2);
            tableLayoutPanel3.Controls.Add(pick_up_date_lbl, 1, 2);
            tableLayoutPanel3.Location = new Point(621, 58);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.Size = new Size(479, 127);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // label21
            // 
            label21.Dock = DockStyle.Fill;
            label21.Font = new Font("Noto Sans Lao", 10.1999989F);
            label21.Location = new Point(3, 0);
            label21.Name = "label21";
            label21.Size = new Size(154, 40);
            label21.TabIndex = 6;
            label21.Text = "ວັນທີສັ່ງຊື້:";
            label21.TextAlign = ContentAlignment.MiddleRight;
            // 
            // order_date_lbl
            // 
            order_date_lbl.Dock = DockStyle.Fill;
            order_date_lbl.Font = new Font("Noto Sans Lao", 10.1999989F);
            order_date_lbl.Location = new Point(163, 0);
            order_date_lbl.Name = "order_date_lbl";
            order_date_lbl.Size = new Size(313, 40);
            order_date_lbl.TabIndex = 7;
            order_date_lbl.Text = "0";
            order_date_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label23
            // 
            label23.Dock = DockStyle.Fill;
            label23.Font = new Font("Noto Sans Lao", 10.1999989F);
            label23.Location = new Point(3, 40);
            label23.Name = "label23";
            label23.Size = new Size(154, 40);
            label23.TabIndex = 8;
            label23.Text = "ວັນທີນັດຮັບ:";
            label23.TextAlign = ContentAlignment.MiddleRight;
            // 
            // due_date_lbl
            // 
            due_date_lbl.Dock = DockStyle.Fill;
            due_date_lbl.Font = new Font("Noto Sans Lao", 10.1999989F);
            due_date_lbl.Location = new Point(163, 40);
            due_date_lbl.Name = "due_date_lbl";
            due_date_lbl.Size = new Size(313, 40);
            due_date_lbl.TabIndex = 9;
            due_date_lbl.Text = "0";
            due_date_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label25
            // 
            label25.Dock = DockStyle.Fill;
            label25.Font = new Font("Noto Sans Lao", 10.1999989F);
            label25.Location = new Point(3, 80);
            label25.Name = "label25";
            label25.Size = new Size(154, 47);
            label25.TabIndex = 10;
            label25.Text = "ວັນທີຮັບເຄື່ອງ:";
            label25.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pick_up_date_lbl
            // 
            pick_up_date_lbl.Dock = DockStyle.Fill;
            pick_up_date_lbl.Font = new Font("Noto Sans Lao", 10.1999989F);
            pick_up_date_lbl.Location = new Point(163, 80);
            pick_up_date_lbl.Name = "pick_up_date_lbl";
            pick_up_date_lbl.Size = new Size(313, 47);
            pick_up_date_lbl.TabIndex = 11;
            pick_up_date_lbl.Text = "0";
            pick_up_date_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(customer_name_lbl, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(order_number_lbl, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(customer_phone_lbl, 1, 2);
            tableLayoutPanel1.Location = new Point(13, 58);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(448, 127);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Noto Sans Lao", 10.1999989F);
            label5.Location = new Point(3, 80);
            label5.Name = "label5";
            label5.Size = new Size(154, 47);
            label5.TabIndex = 5;
            label5.Text = "ເບີໂທລູກຄ້າ:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // customer_name_lbl
            // 
            customer_name_lbl.Dock = DockStyle.Fill;
            customer_name_lbl.Font = new Font("Noto Sans Lao", 10.1999989F);
            customer_name_lbl.Location = new Point(163, 40);
            customer_name_lbl.Name = "customer_name_lbl";
            customer_name_lbl.Size = new Size(282, 40);
            customer_name_lbl.TabIndex = 4;
            customer_name_lbl.Text = "0";
            customer_name_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Noto Sans Lao", 10.1999989F);
            label3.Location = new Point(3, 40);
            label3.Name = "label3";
            label3.Size = new Size(154, 40);
            label3.TabIndex = 3;
            label3.Text = "ຊື່ລູກຄ້າ:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // order_number_lbl
            // 
            order_number_lbl.Dock = DockStyle.Fill;
            order_number_lbl.Font = new Font("Noto Sans Lao", 10.1999989F);
            order_number_lbl.Location = new Point(163, 0);
            order_number_lbl.Name = "order_number_lbl";
            order_number_lbl.Size = new Size(282, 40);
            order_number_lbl.TabIndex = 2;
            order_number_lbl.Text = "0";
            order_number_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Noto Sans Lao", 10.1999989F);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(154, 40);
            label2.TabIndex = 1;
            label2.Text = "ເລກທີສັ່ງຕັດ:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // customer_phone_lbl
            // 
            customer_phone_lbl.Dock = DockStyle.Fill;
            customer_phone_lbl.Font = new Font("Noto Sans Lao", 10.1999989F);
            customer_phone_lbl.Location = new Point(163, 80);
            customer_phone_lbl.Name = "customer_phone_lbl";
            customer_phone_lbl.Size = new Size(282, 47);
            customer_phone_lbl.TabIndex = 5;
            customer_phone_lbl.Text = "0";
            customer_phone_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // header_pn
            // 
            header_pn.BackColor = Color.White;
            header_pn.Controls.Add(back_btn);
            header_pn.Dock = DockStyle.Top;
            header_pn.Location = new Point(0, 0);
            header_pn.Name = "header_pn";
            header_pn.Size = new Size(1546, 61);
            header_pn.TabIndex = 0;
            // 
            // back_btn
            // 
            back_btn.Cursor = Cursors.Hand;
            back_btn.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            back_btn.Location = new Point(17, 13);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(94, 45);
            back_btn.TabIndex = 0;
            back_btn.Text = "ກັບຄືນ";
            back_btn.UseVisualStyleBackColor = true;
            back_btn.Click += back_btn_Click;
            // 
            // OrderDetailUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(root_layout);
            Name = "OrderDetailUC";
            Size = new Size(1548, 887);
            Load += OrderDetailUC_Load;
            measurement_pn.ResumeLayout(false);
            measurement_pn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)order_items_dgv).EndInit();
            bottom_pn.ResumeLayout(false);
            bottom_pn.PerformLayout();
            summary_pn.ResumeLayout(false);
            action_pn.ResumeLayout(false);
            root_layout.ResumeLayout(false);
            order_detail_pn.ResumeLayout(false);
            information_gb.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            header_pn.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel measurement_pn;
        private Label label4;
        private Panel bottom_pn;
        private Label label13;
        private Panel summary_pn;
        private Label label16;
        private Label amount_to_be_paid_lbl;
        private Label discount_lb;
        private Label label12;
        private Label deposit_amount_val_lb;
        private Label deposit_amount_lb;
        private Label label7;
        private Label label9;
        private Label total_amount_lb;
        private Label label11;
        private Label subtotal_val_lb;
        private Label subtotal_title_lb;
        private TextBox notes_txt;
        private Label summary_and_note_lb;
        private Panel action_pn;
        private Button pay_btn;
        private Panel root_layout;
        private Panel order_detail_pn;
        private GroupBox information_gb;
        private Panel header_pn;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label5;
        private Label customer_name_lbl;
        private Label label3;
        private Label order_number_lbl;
        private Label label2;
        private Label customer_phone_lbl;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label21;
        private Label order_date_lbl;
        private Label label23;
        private Label due_date_lbl;
        private Label label25;
        private Label pick_up_date_lbl;
        private Panel panel4;
        private Label garment_lb;
        private Button back_btn;
        private Button pick_up_btn;
        private Panel line;
        private Button print_invoice_btn;
        private ComboBox status_cbb;
        private DataGridView order_items_dgv;
    }
}
