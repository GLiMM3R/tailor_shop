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
            customer_report_btn = new Button();
            overall_sale_report_btn = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
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
    }
}
