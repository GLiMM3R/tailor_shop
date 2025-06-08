namespace app.Presentation
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            main_layout = new TableLayoutPanel();
            bottom_pn = new Panel();
            summary_pn = new Panel();
            label9 = new Label();
            label3 = new Label();
            panel6 = new Panel();
            deposit_amount_num = new NumericUpDown();
            label8 = new Label();
            label7 = new Label();
            total_amount_lb = new Label();
            label5 = new Label();
            line = new Panel();
            subtotal_lb = new Label();
            subtotal_title_lb = new Label();
            label2 = new Label();
            notes_txt = new TextBox();
            summary_and_note_lb = new Label();
            middle_pn = new Panel();
            lower_body_cb = new CheckBox();
            upper_body_cb = new CheckBox();
            measurements_title_lb = new Label();
            lower_body_form_layout = new TableLayoutPanel();
            length_num = new NumericUpDown();
            length_lb = new Label();
            ankle_num = new NumericUpDown();
            ankle_lb = new Label();
            top_thigh_num = new NumericUpDown();
            top_thigh_lb = new Label();
            lower_hip_lb = new Label();
            lower_waist_num = new NumericUpDown();
            lower_hip_num = new NumericUpDown();
            lower_waist_lb = new Label();
            knee_num = new NumericUpDown();
            knee_lb = new Label();
            thigh_lb = new Label();
            thigh_num = new NumericUpDown();
            upper_body_form_layout = new TableLayoutPanel();
            shirt_length_lb = new Label();
            sleeve_opening_lb = new Label();
            sleeve_length_lb = new Label();
            upper_hip_lb = new Label();
            upper_waist_lb = new Label();
            upper_waist_num = new NumericUpDown();
            chest_lb = new Label();
            chest_num = new NumericUpDown();
            shoulder_lb = new Label();
            shoulder_num = new NumericUpDown();
            neck_lb = new Label();
            neck_num = new NumericUpDown();
            shirt_length_num = new NumericUpDown();
            sleeve_opening_num = new NumericUpDown();
            sleeve_length_num = new NumericUpDown();
            upper_hip_num = new NumericUpDown();
            top_pn = new Panel();
            panel1 = new Panel();
            fabric_image_pb = new PictureBox();
            panel7 = new Panel();
            quantity_num = new NumericUpDown();
            label10 = new Label();
            due_date_dpk = new DateTimePicker();
            panel5 = new Panel();
            fabric_cb = new ComboBox();
            panel4 = new Panel();
            garment_cb = new ComboBox();
            panel3 = new Panel();
            customer_lbl = new Label();
            choose_customer_btn = new Button();
            garment_lb = new Label();
            due_date_lb = new Label();
            fabric_lb = new Label();
            customer_lb = new Label();
            order_number_lb = new Label();
            label1 = new Label();
            header_pn = new Panel();
            close_btn = new Button();
            footer_pn = new Panel();
            create_order_btn = new Button();
            root_pn = new Panel();
            main_layout.SuspendLayout();
            bottom_pn.SuspendLayout();
            summary_pn.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)deposit_amount_num).BeginInit();
            middle_pn.SuspendLayout();
            lower_body_form_layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)length_num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ankle_num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)top_thigh_num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lower_waist_num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lower_hip_num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)knee_num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)thigh_num).BeginInit();
            upper_body_form_layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)upper_waist_num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chest_num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shoulder_num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)neck_num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shirt_length_num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sleeve_opening_num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sleeve_length_num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)upper_hip_num).BeginInit();
            top_pn.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fabric_image_pb).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)quantity_num).BeginInit();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            header_pn.SuspendLayout();
            footer_pn.SuspendLayout();
            root_pn.SuspendLayout();
            SuspendLayout();
            // 
            // main_layout
            // 
            main_layout.BackColor = Color.White;
            main_layout.ColumnCount = 1;
            main_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            main_layout.Controls.Add(bottom_pn, 0, 2);
            main_layout.Controls.Add(middle_pn, 0, 1);
            main_layout.Controls.Add(top_pn, 0, 0);
            main_layout.Dock = DockStyle.Fill;
            main_layout.Location = new Point(0, 61);
            main_layout.Margin = new Padding(0);
            main_layout.Name = "main_layout";
            main_layout.RowCount = 3;
            main_layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            main_layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 280F));
            main_layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            main_layout.Size = new Size(1421, 728);
            main_layout.TabIndex = 0;
            // 
            // bottom_pn
            // 
            bottom_pn.Controls.Add(summary_pn);
            bottom_pn.Controls.Add(label2);
            bottom_pn.Controls.Add(notes_txt);
            bottom_pn.Controls.Add(summary_and_note_lb);
            bottom_pn.Dock = DockStyle.Fill;
            bottom_pn.Location = new Point(0, 480);
            bottom_pn.Margin = new Padding(0);
            bottom_pn.Name = "bottom_pn";
            bottom_pn.Size = new Size(1421, 248);
            bottom_pn.TabIndex = 2;
            bottom_pn.Paint += bottom_pn_Paint;
            // 
            // summary_pn
            // 
            summary_pn.Controls.Add(label9);
            summary_pn.Controls.Add(label3);
            summary_pn.Controls.Add(panel6);
            summary_pn.Controls.Add(label8);
            summary_pn.Controls.Add(label7);
            summary_pn.Controls.Add(total_amount_lb);
            summary_pn.Controls.Add(label5);
            summary_pn.Controls.Add(line);
            summary_pn.Controls.Add(subtotal_lb);
            summary_pn.Controls.Add(subtotal_title_lb);
            summary_pn.Location = new Point(867, 48);
            summary_pn.Name = "summary_pn";
            summary_pn.Size = new Size(520, 191);
            summary_pn.TabIndex = 10;
            // 
            // label9
            // 
            label9.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold);
            label9.ForeColor = Color.Gray;
            label9.Location = new Point(459, 46);
            label9.Name = "label9";
            label9.Size = new Size(61, 44);
            label9.TabIndex = 21;
            label9.Text = "LAK";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Font = new Font("Noto Sans Lao", 10.1999989F);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(3, 47);
            label3.Name = "label3";
            label3.Size = new Size(177, 37);
            label3.TabIndex = 19;
            label3.Text = "ຈ່າຍມັດຈຳ (LAK):";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(deposit_amount_num);
            panel6.Location = new Point(202, 47);
            panel6.Name = "panel6";
            panel6.Size = new Size(253, 38);
            panel6.TabIndex = 18;
            // 
            // deposit_amount_num
            // 
            deposit_amount_num.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            deposit_amount_num.BorderStyle = BorderStyle.None;
            deposit_amount_num.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deposit_amount_num.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            deposit_amount_num.Location = new Point(11, 7);
            deposit_amount_num.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            deposit_amount_num.Name = "deposit_amount_num";
            deposit_amount_num.Size = new Size(235, 23);
            deposit_amount_num.TabIndex = 10;
            deposit_amount_num.TextAlign = HorizontalAlignment.Right;
            // 
            // label8
            // 
            label8.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.RoyalBlue;
            label8.Location = new Point(443, 109);
            label8.Name = "label8";
            label8.Size = new Size(77, 44);
            label8.TabIndex = 17;
            label8.Text = "LAK";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold);
            label7.Location = new Point(459, 3);
            label7.Name = "label7";
            label7.Size = new Size(61, 44);
            label7.TabIndex = 16;
            label7.Text = "LAK";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // total_amount_lb
            // 
            total_amount_lb.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total_amount_lb.ForeColor = Color.RoyalBlue;
            total_amount_lb.Location = new Point(191, 108);
            total_amount_lb.Name = "total_amount_lb";
            total_amount_lb.Size = new Size(259, 44);
            total_amount_lb.TabIndex = 14;
            total_amount_lb.Text = "0";
            total_amount_lb.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.RoyalBlue;
            label5.Location = new Point(0, 108);
            label5.Name = "label5";
            label5.Size = new Size(207, 44);
            label5.TabIndex = 13;
            label5.Text = "ຍອດລວມສຸດທິ:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // line
            // 
            line.BackColor = Color.LightGray;
            line.Location = new Point(0, 94);
            line.Name = "line";
            line.Size = new Size(519, 3);
            line.TabIndex = 12;
            // 
            // subtotal_lb
            // 
            subtotal_lb.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold);
            subtotal_lb.Location = new Point(140, 3);
            subtotal_lb.Name = "subtotal_lb";
            subtotal_lb.Size = new Size(297, 44);
            subtotal_lb.TabIndex = 1;
            subtotal_lb.Text = "0";
            subtotal_lb.TextAlign = ContentAlignment.MiddleRight;
            // 
            // subtotal_title_lb
            // 
            subtotal_title_lb.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subtotal_title_lb.Location = new Point(3, 3);
            subtotal_title_lb.Name = "subtotal_title_lb";
            subtotal_title_lb.Size = new Size(143, 44);
            subtotal_title_lb.TabIndex = 0;
            subtotal_title_lb.Text = "ຍອດຂາຍລວມ:";
            subtotal_title_lb.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 51);
            label2.Name = "label2";
            label2.Size = new Size(114, 31);
            label2.TabIndex = 9;
            label2.Text = "ລາຍລະອຽດ";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // notes_txt
            // 
            notes_txt.BorderStyle = BorderStyle.FixedSingle;
            notes_txt.Location = new Point(37, 85);
            notes_txt.Multiline = true;
            notes_txt.Name = "notes_txt";
            notes_txt.Size = new Size(522, 157);
            notes_txt.TabIndex = 0;
            // 
            // summary_and_note_lb
            // 
            summary_and_note_lb.Font = new Font("Noto Sans Lao", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            summary_and_note_lb.Location = new Point(11, 0);
            summary_and_note_lb.Name = "summary_and_note_lb";
            summary_and_note_lb.Size = new Size(83, 53);
            summary_and_note_lb.TabIndex = 8;
            summary_and_note_lb.Text = "ສະຫຼຸບ";
            // 
            // middle_pn
            // 
            middle_pn.Controls.Add(lower_body_cb);
            middle_pn.Controls.Add(upper_body_cb);
            middle_pn.Controls.Add(measurements_title_lb);
            middle_pn.Controls.Add(lower_body_form_layout);
            middle_pn.Controls.Add(upper_body_form_layout);
            middle_pn.Dock = DockStyle.Fill;
            middle_pn.Location = new Point(0, 200);
            middle_pn.Margin = new Padding(0);
            middle_pn.Name = "middle_pn";
            middle_pn.Size = new Size(1421, 280);
            middle_pn.TabIndex = 1;
            // 
            // lower_body_cb
            // 
            lower_body_cb.AutoSize = true;
            lower_body_cb.Font = new Font("Noto Sans Lao", 13.8F, FontStyle.Bold);
            lower_body_cb.Location = new Point(767, 57);
            lower_body_cb.Name = "lower_body_cb";
            lower_body_cb.Size = new Size(178, 42);
            lower_body_cb.TabIndex = 11;
            lower_body_cb.Text = "ຮ່າງກາຍສ່ວນລຸ່ມ";
            lower_body_cb.UseVisualStyleBackColor = true;
            // 
            // upper_body_cb
            // 
            upper_body_cb.AutoSize = true;
            upper_body_cb.Font = new Font("Noto Sans Lao", 13.8F, FontStyle.Bold);
            upper_body_cb.Location = new Point(133, 57);
            upper_body_cb.Name = "upper_body_cb";
            upper_body_cb.Size = new Size(182, 42);
            upper_body_cb.TabIndex = 10;
            upper_body_cb.Text = "ຮ່າງກາຍສ່ວນເທິງ";
            upper_body_cb.UseVisualStyleBackColor = true;
            upper_body_cb.CheckedChanged += upper_body_cb_CheckedChanged;
            // 
            // measurements_title_lb
            // 
            measurements_title_lb.AutoSize = true;
            measurements_title_lb.Font = new Font("Noto Sans Lao", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            measurements_title_lb.Location = new Point(11, 12);
            measurements_title_lb.Name = "measurements_title_lb";
            measurements_title_lb.Size = new Size(214, 44);
            measurements_title_lb.TabIndex = 7;
            measurements_title_lb.Text = "ການວັດແທກ (cm)";
            // 
            // lower_body_form_layout
            // 
            lower_body_form_layout.ColumnCount = 4;
            lower_body_form_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            lower_body_form_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            lower_body_form_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            lower_body_form_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            lower_body_form_layout.Controls.Add(length_num, 3, 2);
            lower_body_form_layout.Controls.Add(length_lb, 2, 2);
            lower_body_form_layout.Controls.Add(ankle_num, 3, 1);
            lower_body_form_layout.Controls.Add(ankle_lb, 2, 1);
            lower_body_form_layout.Controls.Add(top_thigh_num, 1, 2);
            lower_body_form_layout.Controls.Add(top_thigh_lb, 0, 2);
            lower_body_form_layout.Controls.Add(lower_hip_lb, 0, 1);
            lower_body_form_layout.Controls.Add(lower_waist_num, 1, 0);
            lower_body_form_layout.Controls.Add(lower_hip_num, 1, 1);
            lower_body_form_layout.Controls.Add(lower_waist_lb, 0, 0);
            lower_body_form_layout.Controls.Add(knee_num, 3, 0);
            lower_body_form_layout.Controls.Add(knee_lb, 2, 0);
            lower_body_form_layout.Controls.Add(thigh_lb, 0, 3);
            lower_body_form_layout.Controls.Add(thigh_num, 1, 3);
            lower_body_form_layout.Location = new Point(764, 99);
            lower_body_form_layout.Name = "lower_body_form_layout";
            lower_body_form_layout.RowCount = 4;
            lower_body_form_layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            lower_body_form_layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            lower_body_form_layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            lower_body_form_layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            lower_body_form_layout.Size = new Size(520, 160);
            lower_body_form_layout.TabIndex = 5;
            // 
            // length_num
            // 
            length_num.BorderStyle = BorderStyle.FixedSingle;
            length_num.DecimalPlaces = 2;
            length_num.Dock = DockStyle.Fill;
            length_num.Font = new Font("Noto Sans Lao", 10.1999989F);
            length_num.Location = new Point(393, 83);
            length_num.Name = "length_num";
            length_num.Size = new Size(124, 35);
            length_num.TabIndex = 7;
            length_num.TextAlign = HorizontalAlignment.Center;
            // 
            // length_lb
            // 
            length_lb.Dock = DockStyle.Fill;
            length_lb.Font = new Font("Noto Sans Lao", 10.1999989F);
            length_lb.Location = new Point(263, 80);
            length_lb.Name = "length_lb";
            length_lb.Size = new Size(124, 40);
            length_lb.TabIndex = 31;
            length_lb.Text = "ຄວາມຍາວ";
            length_lb.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ankle_num
            // 
            ankle_num.BorderStyle = BorderStyle.FixedSingle;
            ankle_num.DecimalPlaces = 2;
            ankle_num.Dock = DockStyle.Fill;
            ankle_num.Font = new Font("Noto Sans Lao", 10.1999989F);
            ankle_num.Location = new Point(393, 43);
            ankle_num.Name = "ankle_num";
            ankle_num.Size = new Size(124, 35);
            ankle_num.TabIndex = 6;
            ankle_num.TextAlign = HorizontalAlignment.Center;
            // 
            // ankle_lb
            // 
            ankle_lb.Dock = DockStyle.Fill;
            ankle_lb.Font = new Font("Noto Sans Lao", 10.1999989F);
            ankle_lb.Location = new Point(263, 40);
            ankle_lb.Name = "ankle_lb";
            ankle_lb.Size = new Size(124, 40);
            ankle_lb.TabIndex = 29;
            ankle_lb.Text = "ປາຍຂາ";
            ankle_lb.TextAlign = ContentAlignment.MiddleRight;
            // 
            // top_thigh_num
            // 
            top_thigh_num.BorderStyle = BorderStyle.FixedSingle;
            top_thigh_num.DecimalPlaces = 2;
            top_thigh_num.Dock = DockStyle.Fill;
            top_thigh_num.Font = new Font("Noto Sans Lao", 10.1999989F);
            top_thigh_num.Location = new Point(133, 83);
            top_thigh_num.Name = "top_thigh_num";
            top_thigh_num.Size = new Size(124, 35);
            top_thigh_num.TabIndex = 3;
            top_thigh_num.TextAlign = HorizontalAlignment.Center;
            // 
            // top_thigh_lb
            // 
            top_thigh_lb.Dock = DockStyle.Fill;
            top_thigh_lb.Font = new Font("Noto Sans Lao", 10.1999989F);
            top_thigh_lb.Location = new Point(3, 80);
            top_thigh_lb.Name = "top_thigh_lb";
            top_thigh_lb.Size = new Size(124, 40);
            top_thigh_lb.TabIndex = 18;
            top_thigh_lb.Text = "ອ້ອງ";
            top_thigh_lb.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lower_hip_lb
            // 
            lower_hip_lb.Dock = DockStyle.Fill;
            lower_hip_lb.Font = new Font("Noto Sans Lao", 10.1999989F);
            lower_hip_lb.Location = new Point(3, 40);
            lower_hip_lb.Name = "lower_hip_lb";
            lower_hip_lb.Size = new Size(124, 40);
            lower_hip_lb.TabIndex = 0;
            lower_hip_lb.Text = "ສະໂພກ";
            lower_hip_lb.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lower_waist_num
            // 
            lower_waist_num.BorderStyle = BorderStyle.FixedSingle;
            lower_waist_num.DecimalPlaces = 2;
            lower_waist_num.Dock = DockStyle.Fill;
            lower_waist_num.Font = new Font("Noto Sans Lao", 10.1999989F);
            lower_waist_num.Location = new Point(133, 3);
            lower_waist_num.Name = "lower_waist_num";
            lower_waist_num.Size = new Size(124, 35);
            lower_waist_num.TabIndex = 1;
            lower_waist_num.TextAlign = HorizontalAlignment.Center;
            // 
            // lower_hip_num
            // 
            lower_hip_num.BorderStyle = BorderStyle.FixedSingle;
            lower_hip_num.DecimalPlaces = 2;
            lower_hip_num.Dock = DockStyle.Fill;
            lower_hip_num.Font = new Font("Noto Sans Lao", 10.1999989F);
            lower_hip_num.Location = new Point(133, 43);
            lower_hip_num.Name = "lower_hip_num";
            lower_hip_num.Size = new Size(124, 35);
            lower_hip_num.TabIndex = 2;
            lower_hip_num.TextAlign = HorizontalAlignment.Center;
            // 
            // lower_waist_lb
            // 
            lower_waist_lb.Dock = DockStyle.Fill;
            lower_waist_lb.Font = new Font("Noto Sans Lao", 10.1999989F);
            lower_waist_lb.Location = new Point(3, 0);
            lower_waist_lb.Name = "lower_waist_lb";
            lower_waist_lb.Size = new Size(124, 40);
            lower_waist_lb.TabIndex = 0;
            lower_waist_lb.Text = "ແອວ";
            lower_waist_lb.TextAlign = ContentAlignment.MiddleRight;
            // 
            // knee_num
            // 
            knee_num.BorderStyle = BorderStyle.FixedSingle;
            knee_num.DecimalPlaces = 2;
            knee_num.Dock = DockStyle.Fill;
            knee_num.Font = new Font("Noto Sans Lao", 10.1999989F);
            knee_num.Location = new Point(393, 3);
            knee_num.Name = "knee_num";
            knee_num.Size = new Size(124, 35);
            knee_num.TabIndex = 5;
            knee_num.TextAlign = HorizontalAlignment.Center;
            // 
            // knee_lb
            // 
            knee_lb.Dock = DockStyle.Fill;
            knee_lb.Font = new Font("Noto Sans Lao", 10.1999989F);
            knee_lb.Location = new Point(263, 0);
            knee_lb.Name = "knee_lb";
            knee_lb.Size = new Size(124, 40);
            knee_lb.TabIndex = 6;
            knee_lb.Text = "ເຂົ່າ";
            knee_lb.TextAlign = ContentAlignment.MiddleRight;
            // 
            // thigh_lb
            // 
            thigh_lb.Dock = DockStyle.Fill;
            thigh_lb.Font = new Font("Noto Sans Lao", 10.1999989F);
            thigh_lb.Location = new Point(3, 120);
            thigh_lb.Name = "thigh_lb";
            thigh_lb.Size = new Size(124, 40);
            thigh_lb.TabIndex = 27;
            thigh_lb.Text = "ກົກຂາ";
            thigh_lb.TextAlign = ContentAlignment.MiddleRight;
            // 
            // thigh_num
            // 
            thigh_num.BorderStyle = BorderStyle.FixedSingle;
            thigh_num.DecimalPlaces = 2;
            thigh_num.Dock = DockStyle.Fill;
            thigh_num.Font = new Font("Noto Sans Lao", 10.1999989F);
            thigh_num.Location = new Point(133, 123);
            thigh_num.Name = "thigh_num";
            thigh_num.Size = new Size(124, 35);
            thigh_num.TabIndex = 4;
            thigh_num.TextAlign = HorizontalAlignment.Center;
            // 
            // upper_body_form_layout
            // 
            upper_body_form_layout.ColumnCount = 4;
            upper_body_form_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            upper_body_form_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            upper_body_form_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            upper_body_form_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            upper_body_form_layout.Controls.Add(shirt_length_lb, 2, 3);
            upper_body_form_layout.Controls.Add(sleeve_opening_lb, 2, 2);
            upper_body_form_layout.Controls.Add(sleeve_length_lb, 2, 1);
            upper_body_form_layout.Controls.Add(upper_hip_lb, 2, 0);
            upper_body_form_layout.Controls.Add(upper_waist_lb, 0, 3);
            upper_body_form_layout.Controls.Add(upper_waist_num, 1, 3);
            upper_body_form_layout.Controls.Add(chest_lb, 0, 2);
            upper_body_form_layout.Controls.Add(chest_num, 1, 2);
            upper_body_form_layout.Controls.Add(shoulder_lb, 0, 1);
            upper_body_form_layout.Controls.Add(shoulder_num, 1, 1);
            upper_body_form_layout.Controls.Add(neck_lb, 0, 0);
            upper_body_form_layout.Controls.Add(neck_num, 1, 0);
            upper_body_form_layout.Controls.Add(shirt_length_num, 3, 3);
            upper_body_form_layout.Controls.Add(sleeve_opening_num, 3, 2);
            upper_body_form_layout.Controls.Add(sleeve_length_num, 3, 1);
            upper_body_form_layout.Controls.Add(upper_hip_num, 3, 0);
            upper_body_form_layout.Location = new Point(133, 102);
            upper_body_form_layout.Name = "upper_body_form_layout";
            upper_body_form_layout.RowCount = 4;
            upper_body_form_layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            upper_body_form_layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            upper_body_form_layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            upper_body_form_layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            upper_body_form_layout.Size = new Size(520, 160);
            upper_body_form_layout.TabIndex = 3;
            // 
            // shirt_length_lb
            // 
            shirt_length_lb.Dock = DockStyle.Fill;
            shirt_length_lb.Font = new Font("Noto Sans Lao", 10.1999989F);
            shirt_length_lb.Location = new Point(263, 120);
            shirt_length_lb.Name = "shirt_length_lb";
            shirt_length_lb.Size = new Size(124, 40);
            shirt_length_lb.TabIndex = 19;
            shirt_length_lb.Text = "ຄວາມຍາວເສື້ອ";
            shirt_length_lb.TextAlign = ContentAlignment.MiddleRight;
            // 
            // sleeve_opening_lb
            // 
            sleeve_opening_lb.Dock = DockStyle.Fill;
            sleeve_opening_lb.Font = new Font("Noto Sans Lao", 10.1999989F);
            sleeve_opening_lb.Location = new Point(263, 80);
            sleeve_opening_lb.Name = "sleeve_opening_lb";
            sleeve_opening_lb.Size = new Size(124, 40);
            sleeve_opening_lb.TabIndex = 18;
            sleeve_opening_lb.Text = "ຄວາມຍາວປາຍແຂນເສື້ອ";
            sleeve_opening_lb.TextAlign = ContentAlignment.MiddleRight;
            // 
            // sleeve_length_lb
            // 
            sleeve_length_lb.Dock = DockStyle.Fill;
            sleeve_length_lb.Font = new Font("Noto Sans Lao", 10.1999989F);
            sleeve_length_lb.Location = new Point(263, 40);
            sleeve_length_lb.Name = "sleeve_length_lb";
            sleeve_length_lb.Size = new Size(124, 40);
            sleeve_length_lb.TabIndex = 17;
            sleeve_length_lb.Text = "ຄວາມຍາວແຂນເສື້ອ";
            sleeve_length_lb.TextAlign = ContentAlignment.MiddleRight;
            // 
            // upper_hip_lb
            // 
            upper_hip_lb.Dock = DockStyle.Fill;
            upper_hip_lb.Font = new Font("Noto Sans Lao", 10.1999989F);
            upper_hip_lb.Location = new Point(263, 0);
            upper_hip_lb.Name = "upper_hip_lb";
            upper_hip_lb.Size = new Size(124, 40);
            upper_hip_lb.TabIndex = 16;
            upper_hip_lb.Text = "ສະໂພກ";
            upper_hip_lb.TextAlign = ContentAlignment.MiddleRight;
            // 
            // upper_waist_lb
            // 
            upper_waist_lb.Dock = DockStyle.Fill;
            upper_waist_lb.Font = new Font("Noto Sans Lao", 10.1999989F);
            upper_waist_lb.Location = new Point(3, 120);
            upper_waist_lb.Name = "upper_waist_lb";
            upper_waist_lb.Size = new Size(124, 40);
            upper_waist_lb.TabIndex = 4;
            upper_waist_lb.Text = "ແອວ";
            upper_waist_lb.TextAlign = ContentAlignment.MiddleRight;
            // 
            // upper_waist_num
            // 
            upper_waist_num.BorderStyle = BorderStyle.FixedSingle;
            upper_waist_num.DecimalPlaces = 2;
            upper_waist_num.Dock = DockStyle.Fill;
            upper_waist_num.Font = new Font("Noto Sans Lao", 10.1999989F);
            upper_waist_num.Location = new Point(133, 123);
            upper_waist_num.Name = "upper_waist_num";
            upper_waist_num.Size = new Size(124, 35);
            upper_waist_num.TabIndex = 4;
            upper_waist_num.TextAlign = HorizontalAlignment.Center;
            // 
            // chest_lb
            // 
            chest_lb.Dock = DockStyle.Fill;
            chest_lb.Font = new Font("Noto Sans Lao", 10.1999989F);
            chest_lb.Location = new Point(3, 80);
            chest_lb.Name = "chest_lb";
            chest_lb.Size = new Size(124, 40);
            chest_lb.TabIndex = 2;
            chest_lb.Text = "ເອິກ";
            chest_lb.TextAlign = ContentAlignment.MiddleRight;
            // 
            // chest_num
            // 
            chest_num.BorderStyle = BorderStyle.FixedSingle;
            chest_num.DecimalPlaces = 2;
            chest_num.Dock = DockStyle.Fill;
            chest_num.Font = new Font("Noto Sans Lao", 10.1999989F);
            chest_num.Location = new Point(133, 83);
            chest_num.Name = "chest_num";
            chest_num.Size = new Size(124, 35);
            chest_num.TabIndex = 3;
            chest_num.TextAlign = HorizontalAlignment.Center;
            // 
            // shoulder_lb
            // 
            shoulder_lb.Dock = DockStyle.Fill;
            shoulder_lb.Font = new Font("Noto Sans Lao", 10.1999989F);
            shoulder_lb.Location = new Point(3, 40);
            shoulder_lb.Name = "shoulder_lb";
            shoulder_lb.Size = new Size(124, 40);
            shoulder_lb.TabIndex = 0;
            shoulder_lb.Text = "ບ່າໄຫຼ່";
            shoulder_lb.TextAlign = ContentAlignment.MiddleRight;
            // 
            // shoulder_num
            // 
            shoulder_num.BorderStyle = BorderStyle.FixedSingle;
            shoulder_num.DecimalPlaces = 2;
            shoulder_num.Dock = DockStyle.Fill;
            shoulder_num.Font = new Font("Noto Sans Lao", 10.1999989F);
            shoulder_num.Location = new Point(133, 43);
            shoulder_num.Name = "shoulder_num";
            shoulder_num.Size = new Size(124, 35);
            shoulder_num.TabIndex = 2;
            shoulder_num.TextAlign = HorizontalAlignment.Center;
            // 
            // neck_lb
            // 
            neck_lb.Dock = DockStyle.Fill;
            neck_lb.Font = new Font("Noto Sans Lao", 10.1999989F);
            neck_lb.Location = new Point(3, 0);
            neck_lb.Name = "neck_lb";
            neck_lb.Size = new Size(124, 40);
            neck_lb.TabIndex = 0;
            neck_lb.Text = "ຄໍ";
            neck_lb.TextAlign = ContentAlignment.MiddleRight;
            // 
            // neck_num
            // 
            neck_num.BorderStyle = BorderStyle.FixedSingle;
            neck_num.DecimalPlaces = 2;
            neck_num.Dock = DockStyle.Fill;
            neck_num.Font = new Font("Noto Sans Lao", 10.1999989F);
            neck_num.Location = new Point(133, 3);
            neck_num.Name = "neck_num";
            neck_num.Size = new Size(124, 35);
            neck_num.TabIndex = 1;
            neck_num.TextAlign = HorizontalAlignment.Center;
            // 
            // shirt_length_num
            // 
            shirt_length_num.BorderStyle = BorderStyle.FixedSingle;
            shirt_length_num.DecimalPlaces = 2;
            shirt_length_num.Dock = DockStyle.Fill;
            shirt_length_num.Font = new Font("Noto Sans Lao", 10.1999989F);
            shirt_length_num.Location = new Point(393, 123);
            shirt_length_num.Name = "shirt_length_num";
            shirt_length_num.Size = new Size(124, 35);
            shirt_length_num.TabIndex = 8;
            shirt_length_num.TextAlign = HorizontalAlignment.Center;
            // 
            // sleeve_opening_num
            // 
            sleeve_opening_num.BorderStyle = BorderStyle.FixedSingle;
            sleeve_opening_num.DecimalPlaces = 2;
            sleeve_opening_num.Dock = DockStyle.Fill;
            sleeve_opening_num.Font = new Font("Noto Sans Lao", 10.1999989F);
            sleeve_opening_num.Location = new Point(393, 83);
            sleeve_opening_num.Name = "sleeve_opening_num";
            sleeve_opening_num.Size = new Size(124, 35);
            sleeve_opening_num.TabIndex = 7;
            sleeve_opening_num.TextAlign = HorizontalAlignment.Center;
            // 
            // sleeve_length_num
            // 
            sleeve_length_num.BorderStyle = BorderStyle.FixedSingle;
            sleeve_length_num.DecimalPlaces = 2;
            sleeve_length_num.Dock = DockStyle.Fill;
            sleeve_length_num.Font = new Font("Noto Sans Lao", 10.1999989F);
            sleeve_length_num.Location = new Point(393, 43);
            sleeve_length_num.Name = "sleeve_length_num";
            sleeve_length_num.Size = new Size(124, 35);
            sleeve_length_num.TabIndex = 6;
            sleeve_length_num.TextAlign = HorizontalAlignment.Center;
            // 
            // upper_hip_num
            // 
            upper_hip_num.BorderStyle = BorderStyle.FixedSingle;
            upper_hip_num.DecimalPlaces = 2;
            upper_hip_num.Dock = DockStyle.Fill;
            upper_hip_num.Font = new Font("Noto Sans Lao", 10.1999989F);
            upper_hip_num.Location = new Point(393, 3);
            upper_hip_num.Name = "upper_hip_num";
            upper_hip_num.Size = new Size(124, 35);
            upper_hip_num.TabIndex = 5;
            upper_hip_num.TextAlign = HorizontalAlignment.Center;
            // 
            // top_pn
            // 
            top_pn.Controls.Add(panel1);
            top_pn.Controls.Add(panel7);
            top_pn.Controls.Add(label10);
            top_pn.Controls.Add(due_date_dpk);
            top_pn.Controls.Add(panel5);
            top_pn.Controls.Add(panel4);
            top_pn.Controls.Add(panel3);
            top_pn.Controls.Add(choose_customer_btn);
            top_pn.Controls.Add(garment_lb);
            top_pn.Controls.Add(due_date_lb);
            top_pn.Controls.Add(fabric_lb);
            top_pn.Controls.Add(customer_lb);
            top_pn.Dock = DockStyle.Fill;
            top_pn.Location = new Point(0, 0);
            top_pn.Margin = new Padding(0);
            top_pn.Name = "top_pn";
            top_pn.Size = new Size(1421, 200);
            top_pn.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(fabric_image_pb);
            panel1.Location = new Point(325, 87);
            panel1.Name = "panel1";
            panel1.Size = new Size(175, 110);
            panel1.TabIndex = 20;
            // 
            // fabric_image_pb
            // 
            fabric_image_pb.Dock = DockStyle.Fill;
            fabric_image_pb.Location = new Point(0, 0);
            fabric_image_pb.Name = "fabric_image_pb";
            fabric_image_pb.Size = new Size(173, 108);
            fabric_image_pb.SizeMode = PictureBoxSizeMode.StretchImage;
            fabric_image_pb.TabIndex = 0;
            fabric_image_pb.TabStop = false;
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(quantity_num);
            panel7.Location = new Point(693, 121);
            panel7.Name = "panel7";
            panel7.Size = new Size(290, 46);
            panel7.TabIndex = 19;
            // 
            // quantity_num
            // 
            quantity_num.BorderStyle = BorderStyle.None;
            quantity_num.Font = new Font("Noto Sans Lao", 11.999999F);
            quantity_num.Location = new Point(5, 4);
            quantity_num.Name = "quantity_num";
            quantity_num.Size = new Size(278, 36);
            quantity_num.TabIndex = 9;
            quantity_num.TextAlign = HorizontalAlignment.Center;
            quantity_num.Value = new decimal(new int[] { 1, 0, 0, 0 });
            quantity_num.ValueChanged += quantity_num_ValueChanged;
            // 
            // label10
            // 
            label10.Font = new Font("Noto Sans Lao", 10.1999989F);
            label10.Location = new Point(693, 87);
            label10.Name = "label10";
            label10.Size = new Size(127, 31);
            label10.TabIndex = 18;
            label10.Text = "ຈຳນວນ";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // due_date_dpk
            // 
            due_date_dpk.CalendarFont = new Font("Noto Sans Lao", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            due_date_dpk.CustomFormat = "dd/MM/yyyy";
            due_date_dpk.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            due_date_dpk.Format = DateTimePickerFormat.Custom;
            due_date_dpk.Location = new Point(1157, 35);
            due_date_dpk.MinDate = new DateTime(2025, 5, 18, 0, 0, 0, 0);
            due_date_dpk.Name = "due_date_dpk";
            due_date_dpk.Size = new Size(182, 34);
            due_date_dpk.TabIndex = 7;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(fabric_cb);
            panel5.Location = new Point(27, 121);
            panel5.Name = "panel5";
            panel5.Size = new Size(290, 46);
            panel5.TabIndex = 16;
            // 
            // fabric_cb
            // 
            fabric_cb.FlatStyle = FlatStyle.Flat;
            fabric_cb.Font = new Font("Noto Sans Lao", 11.999999F);
            fabric_cb.FormattingEnabled = true;
            fabric_cb.Location = new Point(10, 1);
            fabric_cb.Name = "fabric_cb";
            fabric_cb.Size = new Size(269, 41);
            fabric_cb.TabIndex = 12;
            fabric_cb.Text = "Select Fabric";
            fabric_cb.SelectedIndexChanged += fabric_cb_SelectedIndexChanged;
            fabric_cb.SelectedValueChanged += fabric_cb_SelectedValueChanged;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(garment_cb);
            panel4.Location = new Point(693, 35);
            panel4.Name = "panel4";
            panel4.Size = new Size(290, 46);
            panel4.TabIndex = 15;
            // 
            // garment_cb
            // 
            garment_cb.FlatStyle = FlatStyle.Flat;
            garment_cb.Font = new Font("Noto Sans Lao", 11.999999F);
            garment_cb.FormattingEnabled = true;
            garment_cb.Location = new Point(11, 1);
            garment_cb.Name = "garment_cb";
            garment_cb.Size = new Size(266, 41);
            garment_cb.TabIndex = 2;
            garment_cb.Text = "Select Garment";
            garment_cb.SelectedValueChanged += garment_cb_SelectedValueChanged;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(customer_lbl);
            panel3.Location = new Point(27, 35);
            panel3.Name = "panel3";
            panel3.Size = new Size(290, 46);
            panel3.TabIndex = 14;
            // 
            // customer_lbl
            // 
            customer_lbl.Dock = DockStyle.Fill;
            customer_lbl.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customer_lbl.Location = new Point(0, 0);
            customer_lbl.Name = "customer_lbl";
            customer_lbl.Size = new Size(288, 44);
            customer_lbl.TabIndex = 20;
            customer_lbl.Text = "ກະລຸນາເລືອກລູກຄ້າ";
            customer_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // choose_customer_btn
            // 
            choose_customer_btn.BackColor = Color.FromArgb(33, 52, 72);
            choose_customer_btn.Cursor = Cursors.Hand;
            choose_customer_btn.FlatStyle = FlatStyle.Flat;
            choose_customer_btn.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            choose_customer_btn.ForeColor = Color.White;
            choose_customer_btn.Location = new Point(325, 35);
            choose_customer_btn.Margin = new Padding(0);
            choose_customer_btn.Name = "choose_customer_btn";
            choose_customer_btn.Size = new Size(175, 46);
            choose_customer_btn.TabIndex = 13;
            choose_customer_btn.Text = "ເລືອກລູກຄ້າ";
            choose_customer_btn.UseVisualStyleBackColor = false;
            choose_customer_btn.Click += choose_customer_btn_Click;
            // 
            // garment_lb
            // 
            garment_lb.Font = new Font("Noto Sans Lao", 10.1999989F);
            garment_lb.Location = new Point(693, 3);
            garment_lb.Name = "garment_lb";
            garment_lb.Size = new Size(114, 31);
            garment_lb.TabIndex = 11;
            garment_lb.Text = "ປະເພດເສື້ອຜ້າ";
            garment_lb.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // due_date_lb
            // 
            due_date_lb.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            due_date_lb.Location = new Point(1157, 3);
            due_date_lb.Name = "due_date_lb";
            due_date_lb.Size = new Size(114, 31);
            due_date_lb.TabIndex = 8;
            due_date_lb.Text = "ວັນທີນັດຮັບ";
            due_date_lb.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // fabric_lb
            // 
            fabric_lb.Font = new Font("Noto Sans Lao", 10.1999989F);
            fabric_lb.Location = new Point(27, 87);
            fabric_lb.Name = "fabric_lb";
            fabric_lb.Size = new Size(114, 31);
            fabric_lb.TabIndex = 6;
            fabric_lb.Text = "ຜ້າ";
            fabric_lb.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // customer_lb
            // 
            customer_lb.Font = new Font("Noto Sans Lao", 10.1999989F);
            customer_lb.Location = new Point(27, 3);
            customer_lb.Name = "customer_lb";
            customer_lb.Size = new Size(114, 31);
            customer_lb.TabIndex = 4;
            customer_lb.Text = "ລູກຄ້າ";
            customer_lb.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // order_number_lb
            // 
            order_number_lb.Font = new Font("Noto Sans Lao", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            order_number_lb.ForeColor = Color.White;
            order_number_lb.Location = new Point(149, 9);
            order_number_lb.Name = "order_number_lb";
            order_number_lb.Size = new Size(283, 46);
            order_number_lb.TabIndex = 3;
            order_number_lb.Text = "0";
            order_number_lb.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Noto Sans Lao", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 8);
            label1.Name = "label1";
            label1.Size = new Size(134, 44);
            label1.TabIndex = 2;
            label1.Text = "ເລກທີສັ່ງຊື້:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // header_pn
            // 
            header_pn.BackColor = Color.FromArgb(33, 52, 72);
            header_pn.Controls.Add(close_btn);
            header_pn.Controls.Add(order_number_lb);
            header_pn.Controls.Add(label1);
            header_pn.Dock = DockStyle.Top;
            header_pn.Location = new Point(0, 0);
            header_pn.Name = "header_pn";
            header_pn.Size = new Size(1421, 61);
            header_pn.TabIndex = 1;
            // 
            // close_btn
            // 
            close_btn.Cursor = Cursors.Hand;
            close_btn.Image = (Image)resources.GetObject("close_btn.Image");
            close_btn.Location = new Point(1367, 8);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(46, 45);
            close_btn.TabIndex = 22;
            close_btn.UseVisualStyleBackColor = true;
            close_btn.Click += close_btn_Click;
            // 
            // footer_pn
            // 
            footer_pn.BackColor = Color.White;
            footer_pn.Controls.Add(create_order_btn);
            footer_pn.Dock = DockStyle.Bottom;
            footer_pn.Location = new Point(0, 789);
            footer_pn.Name = "footer_pn";
            footer_pn.Size = new Size(1421, 103);
            footer_pn.TabIndex = 4;
            // 
            // create_order_btn
            // 
            create_order_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            create_order_btn.BackColor = Color.FromArgb(33, 52, 72);
            create_order_btn.Cursor = Cursors.Hand;
            create_order_btn.FlatStyle = FlatStyle.Flat;
            create_order_btn.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            create_order_btn.ForeColor = Color.White;
            create_order_btn.Location = new Point(1232, 3);
            create_order_btn.Name = "create_order_btn";
            create_order_btn.Size = new Size(155, 66);
            create_order_btn.TabIndex = 2;
            create_order_btn.Text = "ສ້າງຄຳສັ່ງຊື້";
            create_order_btn.UseVisualStyleBackColor = false;
            create_order_btn.Click += create_order_btn_Click;
            // 
            // root_pn
            // 
            root_pn.BorderStyle = BorderStyle.FixedSingle;
            root_pn.Controls.Add(main_layout);
            root_pn.Controls.Add(header_pn);
            root_pn.Controls.Add(footer_pn);
            root_pn.Dock = DockStyle.Fill;
            root_pn.Location = new Point(0, 0);
            root_pn.Name = "root_pn";
            root_pn.Size = new Size(1423, 894);
            root_pn.TabIndex = 7;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1423, 894);
            Controls.Add(root_pn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderForm";
            Load += OrderForm_Load;
            main_layout.ResumeLayout(false);
            bottom_pn.ResumeLayout(false);
            bottom_pn.PerformLayout();
            summary_pn.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)deposit_amount_num).EndInit();
            middle_pn.ResumeLayout(false);
            middle_pn.PerformLayout();
            lower_body_form_layout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)length_num).EndInit();
            ((System.ComponentModel.ISupportInitialize)ankle_num).EndInit();
            ((System.ComponentModel.ISupportInitialize)top_thigh_num).EndInit();
            ((System.ComponentModel.ISupportInitialize)lower_waist_num).EndInit();
            ((System.ComponentModel.ISupportInitialize)lower_hip_num).EndInit();
            ((System.ComponentModel.ISupportInitialize)knee_num).EndInit();
            ((System.ComponentModel.ISupportInitialize)thigh_num).EndInit();
            upper_body_form_layout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)upper_waist_num).EndInit();
            ((System.ComponentModel.ISupportInitialize)chest_num).EndInit();
            ((System.ComponentModel.ISupportInitialize)shoulder_num).EndInit();
            ((System.ComponentModel.ISupportInitialize)neck_num).EndInit();
            ((System.ComponentModel.ISupportInitialize)shirt_length_num).EndInit();
            ((System.ComponentModel.ISupportInitialize)sleeve_opening_num).EndInit();
            ((System.ComponentModel.ISupportInitialize)sleeve_length_num).EndInit();
            ((System.ComponentModel.ISupportInitialize)upper_hip_num).EndInit();
            top_pn.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)fabric_image_pb).EndInit();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)quantity_num).EndInit();
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            header_pn.ResumeLayout(false);
            header_pn.PerformLayout();
            footer_pn.ResumeLayout(false);
            root_pn.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel main_layout;
        private Panel bottom_pn;
        private Panel middle_pn;
        private Panel top_pn;
        private Button button1;
        private Label order_number_lb;
        private Label label1;
        private Label neck_lb;
        private NumericUpDown neck_num;
        private TableLayoutPanel upper_body_form_layout;
        private NumericUpDown shoulder_num;
        private Label shoulder_lb;
        private NumericUpDown sleeve_length_num;
        private NumericUpDown upper_hip_num;
        private NumericUpDown upper_waist_num;
        private Label upper_waist_lb;
        private NumericUpDown chest_num;
        private Label chest_lb;
        private TableLayoutPanel lower_body_form_layout;
        private NumericUpDown knee_num;
        private Label knee_lb;
        private Label lower_hip_lb;
        private NumericUpDown lower_waist_num;
        private NumericUpDown lower_hip_num;
        private Label lower_waist_lb;
        private NumericUpDown sleeve_opening_num;
        private NumericUpDown shirt_length_num;
        private NumericUpDown top_thigh_num;
        private Label top_thigh_lb;
        private Panel header_pn;
        private Label measurements_title_lb;
        private ComboBox garment_cb;
        private Label label29;
        private DateTimePicker due_date_dpk;
        private Label fabric_lb;
        private ComboBox comboBox3;
        private Label label31;
        private Button button2;
        private Label customer_lb;
        private Label due_date_lb;
        private Label label2;
        private TextBox notes_txt;
        private Label summary_and_note_lb;
        private ComboBox fabric_cb;
        private Label garment_lb;
        private Button choose_customer_btn;
        private Panel summary_pn;
        private Label subtotal_title_lb;
        private Label subtotal_lb;
        private Label total_amount_lb;
        private Label label5;
        private Panel line;
        private Label label8;
        private Label label7;
        private Panel footer_pn;
        private Panel root_pn;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label sleeve_opening_lb;
        private Label sleeve_length_lb;
        private Label upper_hip_lb;
        private Label shirt_length_lb;
        private NumericUpDown ankle_num;
        private Label ankle_lb;
        private Label thigh_lb;
        private NumericUpDown thigh_num;
        private NumericUpDown length_num;
        private Label length_lb;
        private Panel panel6;
        private NumericUpDown deposit_amount_num;
        private Label label3;
        private Label label9;
        private Panel panel7;
        private NumericUpDown quantity_num;
        private Label label10;
        private Button close_btn;
        private Button create_order_btn;
        private Label customer_lbl;
        private CheckBox upper_body_cb;
        private CheckBox lower_body_cb;
        private Panel panel1;
        private PictureBox fabric_image_pb;
    }
}