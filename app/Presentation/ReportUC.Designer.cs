namespace app.Presentation
{
    partial class ReportUC
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
            tableLayoutPanel1 = new TableLayoutPanel();
            garment_report_btn = new Button();
            fabric_report_btn = new Button();
            customer_report_btn = new Button();
            overall_sale_report_btn = new Button();
            payment_transaction_report_btn = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(payment_transaction_report_btn, 0, 4);
            tableLayoutPanel1.Controls.Add(garment_report_btn, 0, 3);
            tableLayoutPanel1.Controls.Add(fabric_report_btn, 0, 2);
            tableLayoutPanel1.Controls.Add(customer_report_btn, 0, 1);
            tableLayoutPanel1.Controls.Add(overall_sale_report_btn, 0, 0);
            tableLayoutPanel1.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tableLayoutPanel1.Location = new Point(48, 51);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.Size = new Size(250, 296);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // garment_report_btn
            // 
            garment_report_btn.BackColor = Color.FromArgb(33, 52, 72);
            garment_report_btn.Cursor = Cursors.Hand;
            garment_report_btn.Dock = DockStyle.Fill;
            garment_report_btn.FlatStyle = FlatStyle.Flat;
            garment_report_btn.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            garment_report_btn.ForeColor = Color.White;
            garment_report_btn.Location = new Point(3, 183);
            garment_report_btn.Name = "garment_report_btn";
            garment_report_btn.Size = new Size(244, 54);
            garment_report_btn.TabIndex = 28;
            garment_report_btn.Text = "ລາຍງານປະເພດເສື້ອຜ້າ";
            garment_report_btn.UseVisualStyleBackColor = false;
            garment_report_btn.Click += garment_report_btn_Click;
            // 
            // fabric_report_btn
            // 
            fabric_report_btn.BackColor = Color.FromArgb(33, 52, 72);
            fabric_report_btn.Cursor = Cursors.Hand;
            fabric_report_btn.Dock = DockStyle.Fill;
            fabric_report_btn.FlatStyle = FlatStyle.Flat;
            fabric_report_btn.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fabric_report_btn.ForeColor = Color.White;
            fabric_report_btn.Location = new Point(3, 123);
            fabric_report_btn.Name = "fabric_report_btn";
            fabric_report_btn.Size = new Size(244, 54);
            fabric_report_btn.TabIndex = 27;
            fabric_report_btn.Text = "ລາຍງານປະເພດຜ້າ";
            fabric_report_btn.UseVisualStyleBackColor = false;
            fabric_report_btn.Click += fabric_report_btn_Click;
            // 
            // customer_report_btn
            // 
            customer_report_btn.BackColor = Color.FromArgb(33, 52, 72);
            customer_report_btn.Cursor = Cursors.Hand;
            customer_report_btn.Dock = DockStyle.Fill;
            customer_report_btn.FlatStyle = FlatStyle.Flat;
            customer_report_btn.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customer_report_btn.ForeColor = Color.White;
            customer_report_btn.Location = new Point(3, 63);
            customer_report_btn.Name = "customer_report_btn";
            customer_report_btn.Size = new Size(244, 54);
            customer_report_btn.TabIndex = 26;
            customer_report_btn.Text = "ລາຍງານລູກຄ້າ";
            customer_report_btn.UseVisualStyleBackColor = false;
            customer_report_btn.Click += customer_report_btn_Click;
            // 
            // overall_sale_report_btn
            // 
            overall_sale_report_btn.BackColor = Color.FromArgb(33, 52, 72);
            overall_sale_report_btn.Cursor = Cursors.Hand;
            overall_sale_report_btn.Dock = DockStyle.Fill;
            overall_sale_report_btn.FlatStyle = FlatStyle.Flat;
            overall_sale_report_btn.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            overall_sale_report_btn.ForeColor = Color.White;
            overall_sale_report_btn.Location = new Point(3, 3);
            overall_sale_report_btn.Name = "overall_sale_report_btn";
            overall_sale_report_btn.Size = new Size(244, 54);
            overall_sale_report_btn.TabIndex = 25;
            overall_sale_report_btn.Text = "ລາຍງານຍອດຂາຍລວມ";
            overall_sale_report_btn.UseVisualStyleBackColor = false;
            overall_sale_report_btn.Click += overall_sale_report_btn_Click;
            // 
            // payment_transaction_report_btn
            // 
            payment_transaction_report_btn.BackColor = Color.FromArgb(33, 52, 72);
            payment_transaction_report_btn.Cursor = Cursors.Hand;
            payment_transaction_report_btn.Dock = DockStyle.Fill;
            payment_transaction_report_btn.FlatStyle = FlatStyle.Flat;
            payment_transaction_report_btn.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            payment_transaction_report_btn.ForeColor = Color.White;
            payment_transaction_report_btn.Location = new Point(3, 243);
            payment_transaction_report_btn.Name = "payment_transaction_report_btn";
            payment_transaction_report_btn.Size = new Size(244, 54);
            payment_transaction_report_btn.TabIndex = 29;
            payment_transaction_report_btn.Text = "ລາຍງານການຈ່າຍເງິນ";
            payment_transaction_report_btn.UseVisualStyleBackColor = false;
            payment_transaction_report_btn.Click += payment_transaction_report_btn_Click;
            // 
            // ReportUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            Name = "ReportUC";
            Size = new Size(1464, 903);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button overall_sale_report_btn;
        private Button customer_report_btn;
        private Button fabric_report_btn;
        private Button garment_report_btn;
        private Button payment_transaction_report_btn;
    }
}
