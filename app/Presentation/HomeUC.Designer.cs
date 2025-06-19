namespace app.Presentation
{
    partial class HomeUC
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            root_pn = new Panel();
            panel2 = new Panel();
            line_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label1 = new Label();
            panel3 = new Panel();
            donut_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label5 = new Label();
            panel4 = new Panel();
            order_dgv = new DataGridView();
            label6 = new Label();
            panel1 = new Panel();
            gross_sales_pn = new TableLayoutPanel();
            total_orders_lbl = new Label();
            label2 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            new_customers_lbl = new Label();
            label4 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            total_amount_lbl = new Label();
            label3 = new Label();
            root_pn.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)line_chart).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)donut_chart).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)order_dgv).BeginInit();
            panel1.SuspendLayout();
            gross_sales_pn.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // root_pn
            // 
            root_pn.Controls.Add(panel2);
            root_pn.Controls.Add(panel3);
            root_pn.Controls.Add(panel4);
            root_pn.Controls.Add(panel1);
            root_pn.Dock = DockStyle.Fill;
            root_pn.Font = new Font("Noto Sans Lao", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            root_pn.Location = new Point(0, 0);
            root_pn.Name = "root_pn";
            root_pn.Size = new Size(1446, 900);
            root_pn.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(line_chart);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 184);
            panel2.Name = "panel2";
            panel2.Size = new Size(816, 350);
            panel2.TabIndex = 7;
            // 
            // line_chart
            // 
            chartArea1.Name = "ChartArea1";
            line_chart.ChartAreas.Add(chartArea1);
            line_chart.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            line_chart.Legends.Add(legend1);
            line_chart.Location = new Point(0, 46);
            line_chart.Name = "line_chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            line_chart.Series.Add(series1);
            line_chart.Size = new Size(816, 304);
            line_chart.TabIndex = 0;
            line_chart.Text = "Total Sales";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Noto Sans Lao", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(20, 0, 0, 0);
            label1.Size = new Size(816, 46);
            label1.TabIndex = 1;
            label1.Text = "ຍອດລາຍຮັບ";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.Controls.Add(donut_chart);
            panel3.Controls.Add(label5);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(816, 184);
            panel3.Name = "panel3";
            panel3.Size = new Size(630, 350);
            panel3.TabIndex = 8;
            // 
            // donut_chart
            // 
            chartArea2.Name = "ChartArea1";
            donut_chart.ChartAreas.Add(chartArea2);
            donut_chart.Dock = DockStyle.Fill;
            legend2.Name = "Legend1";
            donut_chart.Legends.Add(legend2);
            donut_chart.Location = new Point(0, 46);
            donut_chart.Name = "donut_chart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            donut_chart.Series.Add(series2);
            donut_chart.Size = new Size(630, 304);
            donut_chart.TabIndex = 1;
            donut_chart.Text = "chart2";
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Noto Sans Lao", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Padding = new Padding(20, 0, 0, 0);
            label5.Size = new Size(630, 46);
            label5.TabIndex = 2;
            label5.Text = "ຍອດລວມການຊຳລະເງິນ";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(order_dgv);
            panel4.Controls.Add(label6);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 534);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(20, 0, 20, 0);
            panel4.Size = new Size(1446, 366);
            panel4.TabIndex = 6;
            // 
            // order_dgv
            // 
            order_dgv.AllowUserToAddRows = false;
            order_dgv.AllowUserToDeleteRows = false;
            order_dgv.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            order_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            order_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            order_dgv.Dock = DockStyle.Fill;
            order_dgv.Location = new Point(20, 46);
            order_dgv.Margin = new Padding(8);
            order_dgv.Name = "order_dgv";
            order_dgv.ReadOnly = true;
            order_dgv.RowHeadersWidth = 51;
            order_dgv.Size = new Size(1406, 320);
            order_dgv.TabIndex = 4;
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("Noto Sans Lao", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(20, 0);
            label6.Name = "label6";
            label6.Size = new Size(1406, 46);
            label6.TabIndex = 3;
            label6.Text = "ລາຍການສັ່ງຕັດລ່າສຸດ";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(gross_sales_pn);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1446, 184);
            panel1.TabIndex = 6;
            // 
            // gross_sales_pn
            // 
            gross_sales_pn.BackColor = Color.FromArgb(84, 119, 146);
            gross_sales_pn.ColumnCount = 1;
            gross_sales_pn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            gross_sales_pn.Controls.Add(total_orders_lbl, 0, 1);
            gross_sales_pn.Controls.Add(label2, 0, 0);
            gross_sales_pn.Location = new Point(32, 32);
            gross_sales_pn.Name = "gross_sales_pn";
            gross_sales_pn.RowCount = 2;
            gross_sales_pn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            gross_sales_pn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            gross_sales_pn.Size = new Size(240, 120);
            gross_sales_pn.TabIndex = 3;
            // 
            // total_orders_lbl
            // 
            total_orders_lbl.Dock = DockStyle.Fill;
            total_orders_lbl.Font = new Font("Noto Sans", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total_orders_lbl.ForeColor = Color.White;
            total_orders_lbl.Location = new Point(3, 60);
            total_orders_lbl.Name = "total_orders_lbl";
            total_orders_lbl.Size = new Size(234, 60);
            total_orders_lbl.TabIndex = 2;
            total_orders_lbl.Text = "0";
            total_orders_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Noto Sans Lao", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(234, 60);
            label2.TabIndex = 0;
            label2.Text = "ຈຳນວນສັ່ງຕັດເດືອນນີ້";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(84, 119, 146);
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(new_customers_lbl, 0, 1);
            tableLayoutPanel2.Controls.Add(label4, 0, 0);
            tableLayoutPanel2.Location = new Point(635, 32);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(240, 120);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // new_customers_lbl
            // 
            new_customers_lbl.Dock = DockStyle.Fill;
            new_customers_lbl.Font = new Font("Noto Sans", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            new_customers_lbl.ForeColor = Color.White;
            new_customers_lbl.Location = new Point(3, 60);
            new_customers_lbl.Name = "new_customers_lbl";
            new_customers_lbl.Size = new Size(234, 60);
            new_customers_lbl.TabIndex = 2;
            new_customers_lbl.Text = "0";
            new_customers_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Noto Sans Lao", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(234, 60);
            label4.TabIndex = 0;
            label4.Text = "ລູກຄ້າໃໝ່";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(84, 119, 146);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(total_amount_lbl, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Location = new Point(332, 32);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(240, 120);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // total_amount_lbl
            // 
            total_amount_lbl.Dock = DockStyle.Fill;
            total_amount_lbl.Font = new Font("Noto Sans", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total_amount_lbl.ForeColor = Color.White;
            total_amount_lbl.Location = new Point(3, 60);
            total_amount_lbl.Name = "total_amount_lbl";
            total_amount_lbl.Size = new Size(234, 60);
            total_amount_lbl.TabIndex = 2;
            total_amount_lbl.Text = "0";
            total_amount_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Noto Sans Lao", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(234, 60);
            label3.TabIndex = 0;
            label3.Text = "ຍອດລວມສຸດທິ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HomeUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(root_pn);
            Name = "HomeUC";
            Size = new Size(1446, 900);
            Load += HomeUC_Load;
            root_pn.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)line_chart).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)donut_chart).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)order_dgv).EndInit();
            panel1.ResumeLayout(false);
            gross_sales_pn.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel root_pn;
        private TableLayoutPanel tableLayoutPanel2;
        private Label new_customers_lbl;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel1;
        private Label total_amount_lbl;
        private Label label3;
        private TableLayoutPanel gross_sales_pn;
        private Label total_orders_lbl;
        private Label label2;
        private Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart donut_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart line_chart;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private Label label5;
        private Label label6;
        private DataGridView order_dgv;
    }
}
