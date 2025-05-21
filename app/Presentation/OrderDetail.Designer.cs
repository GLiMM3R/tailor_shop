namespace app.Presentation
{
    partial class OrderDetail
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
            header_pn = new Panel();
            panel4 = new Panel();
            exit_btn = new Button();
            label1 = new Label();
            order_detail_pn = new Panel();
            information_gb = new GroupBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            label6 = new Label();
            order_date_val_lb = new Label();
            label8 = new Label();
            due_date_val_lb = new Label();
            label10 = new Label();
            pick_up_date_val_lb = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            garment_lb = new Label();
            garment_val_lb = new Label();
            fabric_lb = new Label();
            fabric_val_lb = new Label();
            fabric_used_qty_lb = new Label();
            fabric_used_qty_val_lb = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            order_number_val_lb = new Label();
            label3 = new Label();
            customer_name_val_lb = new Label();
            label5 = new Label();
            customer_phone_val_lb = new Label();
            measurement_pn = new Panel();
            label4 = new Label();
            measurement_dgv = new DataGridView();
            bottom_pn = new Panel();
            label13 = new Label();
            panel2 = new Panel();
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
            header_pn.SuspendLayout();
            order_detail_pn.SuspendLayout();
            information_gb.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            measurement_pn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)measurement_dgv).BeginInit();
            bottom_pn.SuspendLayout();
            panel2.SuspendLayout();
            action_pn.SuspendLayout();
            root_layout.SuspendLayout();
            SuspendLayout();
            // 
            // header_pn
            // 
            header_pn.BackColor = Color.FromArgb(33, 52, 72);
            header_pn.Controls.Add(panel4);
            header_pn.Controls.Add(exit_btn);
            header_pn.Controls.Add(label1);
            header_pn.Dock = DockStyle.Top;
            header_pn.Location = new Point(0, 0);
            header_pn.Name = "header_pn";
            header_pn.Size = new Size(1180, 61);
            header_pn.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 125);
            panel4.TabIndex = 3;
            // 
            // exit_btn
            // 
            exit_btn.BackColor = Color.Red;
            exit_btn.Cursor = Cursors.Hand;
            exit_btn.FlatAppearance.BorderSize = 0;
            exit_btn.FlatStyle = FlatStyle.Flat;
            exit_btn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exit_btn.Location = new Point(1123, 10);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(50, 43);
            exit_btn.TabIndex = 2;
            exit_btn.Text = "X";
            exit_btn.UseVisualStyleBackColor = false;
            exit_btn.Click += exit_btn_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1180, 61);
            label1.TabIndex = 0;
            label1.Text = "Order Detail";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
            order_detail_pn.Size = new Size(1180, 176);
            order_detail_pn.TabIndex = 1;
            // 
            // information_gb
            // 
            information_gb.Controls.Add(flowLayoutPanel3);
            information_gb.Controls.Add(flowLayoutPanel2);
            information_gb.Controls.Add(flowLayoutPanel1);
            information_gb.Dock = DockStyle.Fill;
            information_gb.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            information_gb.Location = new Point(8, 16);
            information_gb.Name = "information_gb";
            information_gb.Size = new Size(1164, 156);
            information_gb.TabIndex = 0;
            information_gb.TabStop = false;
            information_gb.Text = "Infomation";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(label6);
            flowLayoutPanel3.Controls.Add(order_date_val_lb);
            flowLayoutPanel3.Controls.Add(label8);
            flowLayoutPanel3.Controls.Add(due_date_val_lb);
            flowLayoutPanel3.Controls.Add(label10);
            flowLayoutPanel3.Controls.Add(pick_up_date_val_lb);
            flowLayoutPanel3.Location = new Point(781, 25);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(360, 123);
            flowLayoutPanel3.TabIndex = 2;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Left;
            label6.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(140, 41);
            label6.TabIndex = 0;
            label6.Text = "Order Date:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // order_date_val_lb
            // 
            order_date_val_lb.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            order_date_val_lb.Location = new Point(149, 0);
            order_date_val_lb.Name = "order_date_val_lb";
            order_date_val_lb.Size = new Size(200, 41);
            order_date_val_lb.TabIndex = 1;
            order_date_val_lb.Text = "0";
            order_date_val_lb.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Dock = DockStyle.Left;
            label8.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 41);
            label8.Name = "label8";
            label8.Size = new Size(140, 41);
            label8.TabIndex = 2;
            label8.Text = "Due Date:";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // due_date_val_lb
            // 
            due_date_val_lb.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            due_date_val_lb.Location = new Point(149, 41);
            due_date_val_lb.Name = "due_date_val_lb";
            due_date_val_lb.Size = new Size(200, 41);
            due_date_val_lb.TabIndex = 3;
            due_date_val_lb.Text = "0";
            due_date_val_lb.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.Dock = DockStyle.Left;
            label10.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(3, 82);
            label10.Name = "label10";
            label10.Size = new Size(140, 41);
            label10.TabIndex = 4;
            label10.Text = "PickUp Date:";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pick_up_date_val_lb
            // 
            pick_up_date_val_lb.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pick_up_date_val_lb.Location = new Point(149, 82);
            pick_up_date_val_lb.Name = "pick_up_date_val_lb";
            pick_up_date_val_lb.Size = new Size(200, 41);
            pick_up_date_val_lb.TabIndex = 5;
            pick_up_date_val_lb.Text = "0";
            pick_up_date_val_lb.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(garment_lb);
            flowLayoutPanel2.Controls.Add(garment_val_lb);
            flowLayoutPanel2.Controls.Add(fabric_lb);
            flowLayoutPanel2.Controls.Add(fabric_val_lb);
            flowLayoutPanel2.Controls.Add(fabric_used_qty_lb);
            flowLayoutPanel2.Controls.Add(fabric_used_qty_val_lb);
            flowLayoutPanel2.Location = new Point(397, 25);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(360, 123);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // garment_lb
            // 
            garment_lb.Dock = DockStyle.Left;
            garment_lb.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            garment_lb.Location = new Point(3, 0);
            garment_lb.Name = "garment_lb";
            garment_lb.Size = new Size(140, 41);
            garment_lb.TabIndex = 0;
            garment_lb.Text = "Garment:";
            garment_lb.TextAlign = ContentAlignment.MiddleRight;
            // 
            // garment_val_lb
            // 
            garment_val_lb.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            garment_val_lb.Location = new Point(149, 0);
            garment_val_lb.Name = "garment_val_lb";
            garment_val_lb.Size = new Size(200, 41);
            garment_val_lb.TabIndex = 1;
            garment_val_lb.Text = "0";
            garment_val_lb.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // fabric_lb
            // 
            fabric_lb.Dock = DockStyle.Left;
            fabric_lb.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fabric_lb.Location = new Point(3, 41);
            fabric_lb.Name = "fabric_lb";
            fabric_lb.Size = new Size(140, 41);
            fabric_lb.TabIndex = 2;
            fabric_lb.Text = "Fabric:";
            fabric_lb.TextAlign = ContentAlignment.MiddleRight;
            // 
            // fabric_val_lb
            // 
            fabric_val_lb.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fabric_val_lb.Location = new Point(149, 41);
            fabric_val_lb.Name = "fabric_val_lb";
            fabric_val_lb.Size = new Size(200, 41);
            fabric_val_lb.TabIndex = 3;
            fabric_val_lb.Text = "0";
            fabric_val_lb.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // fabric_used_qty_lb
            // 
            fabric_used_qty_lb.Dock = DockStyle.Left;
            fabric_used_qty_lb.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fabric_used_qty_lb.Location = new Point(3, 82);
            fabric_used_qty_lb.Name = "fabric_used_qty_lb";
            fabric_used_qty_lb.Size = new Size(140, 41);
            fabric_used_qty_lb.TabIndex = 4;
            fabric_used_qty_lb.Text = "Fabric Used Qty:";
            fabric_used_qty_lb.TextAlign = ContentAlignment.MiddleRight;
            // 
            // fabric_used_qty_val_lb
            // 
            fabric_used_qty_val_lb.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fabric_used_qty_val_lb.Location = new Point(149, 82);
            fabric_used_qty_val_lb.Name = "fabric_used_qty_val_lb";
            fabric_used_qty_val_lb.Size = new Size(200, 41);
            fabric_used_qty_val_lb.TabIndex = 5;
            fabric_used_qty_val_lb.Text = "0";
            fabric_used_qty_val_lb.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(order_number_val_lb);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(customer_name_val_lb);
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Controls.Add(customer_phone_val_lb);
            flowLayoutPanel1.Location = new Point(10, 25);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(360, 123);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(140, 41);
            label2.TabIndex = 0;
            label2.Text = "Order Number:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // order_number_val_lb
            // 
            order_number_val_lb.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            order_number_val_lb.Location = new Point(149, 0);
            order_number_val_lb.Name = "order_number_val_lb";
            order_number_val_lb.Size = new Size(200, 41);
            order_number_val_lb.TabIndex = 1;
            order_number_val_lb.Text = "0";
            order_number_val_lb.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 41);
            label3.Name = "label3";
            label3.Size = new Size(140, 41);
            label3.TabIndex = 2;
            label3.Text = "Customer Name:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // customer_name_val_lb
            // 
            customer_name_val_lb.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customer_name_val_lb.Location = new Point(149, 41);
            customer_name_val_lb.Name = "customer_name_val_lb";
            customer_name_val_lb.Size = new Size(200, 41);
            customer_name_val_lb.TabIndex = 3;
            customer_name_val_lb.Text = "0";
            customer_name_val_lb.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Left;
            label5.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 82);
            label5.Name = "label5";
            label5.Size = new Size(140, 41);
            label5.TabIndex = 4;
            label5.Text = "Customer Phone:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // customer_phone_val_lb
            // 
            customer_phone_val_lb.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customer_phone_val_lb.Location = new Point(149, 82);
            customer_phone_val_lb.Name = "customer_phone_val_lb";
            customer_phone_val_lb.Size = new Size(200, 41);
            customer_phone_val_lb.TabIndex = 5;
            customer_phone_val_lb.Text = "0";
            customer_phone_val_lb.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // measurement_pn
            // 
            measurement_pn.BackColor = Color.White;
            measurement_pn.Controls.Add(label4);
            measurement_pn.Controls.Add(measurement_dgv);
            measurement_pn.Dock = DockStyle.Top;
            measurement_pn.Location = new Point(0, 237);
            measurement_pn.Margin = new Padding(0);
            measurement_pn.Name = "measurement_pn";
            measurement_pn.Padding = new Padding(8, 16, 8, 4);
            measurement_pn.Size = new Size(1180, 322);
            measurement_pn.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(8, 16);
            label4.Name = "label4";
            label4.Size = new Size(149, 24);
            label4.TabIndex = 2;
            label4.Text = "Measurements";
            // 
            // measurement_dgv
            // 
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
            measurement_dgv.Size = new Size(1151, 260);
            measurement_dgv.TabIndex = 1;
            // 
            // bottom_pn
            // 
            bottom_pn.BackColor = Color.White;
            bottom_pn.Controls.Add(label13);
            bottom_pn.Controls.Add(panel2);
            bottom_pn.Controls.Add(notes_txt);
            bottom_pn.Controls.Add(summary_and_note_lb);
            bottom_pn.Dock = DockStyle.Fill;
            bottom_pn.Location = new Point(0, 559);
            bottom_pn.Margin = new Padding(0);
            bottom_pn.Name = "bottom_pn";
            bottom_pn.Size = new Size(1180, 331);
            bottom_pn.TabIndex = 3;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(611, 11);
            label13.Name = "label13";
            label13.Size = new Size(99, 24);
            label13.TabIndex = 11;
            label13.Text = "Summary";
            // 
            // panel2
            // 
            panel2.Controls.Add(label16);
            panel2.Controls.Add(discount_val_lb);
            panel2.Controls.Add(discount_lb);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(deposit_amount_val_lb);
            panel2.Controls.Add(deposit_amount_lb);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(total_amount_lb);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(line);
            panel2.Controls.Add(subtotal_val_lb);
            panel2.Controls.Add(subtotal_title_lb);
            panel2.Location = new Point(611, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(520, 182);
            panel2.TabIndex = 10;
            // 
            // label16
            // 
            label16.Font = new Font("Arial", 12F, FontStyle.Bold);
            label16.ForeColor = Color.Gray;
            label16.Location = new Point(448, 44);
            label16.Name = "label16";
            label16.Size = new Size(69, 44);
            label16.TabIndex = 23;
            label16.Text = "LAK";
            label16.TextAlign = ContentAlignment.MiddleRight;
            // 
            // discount_val_lb
            // 
            discount_val_lb.Font = new Font("Arial", 12F, FontStyle.Bold);
            discount_val_lb.ForeColor = Color.Gray;
            discount_val_lb.Location = new Point(194, 44);
            discount_val_lb.Name = "discount_val_lb";
            discount_val_lb.Size = new Size(256, 44);
            discount_val_lb.TabIndex = 22;
            discount_val_lb.Text = "0";
            discount_val_lb.TextAlign = ContentAlignment.MiddleRight;
            // 
            // discount_lb
            // 
            discount_lb.Font = new Font("Arial", 12F, FontStyle.Bold);
            discount_lb.ForeColor = Color.Gray;
            discount_lb.Location = new Point(0, 42);
            discount_lb.Name = "discount_lb";
            discount_lb.Size = new Size(200, 44);
            discount_lb.TabIndex = 21;
            discount_lb.Text = "Discount:";
            discount_lb.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            label12.Font = new Font("Arial", 12F, FontStyle.Bold);
            label12.ForeColor = Color.Gray;
            label12.Location = new Point(448, 86);
            label12.Name = "label12";
            label12.Size = new Size(69, 44);
            label12.TabIndex = 20;
            label12.Text = "LAK";
            label12.TextAlign = ContentAlignment.MiddleRight;
            // 
            // deposit_amount_val_lb
            // 
            deposit_amount_val_lb.Font = new Font("Arial", 12F, FontStyle.Bold);
            deposit_amount_val_lb.ForeColor = Color.Gray;
            deposit_amount_val_lb.Location = new Point(194, 86);
            deposit_amount_val_lb.Name = "deposit_amount_val_lb";
            deposit_amount_val_lb.Size = new Size(256, 44);
            deposit_amount_val_lb.TabIndex = 19;
            deposit_amount_val_lb.Text = "0";
            deposit_amount_val_lb.TextAlign = ContentAlignment.MiddleRight;
            // 
            // deposit_amount_lb
            // 
            deposit_amount_lb.Font = new Font("Arial", 12F, FontStyle.Bold);
            deposit_amount_lb.ForeColor = Color.Gray;
            deposit_amount_lb.Location = new Point(0, 86);
            deposit_amount_lb.Name = "deposit_amount_lb";
            deposit_amount_lb.Size = new Size(200, 44);
            deposit_amount_lb.TabIndex = 18;
            deposit_amount_lb.Text = "Deposit Amount:";
            deposit_amount_lb.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Font = new Font("Arial", 12F, FontStyle.Bold);
            label7.ForeColor = Color.RoyalBlue;
            label7.Location = new Point(453, 140);
            label7.Name = "label7";
            label7.Size = new Size(64, 44);
            label7.TabIndex = 17;
            label7.Text = "LAK";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.Font = new Font("Arial", 12F, FontStyle.Bold);
            label9.Location = new Point(453, 0);
            label9.Name = "label9";
            label9.Size = new Size(64, 44);
            label9.TabIndex = 16;
            label9.Text = "LAK";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // total_amount_lb
            // 
            total_amount_lb.Font = new Font("Arial", 13.8F, FontStyle.Bold);
            total_amount_lb.ForeColor = Color.RoyalBlue;
            total_amount_lb.Location = new Point(178, 138);
            total_amount_lb.Name = "total_amount_lb";
            total_amount_lb.Size = new Size(272, 44);
            total_amount_lb.TabIndex = 14;
            total_amount_lb.Text = "0";
            total_amount_lb.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.Font = new Font("Arial", 12F, FontStyle.Bold);
            label11.ForeColor = Color.RoyalBlue;
            label11.Location = new Point(0, 138);
            label11.Name = "label11";
            label11.Size = new Size(172, 44);
            label11.TabIndex = 13;
            label11.Text = "Total Amount:";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // line
            // 
            line.BackColor = Color.LightGray;
            line.Location = new Point(0, 133);
            line.Name = "line";
            line.Size = new Size(520, 2);
            line.TabIndex = 12;
            // 
            // subtotal_val_lb
            // 
            subtotal_val_lb.Font = new Font("Arial", 12F, FontStyle.Bold);
            subtotal_val_lb.Location = new Point(194, 0);
            subtotal_val_lb.Name = "subtotal_val_lb";
            subtotal_val_lb.Size = new Size(256, 44);
            subtotal_val_lb.TabIndex = 1;
            subtotal_val_lb.Text = "0";
            subtotal_val_lb.TextAlign = ContentAlignment.MiddleRight;
            // 
            // subtotal_title_lb
            // 
            subtotal_title_lb.Font = new Font("Arial", 12F, FontStyle.Bold);
            subtotal_title_lb.Location = new Point(0, 0);
            subtotal_title_lb.Name = "subtotal_title_lb";
            subtotal_title_lb.Size = new Size(188, 42);
            subtotal_title_lb.TabIndex = 0;
            subtotal_title_lb.Text = "Subtotal:";
            subtotal_title_lb.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // notes_txt
            // 
            notes_txt.BorderStyle = BorderStyle.FixedSingle;
            notes_txt.Location = new Point(17, 50);
            notes_txt.Multiline = true;
            notes_txt.Name = "notes_txt";
            notes_txt.Size = new Size(402, 182);
            notes_txt.TabIndex = 0;
            // 
            // summary_and_note_lb
            // 
            summary_and_note_lb.AutoSize = true;
            summary_and_note_lb.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            summary_and_note_lb.Location = new Point(8, 11);
            summary_and_note_lb.Name = "summary_and_note_lb";
            summary_and_note_lb.Size = new Size(65, 24);
            summary_and_note_lb.TabIndex = 8;
            summary_and_note_lb.Text = "Notes";
            // 
            // action_pn
            // 
            action_pn.BackColor = Color.White;
            action_pn.Controls.Add(pay_btn);
            action_pn.Dock = DockStyle.Bottom;
            action_pn.Location = new Point(0, 802);
            action_pn.Name = "action_pn";
            action_pn.Size = new Size(1180, 88);
            action_pn.TabIndex = 12;
            // 
            // pay_btn
            // 
            pay_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pay_btn.BackColor = Color.FromArgb(33, 52, 72);
            pay_btn.Cursor = Cursors.Hand;
            pay_btn.FlatStyle = FlatStyle.Flat;
            pay_btn.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pay_btn.ForeColor = Color.White;
            pay_btn.Location = new Point(953, 3);
            pay_btn.Name = "pay_btn";
            pay_btn.Size = new Size(178, 63);
            pay_btn.TabIndex = 4;
            pay_btn.Text = "Pay";
            pay_btn.UseVisualStyleBackColor = false;
            pay_btn.Click += pay_btn_Click;
            // 
            // root_layout
            // 
            root_layout.BorderStyle = BorderStyle.FixedSingle;
            root_layout.Controls.Add(action_pn);
            root_layout.Controls.Add(bottom_pn);
            root_layout.Controls.Add(measurement_pn);
            root_layout.Controls.Add(order_detail_pn);
            root_layout.Controls.Add(header_pn);
            root_layout.Dock = DockStyle.Fill;
            root_layout.Location = new Point(0, 0);
            root_layout.Name = "root_layout";
            root_layout.Size = new Size(1182, 892);
            root_layout.TabIndex = 3;
            // 
            // OrderDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 892);
            Controls.Add(root_layout);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrderDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderDetail";
            Load += OrderDetail_Load;
            header_pn.ResumeLayout(false);
            order_detail_pn.ResumeLayout(false);
            information_gb.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            measurement_pn.ResumeLayout(false);
            measurement_pn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)measurement_dgv).EndInit();
            bottom_pn.ResumeLayout(false);
            bottom_pn.PerformLayout();
            panel2.ResumeLayout(false);
            action_pn.ResumeLayout(false);
            root_layout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel header_pn;
        private Label label1;
        private Panel order_detail_pn;
        private GroupBox information_gb;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private Label order_number_val_lb;
        private Label label3;
        private Label customer_name_val_lb;
        private Label label5;
        private Label customer_phone_val_lb;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label garment_lb;
        private Label garment_val_lb;
        private Label fabric_lb;
        private Label fabric_val_lb;
        private Label fabric_used_qty_lb;
        private Label fabric_used_qty_val_lb;
        private Panel measurement_pn;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label6;
        private Label order_date_val_lb;
        private Label label8;
        private Label label10;
        private Label pick_up_date_val_lb;
        private Label label4;
        private DataGridView measurement_dgv;
        private Label due_date_val_lb;
        private Panel bottom_pn;
        private Label label13;
        private Panel panel2;
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
        private Label label16;
        private Label discount_val_lb;
        private Label discount_lb;
        private Panel action_pn;
        private Button pay_btn;
        private Button exit_btn;
        private Panel panel4;
        private Panel root_layout;
    }
}