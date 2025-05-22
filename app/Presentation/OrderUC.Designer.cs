namespace app.Presentation
{
    partial class OrderUC
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            order_dgv = new DataGridView();
            filter_pn = new Panel();
            clear_btn = new Button();
            label1 = new Label();
            panel1 = new Panel();
            status_cbb = new ComboBox();
            search_pn = new Panel();
            search_txt = new TextBox();
            main_layout = new TableLayoutPanel();
            bottom_pn = new TableLayoutPanel();
            top_pn = new Panel();
            new_order_btn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            total_order_lbl = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)order_dgv).BeginInit();
            filter_pn.SuspendLayout();
            panel1.SuspendLayout();
            search_pn.SuspendLayout();
            main_layout.SuspendLayout();
            bottom_pn.SuspendLayout();
            top_pn.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // order_dgv
            // 
            order_dgv.AllowUserToAddRows = false;
            order_dgv.AllowUserToDeleteRows = false;
            order_dgv.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            order_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            order_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            order_dgv.Dock = DockStyle.Fill;
            order_dgv.Location = new Point(9, 110);
            order_dgv.Margin = new Padding(8);
            order_dgv.Name = "order_dgv";
            order_dgv.ReadOnly = true;
            order_dgv.RowHeadersWidth = 51;
            order_dgv.Size = new Size(1042, 326);
            order_dgv.TabIndex = 0;
            // 
            // filter_pn
            // 
            filter_pn.Controls.Add(clear_btn);
            filter_pn.Controls.Add(label1);
            filter_pn.Controls.Add(panel1);
            filter_pn.Controls.Add(search_pn);
            filter_pn.Dock = DockStyle.Top;
            filter_pn.Location = new Point(4, 4);
            filter_pn.Name = "filter_pn";
            filter_pn.Size = new Size(1052, 90);
            filter_pn.TabIndex = 1;
            // 
            // clear_btn
            // 
            clear_btn.BackColor = Color.LightGray;
            clear_btn.Cursor = Cursors.Hand;
            clear_btn.FlatStyle = FlatStyle.Flat;
            clear_btn.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clear_btn.Location = new Point(666, 23);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(94, 47);
            clear_btn.TabIndex = 5;
            clear_btn.Text = "Clear";
            clear_btn.UseVisualStyleBackColor = false;
            clear_btn.Click += clear_btn_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(350, 22);
            label1.Name = "label1";
            label1.Size = new Size(72, 47);
            label1.TabIndex = 4;
            label1.Text = "Status";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(status_cbb);
            panel1.Location = new Point(424, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(204, 47);
            panel1.TabIndex = 3;
            // 
            // status_cbb
            // 
            status_cbb.FlatStyle = FlatStyle.Flat;
            status_cbb.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            status_cbb.FormattingEnabled = true;
            status_cbb.Items.AddRange(new object[] { "All", "User", "Admin" });
            status_cbb.Location = new Point(3, 7);
            status_cbb.Name = "status_cbb";
            status_cbb.Size = new Size(190, 31);
            status_cbb.TabIndex = 1;
            status_cbb.SelectedIndexChanged += status_cbb_SelectedIndexChanged;
            // 
            // search_pn
            // 
            search_pn.BorderStyle = BorderStyle.FixedSingle;
            search_pn.Controls.Add(search_txt);
            search_pn.Location = new Point(30, 22);
            search_pn.Name = "search_pn";
            search_pn.Size = new Size(275, 47);
            search_pn.TabIndex = 0;
            // 
            // search_txt
            // 
            search_txt.BorderStyle = BorderStyle.None;
            search_txt.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search_txt.Location = new Point(7, 11);
            search_txt.Name = "search_txt";
            search_txt.PlaceholderText = "Search...";
            search_txt.Size = new Size(259, 23);
            search_txt.TabIndex = 0;
            search_txt.TextChanged += search_txt_TextChanged;
            // 
            // main_layout
            // 
            main_layout.BackColor = Color.White;
            main_layout.ColumnCount = 1;
            main_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            main_layout.Controls.Add(bottom_pn, 0, 2);
            main_layout.Controls.Add(top_pn, 0, 0);
            main_layout.Dock = DockStyle.Fill;
            main_layout.Location = new Point(0, 0);
            main_layout.Name = "main_layout";
            main_layout.RowCount = 1;
            main_layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            main_layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 0F));
            main_layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            main_layout.Size = new Size(1066, 651);
            main_layout.TabIndex = 3;
            // 
            // bottom_pn
            // 
            bottom_pn.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            bottom_pn.ColumnCount = 1;
            bottom_pn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            bottom_pn.Controls.Add(order_dgv, 0, 1);
            bottom_pn.Controls.Add(filter_pn, 0, 0);
            bottom_pn.Dock = DockStyle.Fill;
            bottom_pn.Location = new Point(3, 203);
            bottom_pn.Name = "bottom_pn";
            bottom_pn.RowCount = 2;
            bottom_pn.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            bottom_pn.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            bottom_pn.Size = new Size(1060, 445);
            bottom_pn.TabIndex = 1;
            // 
            // top_pn
            // 
            top_pn.Controls.Add(new_order_btn);
            top_pn.Controls.Add(tableLayoutPanel1);
            top_pn.Dock = DockStyle.Fill;
            top_pn.Location = new Point(3, 3);
            top_pn.Name = "top_pn";
            top_pn.Size = new Size(1060, 194);
            top_pn.TabIndex = 1;
            // 
            // new_order_btn
            // 
            new_order_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            new_order_btn.BackColor = Color.FromArgb(33, 52, 72);
            new_order_btn.Cursor = Cursors.Hand;
            new_order_btn.FlatStyle = FlatStyle.Flat;
            new_order_btn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            new_order_btn.ForeColor = Color.White;
            new_order_btn.Location = new Point(850, 64);
            new_order_btn.Name = "new_order_btn";
            new_order_btn.Size = new Size(178, 66);
            new_order_btn.TabIndex = 3;
            new_order_btn.Text = "New Order";
            new_order_btn.UseVisualStyleBackColor = false;
            new_order_btn.Click += new_order_btn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(84, 119, 146);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(total_order_lbl, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Location = new Point(42, 35);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(337, 129);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // total_order_lbl
            // 
            total_order_lbl.Dock = DockStyle.Fill;
            total_order_lbl.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total_order_lbl.ForeColor = Color.White;
            total_order_lbl.Location = new Point(3, 64);
            total_order_lbl.Name = "total_order_lbl";
            total_order_lbl.Size = new Size(331, 65);
            total_order_lbl.TabIndex = 2;
            total_order_lbl.Text = "0";
            total_order_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(331, 64);
            label2.TabIndex = 0;
            label2.Text = "Total Order";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OrderUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(main_layout);
            Name = "OrderUC";
            Size = new Size(1066, 651);
            Load += OrderUC_Load;
            ((System.ComponentModel.ISupportInitialize)order_dgv).EndInit();
            filter_pn.ResumeLayout(false);
            panel1.ResumeLayout(false);
            search_pn.ResumeLayout(false);
            search_pn.PerformLayout();
            main_layout.ResumeLayout(false);
            bottom_pn.ResumeLayout(false);
            top_pn.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView order_dgv;
        private Panel filter_pn;
        private Panel search_pn;
        private TextBox search_txt;
        private TableLayoutPanel main_layout;
        private TableLayoutPanel bottom_pn;
        private Panel top_pn;
        private TableLayoutPanel tableLayoutPanel1;
        private Label total_order_lbl;
        private Label label2;
        private Button new_order_btn;
        private Label label1;
        private Panel panel1;
        private ComboBox status_cbb;
        private Button clear_btn;
    }
}
