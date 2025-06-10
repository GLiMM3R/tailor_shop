namespace app.Presentation
{
    partial class PaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            panel2 = new Panel();
            summary_pn = new Panel();
            label2 = new Label();
            amount_to_be_paid_lbl = new Label();
            label4 = new Label();
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
            bank_btn = new Button();
            cash_btn = new Button();
            close_btn = new Button();
            label1 = new Label();
            panel6 = new Panel();
            total_paying_num = new NumericUpDown();
            items_lsv = new ListView();
            panel2.SuspendLayout();
            summary_pn.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)total_paying_num).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(summary_pn);
            panel2.Controls.Add(bank_btn);
            panel2.Controls.Add(cash_btn);
            panel2.Controls.Add(close_btn);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(items_lsv);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(522, 738);
            panel2.TabIndex = 1;
            // 
            // summary_pn
            // 
            summary_pn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            summary_pn.Controls.Add(label2);
            summary_pn.Controls.Add(amount_to_be_paid_lbl);
            summary_pn.Controls.Add(label4);
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
            summary_pn.Location = new Point(19, 466);
            summary_pn.Name = "summary_pn";
            summary_pn.Size = new Size(482, 139);
            summary_pn.TabIndex = 11;
            // 
            // label2
            // 
            label2.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(418, 94);
            label2.Name = "label2";
            label2.Size = new Size(64, 28);
            label2.TabIndex = 26;
            label2.Text = "LAK";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // amount_to_be_paid_lbl
            // 
            amount_to_be_paid_lbl.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold);
            amount_to_be_paid_lbl.ForeColor = Color.Red;
            amount_to_be_paid_lbl.Location = new Point(164, 94);
            amount_to_be_paid_lbl.Name = "amount_to_be_paid_lbl";
            amount_to_be_paid_lbl.Size = new Size(256, 28);
            amount_to_be_paid_lbl.TabIndex = 25;
            amount_to_be_paid_lbl.Text = "0";
            amount_to_be_paid_lbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(0, 94);
            label4.Name = "label4";
            label4.Size = new Size(164, 28);
            label4.TabIndex = 24;
            label4.Text = "ຈຳນວນຕ້ອງຊຳລະ:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            label12.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold);
            label12.ForeColor = Color.Gray;
            label12.Location = new Point(418, 27);
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
            deposit_amount_val_lb.Location = new Point(164, 27);
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
            deposit_amount_lb.Location = new Point(0, 27);
            deposit_amount_lb.Name = "deposit_amount_lb";
            deposit_amount_lb.Size = new Size(148, 28);
            deposit_amount_lb.TabIndex = 18;
            deposit_amount_lb.Text = "ມັດຈຳ:";
            deposit_amount_lb.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold);
            label7.ForeColor = Color.RoyalBlue;
            label7.Location = new Point(418, 55);
            label7.Name = "label7";
            label7.Size = new Size(64, 28);
            label7.TabIndex = 17;
            label7.Text = "LAK";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold);
            label9.Location = new Point(418, 0);
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
            total_amount_lb.Location = new Point(164, 55);
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
            label11.Location = new Point(0, 55);
            label11.Name = "label11";
            label11.Size = new Size(148, 28);
            label11.TabIndex = 13;
            label11.Text = "ຍອດຂາຍສຸດທິ:";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // line
            // 
            line.BackColor = Color.LightGray;
            line.Location = new Point(0, 87);
            line.Name = "line";
            line.Size = new Size(480, 2);
            line.TabIndex = 12;
            // 
            // subtotal_val_lb
            // 
            subtotal_val_lb.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold);
            subtotal_val_lb.Location = new Point(164, 0);
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
            subtotal_title_lb.Size = new Size(148, 28);
            subtotal_title_lb.TabIndex = 0;
            subtotal_title_lb.Text = "ຍອດຂາຍລວມ:";
            subtotal_title_lb.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // bank_btn
            // 
            bank_btn.BackColor = Color.FromArgb(33, 52, 72);
            bank_btn.Cursor = Cursors.Hand;
            bank_btn.FlatStyle = FlatStyle.Flat;
            bank_btn.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold);
            bank_btn.ForeColor = Color.White;
            bank_btn.Location = new Point(268, 628);
            bank_btn.Name = "bank_btn";
            bank_btn.Size = new Size(233, 66);
            bank_btn.TabIndex = 24;
            bank_btn.Text = "ໂອນ";
            bank_btn.UseVisualStyleBackColor = false;
            bank_btn.Click += bank_btn_Click;
            // 
            // cash_btn
            // 
            cash_btn.BackColor = Color.FromArgb(33, 52, 72);
            cash_btn.Cursor = Cursors.Hand;
            cash_btn.FlatStyle = FlatStyle.Flat;
            cash_btn.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold);
            cash_btn.ForeColor = Color.White;
            cash_btn.Location = new Point(19, 628);
            cash_btn.Name = "cash_btn";
            cash_btn.Size = new Size(233, 66);
            cash_btn.TabIndex = 23;
            cash_btn.Text = "ເງິນສົດ";
            cash_btn.UseVisualStyleBackColor = false;
            cash_btn.Click += cash_btn_Click;
            // 
            // close_btn
            // 
            close_btn.Cursor = Cursors.Hand;
            close_btn.Image = (Image)resources.GetObject("close_btn.Image");
            close_btn.Location = new Point(464, 12);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(46, 45);
            close_btn.TabIndex = 21;
            close_btn.UseVisualStyleBackColor = true;
            close_btn.Click += close_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Noto Sans Lao", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 74);
            label1.Name = "label1";
            label1.Size = new Size(163, 49);
            label1.TabIndex = 20;
            label1.Text = "ຈຳນວນຊຳລະ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(total_paying_num);
            panel6.Location = new Point(19, 124);
            panel6.Name = "panel6";
            panel6.Size = new Size(482, 79);
            panel6.TabIndex = 19;
            // 
            // total_paying_num
            // 
            total_paying_num.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            total_paying_num.BorderStyle = BorderStyle.None;
            total_paying_num.DecimalPlaces = 2;
            total_paying_num.Font = new Font("Noto Sans Lao", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total_paying_num.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            total_paying_num.Location = new Point(17, 5);
            total_paying_num.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            total_paying_num.Name = "total_paying_num";
            total_paying_num.Size = new Size(449, 69);
            total_paying_num.TabIndex = 10;
            total_paying_num.ThousandsSeparator = true;
            // 
            // items_lsv
            // 
            items_lsv.BackColor = Color.White;
            items_lsv.Font = new Font("Noto Sans Lao", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            items_lsv.Location = new Point(19, 224);
            items_lsv.Name = "items_lsv";
            items_lsv.Size = new Size(482, 223);
            items_lsv.TabIndex = 0;
            items_lsv.UseCompatibleStateImageBehavior = false;
            items_lsv.View = View.Details;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(522, 738);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PaymentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payment Form";
            Load += PaymentForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            summary_pn.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)total_paying_num).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel summary_pn;
        private Label label2;
        private Label amount_to_be_paid_lbl;
        private Label label4;
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
        private Button bank_btn;
        private Button cash_btn;
        private Button close_btn;
        private Label label1;
        private Panel panel6;
        private NumericUpDown total_paying_num;
        private ListView items_lsv;
    }
}