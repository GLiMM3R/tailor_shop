namespace app.Presentation
{
    partial class PaymentModal
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
            root_layout = new Panel();
            action_pn = new Panel();
            confirm_btn = new Button();
            close_btn = new Button();
            panel2 = new Panel();
            discount_val_lb = new Label();
            label5 = new Label();
            total_paying_val_lb = new Label();
            label9 = new Label();
            total_amount_val_lb = new Label();
            label7 = new Label();
            deposit_amount_val_lb = new Label();
            subtotal_val_lb = new Label();
            label3 = new Label();
            label2 = new Label();
            line = new Panel();
            label1 = new Label();
            root_layout.SuspendLayout();
            action_pn.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // root_layout
            // 
            root_layout.BackColor = Color.White;
            root_layout.BorderStyle = BorderStyle.FixedSingle;
            root_layout.Controls.Add(action_pn);
            root_layout.Controls.Add(panel2);
            root_layout.Controls.Add(line);
            root_layout.Controls.Add(label1);
            root_layout.Dock = DockStyle.Fill;
            root_layout.Location = new Point(0, 0);
            root_layout.Margin = new Padding(3, 4, 3, 4);
            root_layout.Name = "root_layout";
            root_layout.Size = new Size(495, 419);
            root_layout.TabIndex = 0;
            // 
            // action_pn
            // 
            action_pn.BorderStyle = BorderStyle.FixedSingle;
            action_pn.Controls.Add(confirm_btn);
            action_pn.Controls.Add(close_btn);
            action_pn.Dock = DockStyle.Bottom;
            action_pn.Location = new Point(0, 340);
            action_pn.Margin = new Padding(3, 4, 3, 4);
            action_pn.Name = "action_pn";
            action_pn.Size = new Size(493, 77);
            action_pn.TabIndex = 3;
            // 
            // confirm_btn
            // 
            confirm_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            confirm_btn.BackColor = Color.Green;
            confirm_btn.Cursor = Cursors.Hand;
            confirm_btn.FlatStyle = FlatStyle.Flat;
            confirm_btn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirm_btn.ForeColor = Color.White;
            confirm_btn.Location = new Point(220, 8);
            confirm_btn.Name = "confirm_btn";
            confirm_btn.Size = new Size(127, 60);
            confirm_btn.TabIndex = 5;
            confirm_btn.Text = "Confirm";
            confirm_btn.UseVisualStyleBackColor = false;
            confirm_btn.Click += this.confirm_btn_Click;
            // 
            // close_btn
            // 
            close_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            close_btn.BackColor = Color.White;
            close_btn.Cursor = Cursors.Hand;
            close_btn.FlatStyle = FlatStyle.Flat;
            close_btn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            close_btn.ForeColor = Color.Gray;
            close_btn.Location = new Point(358, 8);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(127, 60);
            close_btn.TabIndex = 4;
            close_btn.Text = "Close";
            close_btn.UseVisualStyleBackColor = false;
            close_btn.Click += close_btn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(discount_val_lb);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(total_paying_val_lb);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(total_amount_val_lb);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(deposit_amount_val_lb);
            panel2.Controls.Add(subtotal_val_lb);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(3, 69);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(487, 267);
            panel2.TabIndex = 2;
            // 
            // discount_val_lb
            // 
            discount_val_lb.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            discount_val_lb.ForeColor = Color.Orange;
            discount_val_lb.Location = new Point(206, 77);
            discount_val_lb.Name = "discount_val_lb";
            discount_val_lb.Size = new Size(259, 31);
            discount_val_lb.TabIndex = 9;
            discount_val_lb.Text = "0.00";
            discount_val_lb.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Orange;
            label5.Location = new Point(83, 77);
            label5.Name = "label5";
            label5.Size = new Size(115, 31);
            label5.TabIndex = 8;
            label5.Text = "Discount:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // total_paying_val_lb
            // 
            total_paying_val_lb.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total_paying_val_lb.ForeColor = Color.Red;
            total_paying_val_lb.Location = new Point(206, 221);
            total_paying_val_lb.Name = "total_paying_val_lb";
            total_paying_val_lb.Size = new Size(259, 31);
            total_paying_val_lb.TabIndex = 7;
            total_paying_val_lb.Text = "0.00";
            total_paying_val_lb.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(21, 221);
            label9.Name = "label9";
            label9.Size = new Size(178, 31);
            label9.TabIndex = 6;
            label9.Text = "Total Paying:";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // total_amount_val_lb
            // 
            total_amount_val_lb.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total_amount_val_lb.ForeColor = Color.RoyalBlue;
            total_amount_val_lb.Location = new Point(206, 173);
            total_amount_val_lb.Name = "total_amount_val_lb";
            total_amount_val_lb.Size = new Size(259, 31);
            total_amount_val_lb.TabIndex = 5;
            total_amount_val_lb.Text = "0.00";
            total_amount_val_lb.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.RoyalBlue;
            label7.Location = new Point(21, 173);
            label7.Name = "label7";
            label7.Size = new Size(178, 31);
            label7.TabIndex = 4;
            label7.Text = "Total Amount:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // deposit_amount_val_lb
            // 
            deposit_amount_val_lb.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deposit_amount_val_lb.ForeColor = Color.Gray;
            deposit_amount_val_lb.Location = new Point(206, 125);
            deposit_amount_val_lb.Name = "deposit_amount_val_lb";
            deposit_amount_val_lb.Size = new Size(259, 31);
            deposit_amount_val_lb.TabIndex = 3;
            deposit_amount_val_lb.Text = "0.00";
            deposit_amount_val_lb.TextAlign = ContentAlignment.MiddleRight;
            // 
            // subtotal_val_lb
            // 
            subtotal_val_lb.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subtotal_val_lb.ForeColor = Color.Gray;
            subtotal_val_lb.Location = new Point(206, 29);
            subtotal_val_lb.Name = "subtotal_val_lb";
            subtotal_val_lb.Size = new Size(259, 31);
            subtotal_val_lb.TabIndex = 2;
            subtotal_val_lb.Text = "0.00";
            subtotal_val_lb.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(10, 125);
            label3.Name = "label3";
            label3.Size = new Size(189, 31);
            label3.TabIndex = 1;
            label3.Text = "Deposit Amount:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(83, 29);
            label2.Name = "label2";
            label2.Size = new Size(115, 31);
            label2.TabIndex = 0;
            label2.Text = "SubTotal:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // line
            // 
            line.BackColor = Color.Gray;
            line.Location = new Point(2, 65);
            line.Margin = new Padding(3, 4, 3, 4);
            line.Name = "line";
            line.Size = new Size(488, 3);
            line.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 24);
            label1.Name = "label1";
            label1.Size = new Size(232, 24);
            label1.TabIndex = 0;
            label1.Text = "Payment Confirmation?";
            // 
            // PaymentModal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 419);
            Controls.Add(root_layout);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "PaymentModal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PaymentModal";
            Load += PaymentModal_Load;
            root_layout.ResumeLayout(false);
            root_layout.PerformLayout();
            action_pn.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel root_layout;
        private Label label1;
        private Panel panel2;
        private Panel line;
        private Panel action_pn;
        private Button close_btn;
        private Button confirm_btn;
        private Label label2;
        private Label label3;
        private Label total_amount_val_lb;
        private Label label7;
        private Label deposit_amount_val_lb;
        private Label subtotal_val_lb;
        private Label total_paying_val_lb;
        private Label label9;
        private Label discount_val_lb;
        private Label label5;
    }
}