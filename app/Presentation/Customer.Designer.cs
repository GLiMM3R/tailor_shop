namespace app.Presentation
{
    partial class Customer
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
            customer_dgv = new DataGridView();
            main_layout = new TableLayoutPanel();
            panel1 = new Panel();
            new_customer_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)customer_dgv).BeginInit();
            main_layout.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // customer_dgv
            // 
            customer_dgv.AllowUserToAddRows = false;
            customer_dgv.AllowUserToDeleteRows = false;
            customer_dgv.BackgroundColor = Color.White;
            customer_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customer_dgv.Dock = DockStyle.Fill;
            customer_dgv.Location = new Point(8, 187);
            customer_dgv.Margin = new Padding(8);
            customer_dgv.Name = "customer_dgv";
            customer_dgv.ReadOnly = true;
            customer_dgv.RowHeadersWidth = 51;
            customer_dgv.Size = new Size(1150, 402);
            customer_dgv.TabIndex = 0;
            // 
            // main_layout
            // 
            main_layout.BackColor = Color.White;
            main_layout.ColumnCount = 1;
            main_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            main_layout.Controls.Add(customer_dgv, 0, 1);
            main_layout.Controls.Add(panel1, 0, 0);
            main_layout.Dock = DockStyle.Fill;
            main_layout.Location = new Point(0, 0);
            main_layout.Name = "main_layout";
            main_layout.RowCount = 2;
            main_layout.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            main_layout.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            main_layout.Size = new Size(1166, 597);
            main_layout.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(new_customer_btn);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1160, 173);
            panel1.TabIndex = 1;
            // 
            // new_customer_btn
            // 
            new_customer_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            new_customer_btn.Location = new Point(993, 39);
            new_customer_btn.Name = "new_customer_btn";
            new_customer_btn.Size = new Size(139, 66);
            new_customer_btn.TabIndex = 0;
            new_customer_btn.Text = "New Customer";
            new_customer_btn.UseVisualStyleBackColor = true;
            new_customer_btn.Click += new_customer_btn_Click;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(main_layout);
            Name = "Customer";
            Size = new Size(1166, 597);
            Load += Customer_Load;
            ((System.ComponentModel.ISupportInitialize)customer_dgv).EndInit();
            main_layout.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView customer_dgv;
        private TableLayoutPanel main_layout;
        private Panel panel1;
        private Button new_customer_btn;
    }
}
