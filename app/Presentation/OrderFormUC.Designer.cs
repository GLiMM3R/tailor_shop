namespace app.Presentation
{
    partial class OrderFormUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderFormUC));
            header_pn = new Panel();
            order_number_lb = new Label();
            label1 = new Label();
            top_pn = new Panel();
            open_order_item_form_btn = new Button();
            due_date_dpk = new DateTimePicker();
            panel3 = new Panel();
            customer_lbl = new Label();
            choose_customer_btn = new Button();
            due_date_lb = new Label();
            customer_lb = new Label();
            panel1 = new Panel();
            order_items_dgv = new DataGridView();
            footer_pn = new Panel();
            create_order_btn = new Button();
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
            top_pn.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)order_items_dgv).BeginInit();
            footer_pn.SuspendLayout();
            bottom_pn.SuspendLayout();
            summary_pn.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)deposit_amount_num).BeginInit();
            SuspendLayout();
            // 
            // header_pn
            // 
            header_pn.BackColor = Color.FromArgb(33, 52, 72);
            header_pn.Dock = DockStyle.Top;
            header_pn.Location = new Point(0, 0);
            header_pn.Name = "header_pn";
            header_pn.Size = new Size(1430, 61);
            header_pn.TabIndex = 2;
            // 
            // order_number_lb
            // 
            order_number_lb.Font = new Font("Noto Sans Lao", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            order_number_lb.ForeColor = Color.Black;
            order_number_lb.Location = new Point(171, 58);
            order_number_lb.Name = "order_number_lb";
            order_number_lb.Size = new Size(229, 45);
            order_number_lb.TabIndex = 3;
            order_number_lb.Text = "0";
            order_number_lb.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Font = new Font("Noto Sans Lao", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(25, 55);
            label1.Name = "label1";
            label1.Size = new Size(152, 48);
            label1.TabIndex = 2;
            label1.Text = "ເລກທີສັ່ງຕັດ:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // top_pn
            // 
            top_pn.BackColor = Color.White;
            top_pn.Controls.Add(open_order_item_form_btn);
            top_pn.Controls.Add(due_date_dpk);
            top_pn.Controls.Add(order_number_lb);
            top_pn.Controls.Add(label1);
            top_pn.Controls.Add(panel3);
            top_pn.Controls.Add(choose_customer_btn);
            top_pn.Controls.Add(due_date_lb);
            top_pn.Controls.Add(customer_lb);
            top_pn.Dock = DockStyle.Top;
            top_pn.Location = new Point(0, 61);
            top_pn.Margin = new Padding(0);
            top_pn.Name = "top_pn";
            top_pn.Size = new Size(1430, 152);
            top_pn.TabIndex = 3;
            // 
            // open_order_item_form_btn
            // 
            open_order_item_form_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            open_order_item_form_btn.BackColor = Color.FromArgb(33, 52, 72);
            open_order_item_form_btn.Cursor = Cursors.Hand;
            open_order_item_form_btn.FlatStyle = FlatStyle.Flat;
            open_order_item_form_btn.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            open_order_item_form_btn.ForeColor = Color.White;
            open_order_item_form_btn.Image = (Image)resources.GetObject("open_order_item_form_btn.Image");
            open_order_item_form_btn.ImageAlign = ContentAlignment.MiddleLeft;
            open_order_item_form_btn.Location = new Point(1203, 42);
            open_order_item_form_btn.Margin = new Padding(0);
            open_order_item_form_btn.Name = "open_order_item_form_btn";
            open_order_item_form_btn.Padding = new Padding(10, 0, 0, 0);
            open_order_item_form_btn.Size = new Size(187, 76);
            open_order_item_form_btn.TabIndex = 15;
            open_order_item_form_btn.Text = "  ເພິ່ມລາຍການ";
            open_order_item_form_btn.UseVisualStyleBackColor = false;
            open_order_item_form_btn.Click += open_order_item_form_btn_Click;
            // 
            // due_date_dpk
            // 
            due_date_dpk.CalendarFont = new Font("Noto Sans Lao", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            due_date_dpk.CustomFormat = "dd/MM/yyyy";
            due_date_dpk.Font = new Font("Noto Sans Lao", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            due_date_dpk.Format = DateTimePickerFormat.Custom;
            due_date_dpk.Location = new Point(942, 58);
            due_date_dpk.MinDate = new DateTime(2025, 5, 18, 0, 0, 0, 0);
            due_date_dpk.Name = "due_date_dpk";
            due_date_dpk.Size = new Size(233, 45);
            due_date_dpk.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(customer_lbl);
            panel3.Location = new Point(448, 57);
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
            choose_customer_btn.Location = new Point(758, 56);
            choose_customer_btn.Margin = new Padding(0);
            choose_customer_btn.Name = "choose_customer_btn";
            choose_customer_btn.Size = new Size(136, 46);
            choose_customer_btn.TabIndex = 13;
            choose_customer_btn.Text = "ເລືອກລູກຄ້າ";
            choose_customer_btn.UseVisualStyleBackColor = false;
            choose_customer_btn.Click += choose_customer_btn_Click;
            // 
            // due_date_lb
            // 
            due_date_lb.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            due_date_lb.Location = new Point(942, 26);
            due_date_lb.Name = "due_date_lb";
            due_date_lb.Size = new Size(114, 31);
            due_date_lb.TabIndex = 8;
            due_date_lb.Text = "ວັນທີນັດຮັບ";
            due_date_lb.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // customer_lb
            // 
            customer_lb.Font = new Font("Noto Sans Lao", 10.1999989F);
            customer_lb.Location = new Point(448, 23);
            customer_lb.Name = "customer_lb";
            customer_lb.Size = new Size(114, 31);
            customer_lb.TabIndex = 4;
            customer_lb.Text = "ລູກຄ້າ";
            customer_lb.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(order_items_dgv);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 213);
            panel1.Name = "panel1";
            panel1.Size = new Size(1430, 301);
            panel1.TabIndex = 15;
            // 
            // order_items_dgv
            // 
            order_items_dgv.AllowUserToAddRows = false;
            order_items_dgv.AllowUserToDeleteRows = false;
            order_items_dgv.AllowUserToResizeColumns = false;
            order_items_dgv.AllowUserToResizeRows = false;
            order_items_dgv.BackgroundColor = Color.White;
            order_items_dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
            order_items_dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            order_items_dgv.ColumnHeadersHeight = 48;
            order_items_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            order_items_dgv.Dock = DockStyle.Fill;
            order_items_dgv.Location = new Point(0, 0);
            order_items_dgv.MultiSelect = false;
            order_items_dgv.Name = "order_items_dgv";
            order_items_dgv.ReadOnly = true;
            order_items_dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            order_items_dgv.RowHeadersVisible = false;
            order_items_dgv.RowHeadersWidth = 51;
            order_items_dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            order_items_dgv.RowTemplate.Height = 50;
            order_items_dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            order_items_dgv.Size = new Size(1428, 299);
            order_items_dgv.TabIndex = 0;
            // 
            // footer_pn
            // 
            footer_pn.BackColor = Color.White;
            footer_pn.Controls.Add(create_order_btn);
            footer_pn.Dock = DockStyle.Bottom;
            footer_pn.Location = new Point(0, 762);
            footer_pn.Name = "footer_pn";
            footer_pn.Size = new Size(1430, 103);
            footer_pn.TabIndex = 12;
            // 
            // create_order_btn
            // 
            create_order_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            create_order_btn.BackColor = Color.FromArgb(33, 52, 72);
            create_order_btn.Cursor = Cursors.Hand;
            create_order_btn.FlatStyle = FlatStyle.Flat;
            create_order_btn.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            create_order_btn.ForeColor = Color.White;
            create_order_btn.Location = new Point(1235, 3);
            create_order_btn.Name = "create_order_btn";
            create_order_btn.Size = new Size(155, 66);
            create_order_btn.TabIndex = 2;
            create_order_btn.Text = "ບັນທຶກການສັ່ງຕັດ";
            create_order_btn.UseVisualStyleBackColor = false;
            create_order_btn.Click += create_order_btn_Click;
            // 
            // bottom_pn
            // 
            bottom_pn.BackColor = Color.White;
            bottom_pn.Controls.Add(summary_pn);
            bottom_pn.Controls.Add(label2);
            bottom_pn.Controls.Add(notes_txt);
            bottom_pn.Controls.Add(summary_and_note_lb);
            bottom_pn.Dock = DockStyle.Bottom;
            bottom_pn.Location = new Point(0, 514);
            bottom_pn.Margin = new Padding(0);
            bottom_pn.Name = "bottom_pn";
            bottom_pn.Size = new Size(1430, 248);
            bottom_pn.TabIndex = 3;
            // 
            // summary_pn
            // 
            summary_pn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            summary_pn.Location = new Point(867, 85);
            summary_pn.Name = "summary_pn";
            summary_pn.Size = new Size(520, 154);
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
            panel6.Location = new Point(186, 47);
            panel6.Name = "panel6";
            panel6.Size = new Size(267, 38);
            panel6.TabIndex = 18;
            // 
            // deposit_amount_num
            // 
            deposit_amount_num.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            deposit_amount_num.BorderStyle = BorderStyle.None;
            deposit_amount_num.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deposit_amount_num.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            deposit_amount_num.Location = new Point(4, 2);
            deposit_amount_num.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            deposit_amount_num.Name = "deposit_amount_num";
            deposit_amount_num.Size = new Size(257, 31);
            deposit_amount_num.TabIndex = 10;
            deposit_amount_num.TextAlign = HorizontalAlignment.Right;
            deposit_amount_num.ThousandsSeparator = true;
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
            total_amount_lb.Location = new Point(194, 108);
            total_amount_lb.Name = "total_amount_lb";
            total_amount_lb.Size = new Size(246, 44);
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
            subtotal_title_lb.Text = "ຍອດລວມ:";
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
            summary_and_note_lb.Location = new Point(37, 0);
            summary_and_note_lb.Name = "summary_and_note_lb";
            summary_and_note_lb.Size = new Size(83, 53);
            summary_and_note_lb.TabIndex = 8;
            summary_and_note_lb.Text = "ສະຫຼຸບ";
            // 
            // OrderFormUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(bottom_pn);
            Controls.Add(footer_pn);
            Controls.Add(top_pn);
            Controls.Add(header_pn);
            Name = "OrderFormUC";
            Size = new Size(1430, 865);
            Load += OrderFormUC_Load;
            top_pn.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)order_items_dgv).EndInit();
            footer_pn.ResumeLayout(false);
            bottom_pn.ResumeLayout(false);
            bottom_pn.PerformLayout();
            summary_pn.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)deposit_amount_num).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel header_pn;
        private Label order_number_lb;
        private Label label1;
        private Panel top_pn;
        private DateTimePicker due_date_dpk;
        private Panel panel3;
        private Label customer_lbl;
        private Button choose_customer_btn;
        private Label due_date_lb;
        private Label customer_lb;
        private Panel panel1;
        private Button open_order_item_form_btn;
        private Panel footer_pn;
        private Button create_order_btn;
        private Panel bottom_pn;
        private Panel summary_pn;
        private Label label9;
        private Label label3;
        private Panel panel6;
        private NumericUpDown deposit_amount_num;
        private Label label8;
        private Label label7;
        private Label total_amount_lb;
        private Label label5;
        private Panel line;
        private Label subtotal_lb;
        private Label subtotal_title_lb;
        private Label label2;
        private TextBox notes_txt;
        private Label summary_and_note_lb;
        private DataGridView order_items_dgv;
    }
}
