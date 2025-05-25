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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            measurement_pn = new Panel();
            label4 = new Label();
            measurement_dgv = new DataGridView();
            bottom_pn = new Panel();
            label13 = new Label();
            summary_pn = new Panel();
            label16 = new Label();
            discount_val_lb = new Label();
            discount_lb = new Label();
            label12 = new Label();
            deposit_amount_val_lb = new Label();
            deposit_amount_lb = new Label();
            label7 = new Label();
            label9 = new Label();
            total_amount_lb = new Label();
            label11 = new Label();
            line = new Panel();
            subtotal_val_lb = new Label();
            subtotal_title_lb = new Label();
            notes_txt = new TextBox();
            summary_and_note_lb = new Label();
            action_pn = new Panel();
            pay_btn = new Button();
            root_layout = new Panel();
            order_detail_pn = new Panel();
            information_gb = new GroupBox();
            status_lbl = new Label();
            garment_lb = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            label21 = new Label();
            order_date_lbl = new Label();
            label23 = new Label();
            due_date_lbl = new Label();
            label25 = new Label();
            pick_up_date_lbl = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label14 = new Label();
            garment_lbl = new Label();
            label17 = new Label();
            fabric_lbl = new Label();
            label19 = new Label();
            fabric_used_qty_lbl = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label5 = new Label();
            customer_name_lbl = new Label();
            label3 = new Label();
            order_number_lbl = new Label();
            label2 = new Label();
            customer_phone_lbl = new Label();
            header_pn = new Panel();
            button1 = new Button();
            back_btn = new Button();
            measurement_pn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)measurement_dgv).BeginInit();
            bottom_pn.SuspendLayout();
            summary_pn.SuspendLayout();
            action_pn.SuspendLayout();
            root_layout.SuspendLayout();
            order_detail_pn.SuspendLayout();
            information_gb.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            header_pn.SuspendLayout();
            SuspendLayout();
            // 
            // measurement_pn
            // 
            measurement_pn.BackColor = Color.White;
            measurement_pn.Controls.Add(label4);
            measurement_pn.Controls.Add(measurement_dgv);
            measurement_pn.Dock = DockStyle.Fill;
            measurement_pn.Location = new Point(0, 277);
            measurement_pn.Margin = new Padding(0);
            measurement_pn.Name = "measurement_pn";
            measurement_pn.Padding = new Padding(8, 16, 8, 4);
            measurement_pn.Size = new Size(1506, 311);
            measurement_pn.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 16);
            label4.Name = "label4";
            label4.Size = new Size(160, 33);
            label4.TabIndex = 2;
            label4.Text = "ການວັດແທກ (cm)";
            // 
            // measurement_dgv
            // 
            measurement_dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            measurement_dgv.BackgroundColor = Color.White;
            measurement_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            measurement_dgv.DefaultCellStyle = dataGridViewCellStyle1;
            measurement_dgv.Location = new Point(17, 52);
            measurement_dgv.Name = "measurement_dgv";
            measurement_dgv.RowHeadersWidth = 51;
            measurement_dgv.Size = new Size(1478, 249);
            measurement_dgv.TabIndex = 1;
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
            bottom_pn.Size = new Size(1506, 206);
            bottom_pn.TabIndex = 3;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(957, 19);
            label13.Name = "label13";
            label13.Size = new Size(62, 33);
            label13.TabIndex = 11;
            label13.Text = "ສະຫຼຸບ";
            // 
            // summary_pn
            // 
            summary_pn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            summary_pn.Controls.Add(label16);
            summary_pn.Controls.Add(discount_val_lb);
            summary_pn.Controls.Add(discount_lb);
            summary_pn.Controls.Add(label12);
            summary_pn.Controls.Add(deposit_amount_val_lb);
            summary_pn.Controls.Add(deposit_amount_lb);
            summary_pn.Controls.Add(label7);
            summary_pn.Controls.Add(label9);
            summary_pn.Controls.Add(total_amount_lb);
            summary_pn.Controls.Add(label11);
            summary_pn.Controls.Add(line);
            summary_pn.Controls.Add(subtotal_val_lb);
            summary_pn.Controls.Add(subtotal_title_lb);
            summary_pn.Location = new Point(957, 58);
            summary_pn.Name = "summary_pn";
            summary_pn.Size = new Size(517, 131);
            summary_pn.TabIndex = 10;
            // 
            // label16
            // 
            label16.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold);
            label16.ForeColor = Color.Gray;
            label16.Location = new Point(448, 28);
            label16.Name = "label16";
            label16.Size = new Size(64, 28);
            label16.TabIndex = 23;
            label16.Text = "LAK";
            label16.TextAlign = ContentAlignment.MiddleRight;
            // 
            // discount_val_lb
            // 
            discount_val_lb.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold);
            discount_val_lb.ForeColor = Color.Gray;
            discount_val_lb.Location = new Point(194, 28);
            discount_val_lb.Name = "discount_val_lb";
            discount_val_lb.Size = new Size(256, 28);
            discount_val_lb.TabIndex = 22;
            discount_val_lb.Text = "0";
            discount_val_lb.TextAlign = ContentAlignment.MiddleRight;
            // 
            // discount_lb
            // 
            discount_lb.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold);
            discount_lb.ForeColor = Color.Gray;
            discount_lb.Location = new Point(0, 28);
            discount_lb.Name = "discount_lb";
            discount_lb.Size = new Size(200, 28);
            discount_lb.TabIndex = 21;
            discount_lb.Text = "ສ່ວນຫຼຸດ:";
            discount_lb.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            label12.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold);
            label12.ForeColor = Color.Gray;
            label12.Location = new Point(448, 56);
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
            deposit_amount_val_lb.Location = new Point(194, 56);
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
            deposit_amount_lb.Location = new Point(0, 56);
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
            label7.Location = new Point(448, 92);
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
            total_amount_lb.Location = new Point(194, 92);
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
            label11.Location = new Point(0, 92);
            label11.Name = "label11";
            label11.Size = new Size(200, 28);
            label11.TabIndex = 13;
            label11.Text = "ຍອດລວມສຸດທິ:";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // line
            // 
            line.BackColor = Color.LightGray;
            line.Location = new Point(0, 87);
            line.Name = "line";
            line.Size = new Size(520, 2);
            line.TabIndex = 12;
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
            action_pn.Controls.Add(pay_btn);
            action_pn.Dock = DockStyle.Bottom;
            action_pn.Location = new Point(0, 794);
            action_pn.Name = "action_pn";
            action_pn.Size = new Size(1506, 91);
            action_pn.TabIndex = 12;
            // 
            // pay_btn
            // 
            pay_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pay_btn.BackColor = Color.FromArgb(33, 52, 72);
            pay_btn.Cursor = Cursors.Hand;
            pay_btn.FlatStyle = FlatStyle.Flat;
            pay_btn.Font = new Font("Noto Sans Lao", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pay_btn.ForeColor = Color.White;
            pay_btn.Location = new Point(1296, 3);
            pay_btn.Name = "pay_btn";
            pay_btn.Size = new Size(178, 68);
            pay_btn.TabIndex = 4;
            pay_btn.Text = "ຊຳລະເງິນ";
            pay_btn.UseVisualStyleBackColor = false;
            pay_btn.Click += pay_btn_Click;
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
            root_layout.Size = new Size(1508, 887);
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
            order_detail_pn.Size = new Size(1506, 216);
            order_detail_pn.TabIndex = 1;
            // 
            // information_gb
            // 
            information_gb.Controls.Add(status_lbl);
            information_gb.Controls.Add(garment_lb);
            information_gb.Controls.Add(tableLayoutPanel3);
            information_gb.Controls.Add(tableLayoutPanel2);
            information_gb.Controls.Add(tableLayoutPanel1);
            information_gb.Dock = DockStyle.Fill;
            information_gb.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            information_gb.Location = new Point(8, 16);
            information_gb.Name = "information_gb";
            information_gb.Size = new Size(1490, 196);
            information_gb.TabIndex = 0;
            information_gb.TabStop = false;
            information_gb.Text = "ຂໍ້ມູນການສັ່ງຊື້";
            // 
            // status_lbl
            // 
            status_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            status_lbl.BackColor = Color.FromArgb(247, 155, 114);
            status_lbl.BorderStyle = BorderStyle.FixedSingle;
            status_lbl.FlatStyle = FlatStyle.Flat;
            status_lbl.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            status_lbl.ForeColor = Color.Black;
            status_lbl.Location = new Point(1251, 58);
            status_lbl.Name = "status_lbl";
            status_lbl.Size = new Size(210, 63);
            status_lbl.TabIndex = 18;
            status_lbl.Text = "Pending";
            status_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // garment_lb
            // 
            garment_lb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            garment_lb.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            garment_lb.Location = new Point(1251, 26);
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
            tableLayoutPanel3.Location = new Point(803, 58);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.Size = new Size(400, 127);
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
            order_date_lbl.Size = new Size(234, 40);
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
            label23.Text = "ກຳໜົດວັນທີ:";
            label23.TextAlign = ContentAlignment.MiddleRight;
            // 
            // due_date_lbl
            // 
            due_date_lbl.Dock = DockStyle.Fill;
            due_date_lbl.Font = new Font("Noto Sans Lao", 10.1999989F);
            due_date_lbl.Location = new Point(163, 40);
            due_date_lbl.Name = "due_date_lbl";
            due_date_lbl.Size = new Size(234, 40);
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
            pick_up_date_lbl.Size = new Size(234, 47);
            pick_up_date_lbl.TabIndex = 11;
            pick_up_date_lbl.Text = "0";
            pick_up_date_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label14, 0, 0);
            tableLayoutPanel2.Controls.Add(garment_lbl, 1, 0);
            tableLayoutPanel2.Controls.Add(label17, 0, 1);
            tableLayoutPanel2.Controls.Add(fabric_lbl, 1, 1);
            tableLayoutPanel2.Controls.Add(label19, 0, 2);
            tableLayoutPanel2.Controls.Add(fabric_used_qty_lbl, 1, 2);
            tableLayoutPanel2.Location = new Point(400, 58);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.Size = new Size(400, 127);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // label14
            // 
            label14.Dock = DockStyle.Fill;
            label14.Font = new Font("Noto Sans Lao", 10.1999989F);
            label14.Location = new Point(3, 0);
            label14.Name = "label14";
            label14.Size = new Size(154, 40);
            label14.TabIndex = 6;
            label14.Text = "ປະເພດເສື້ອຜ້າ:";
            label14.TextAlign = ContentAlignment.MiddleRight;
            // 
            // garment_lbl
            // 
            garment_lbl.Dock = DockStyle.Fill;
            garment_lbl.Font = new Font("Noto Sans Lao", 10.1999989F);
            garment_lbl.Location = new Point(163, 0);
            garment_lbl.Name = "garment_lbl";
            garment_lbl.Size = new Size(234, 40);
            garment_lbl.TabIndex = 7;
            garment_lbl.Text = "0";
            garment_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            label17.Dock = DockStyle.Fill;
            label17.Font = new Font("Noto Sans Lao", 10.1999989F);
            label17.Location = new Point(3, 40);
            label17.Name = "label17";
            label17.Size = new Size(154, 40);
            label17.TabIndex = 8;
            label17.Text = "ປະເພດຜ້າ:";
            label17.TextAlign = ContentAlignment.MiddleRight;
            // 
            // fabric_lbl
            // 
            fabric_lbl.Dock = DockStyle.Fill;
            fabric_lbl.Font = new Font("Noto Sans Lao", 10.1999989F);
            fabric_lbl.Location = new Point(163, 40);
            fabric_lbl.Name = "fabric_lbl";
            fabric_lbl.Size = new Size(234, 40);
            fabric_lbl.TabIndex = 9;
            fabric_lbl.Text = "0";
            fabric_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            label19.Dock = DockStyle.Fill;
            label19.Font = new Font("Noto Sans Lao", 10.1999989F);
            label19.Location = new Point(3, 80);
            label19.Name = "label19";
            label19.Size = new Size(154, 47);
            label19.TabIndex = 10;
            label19.Text = "ຈຳນວນຜ້າທີ່ໃຊ້:";
            label19.TextAlign = ContentAlignment.MiddleRight;
            // 
            // fabric_used_qty_lbl
            // 
            fabric_used_qty_lbl.Dock = DockStyle.Fill;
            fabric_used_qty_lbl.Font = new Font("Noto Sans Lao", 10.1999989F);
            fabric_used_qty_lbl.Location = new Point(163, 80);
            fabric_used_qty_lbl.Name = "fabric_used_qty_lbl";
            fabric_used_qty_lbl.Size = new Size(234, 47);
            fabric_used_qty_lbl.TabIndex = 11;
            fabric_used_qty_lbl.Text = "0";
            fabric_used_qty_lbl.TextAlign = ContentAlignment.MiddleLeft;
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
            tableLayoutPanel1.Size = new Size(381, 127);
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
            customer_name_lbl.Size = new Size(215, 40);
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
            order_number_lbl.Size = new Size(215, 40);
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
            label2.Text = "ເລກທີສັ່ງຊື້:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // customer_phone_lbl
            // 
            customer_phone_lbl.Dock = DockStyle.Fill;
            customer_phone_lbl.Font = new Font("Noto Sans Lao", 10.1999989F);
            customer_phone_lbl.Location = new Point(163, 80);
            customer_phone_lbl.Name = "customer_phone_lbl";
            customer_phone_lbl.Size = new Size(215, 47);
            customer_phone_lbl.TabIndex = 5;
            customer_phone_lbl.Text = "0";
            customer_phone_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // header_pn
            // 
            header_pn.BackColor = Color.White;
            header_pn.Controls.Add(button1);
            header_pn.Controls.Add(back_btn);
            header_pn.Dock = DockStyle.Top;
            header_pn.Location = new Point(0, 0);
            header_pn.Name = "header_pn";
            header_pn.Size = new Size(1506, 61);
            header_pn.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Red;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1394, 13);
            button1.Name = "button1";
            button1.Size = new Size(101, 45);
            button1.TabIndex = 18;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            // 
            // back_btn
            // 
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
            Size = new Size(1508, 887);
            Load += OrderDetailUC_Load;
            measurement_pn.ResumeLayout(false);
            measurement_pn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)measurement_dgv).EndInit();
            bottom_pn.ResumeLayout(false);
            bottom_pn.PerformLayout();
            summary_pn.ResumeLayout(false);
            action_pn.ResumeLayout(false);
            root_layout.ResumeLayout(false);
            order_detail_pn.ResumeLayout(false);
            information_gb.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            header_pn.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel measurement_pn;
        private Label label4;
        private DataGridView measurement_dgv;
        private Panel bottom_pn;
        private Label label13;
        private Panel summary_pn;
        private Label label16;
        private Label discount_val_lb;
        private Label discount_lb;
        private Label label12;
        private Label deposit_amount_val_lb;
        private Label deposit_amount_lb;
        private Label label7;
        private Label label9;
        private Label total_amount_lb;
        private Label label11;
        private Panel line;
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
        private TableLayoutPanel tableLayoutPanel2;
        private Label label14;
        private Label garment_lbl;
        private Label label17;
        private Label fabric_lbl;
        private Label label19;
        private Label fabric_used_qty_lbl;
        private Panel panel4;
        private Label garment_lb;
        private Button back_btn;
        private Button button1;
        private Label status_lbl;
    }
}
