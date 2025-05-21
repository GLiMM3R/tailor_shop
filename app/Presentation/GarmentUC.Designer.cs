namespace app.Presentation
{
    partial class GarmentUC
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
            garment_dvg = new DataGridView();
            main_layout = new TableLayoutPanel();
            bottom_pn = new TableLayoutPanel();
            filter_pn = new Panel();
            search_pn = new Panel();
            search_txt = new TextBox();
            top_pn = new Panel();
            new_garment_btn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            total_garment_lb = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)garment_dvg).BeginInit();
            main_layout.SuspendLayout();
            bottom_pn.SuspendLayout();
            filter_pn.SuspendLayout();
            search_pn.SuspendLayout();
            top_pn.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // garment_dvg
            // 
            garment_dvg.AllowUserToAddRows = false;
            garment_dvg.AllowUserToDeleteRows = false;
            garment_dvg.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            garment_dvg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            garment_dvg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            garment_dvg.Dock = DockStyle.Fill;
            garment_dvg.Location = new Point(9, 110);
            garment_dvg.Margin = new Padding(8);
            garment_dvg.Name = "garment_dvg";
            garment_dvg.ReadOnly = true;
            garment_dvg.RowHeadersWidth = 51;
            garment_dvg.Size = new Size(1176, 443);
            garment_dvg.TabIndex = 0;
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
            main_layout.Size = new Size(1200, 768);
            main_layout.TabIndex = 3;
            // 
            // bottom_pn
            // 
            bottom_pn.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            bottom_pn.ColumnCount = 1;
            bottom_pn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            bottom_pn.Controls.Add(garment_dvg, 0, 1);
            bottom_pn.Controls.Add(filter_pn, 0, 0);
            bottom_pn.Dock = DockStyle.Fill;
            bottom_pn.Location = new Point(3, 203);
            bottom_pn.Name = "bottom_pn";
            bottom_pn.RowCount = 2;
            bottom_pn.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            bottom_pn.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            bottom_pn.Size = new Size(1194, 562);
            bottom_pn.TabIndex = 1;
            // 
            // filter_pn
            // 
            filter_pn.Controls.Add(search_pn);
            filter_pn.Dock = DockStyle.Top;
            filter_pn.Location = new Point(4, 4);
            filter_pn.Name = "filter_pn";
            filter_pn.Size = new Size(1186, 90);
            filter_pn.TabIndex = 1;
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
            // top_pn
            // 
            top_pn.Controls.Add(new_garment_btn);
            top_pn.Controls.Add(tableLayoutPanel1);
            top_pn.Dock = DockStyle.Fill;
            top_pn.Location = new Point(3, 3);
            top_pn.Name = "top_pn";
            top_pn.Size = new Size(1194, 194);
            top_pn.TabIndex = 1;
            // 
            // new_garment_btn
            // 
            new_garment_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            new_garment_btn.BackColor = Color.FromArgb(33, 52, 72);
            new_garment_btn.Cursor = Cursors.Hand;
            new_garment_btn.FlatStyle = FlatStyle.Flat;
            new_garment_btn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            new_garment_btn.ForeColor = Color.White;
            new_garment_btn.Location = new Point(983, 64);
            new_garment_btn.Name = "new_garment_btn";
            new_garment_btn.Size = new Size(178, 66);
            new_garment_btn.TabIndex = 3;
            new_garment_btn.Text = "New Garment";
            new_garment_btn.UseVisualStyleBackColor = false;
            new_garment_btn.Click += new_garment_btn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(84, 119, 146);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(total_garment_lb, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Location = new Point(42, 35);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(337, 129);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // total_garment_lb
            // 
            total_garment_lb.Dock = DockStyle.Fill;
            total_garment_lb.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total_garment_lb.ForeColor = Color.White;
            total_garment_lb.Location = new Point(3, 64);
            total_garment_lb.Name = "total_garment_lb";
            total_garment_lb.Size = new Size(331, 65);
            total_garment_lb.TabIndex = 2;
            total_garment_lb.Text = "0";
            total_garment_lb.TextAlign = ContentAlignment.MiddleCenter;
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
            label2.Text = "Total Garment";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GarmentUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(main_layout);
            Name = "GarmentUC";
            Size = new Size(1200, 768);
            Load += GarmentUC_Load;
            ((System.ComponentModel.ISupportInitialize)garment_dvg).EndInit();
            main_layout.ResumeLayout(false);
            bottom_pn.ResumeLayout(false);
            filter_pn.ResumeLayout(false);
            search_pn.ResumeLayout(false);
            search_pn.PerformLayout();
            top_pn.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView garment_dvg;
        private TableLayoutPanel main_layout;
        private TableLayoutPanel bottom_pn;
        private Panel filter_pn;
        private Panel search_pn;
        private TextBox search_txt;
        private Panel top_pn;
        private TableLayoutPanel tableLayoutPanel1;
        private Label total_garment_lb;
        private Label label2;
        private Button new_garment_btn;
    }
}
