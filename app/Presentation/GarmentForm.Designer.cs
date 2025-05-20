namespace app.Presentation
{
    partial class GarmentForm
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
            form_layout = new TableLayoutPanel();
            panel1 = new Panel();
            description_txt = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            base_price_num = new NumericUpDown();
            type_pn = new Panel();
            name_txt = new TextBox();
            name_lb = new Label();
            label2 = new Label();
            action_layout = new TableLayoutPanel();
            cancel_btn = new Button();
            add_btn = new Button();
            header_lb = new Label();
            root_layout.SuspendLayout();
            form_layout.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)base_price_num).BeginInit();
            type_pn.SuspendLayout();
            action_layout.SuspendLayout();
            SuspendLayout();
            // 
            // root_layout
            // 
            root_layout.BackColor = Color.White;
            root_layout.BorderStyle = BorderStyle.FixedSingle;
            root_layout.Controls.Add(form_layout);
            root_layout.Controls.Add(action_layout);
            root_layout.Controls.Add(header_lb);
            root_layout.Dock = DockStyle.Fill;
            root_layout.Location = new Point(0, 0);
            root_layout.Name = "root_layout";
            root_layout.Size = new Size(570, 498);
            root_layout.TabIndex = 8;
            // 
            // form_layout
            // 
            form_layout.BackColor = Color.White;
            form_layout.ColumnCount = 2;
            form_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            form_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            form_layout.Controls.Add(panel1, 1, 2);
            form_layout.Controls.Add(label1, 0, 2);
            form_layout.Controls.Add(panel2, 1, 1);
            form_layout.Controls.Add(type_pn, 1, 0);
            form_layout.Controls.Add(name_lb, 0, 0);
            form_layout.Controls.Add(label2, 0, 1);
            form_layout.Location = new Point(32, 100);
            form_layout.Name = "form_layout";
            form_layout.RowCount = 3;
            form_layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            form_layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            form_layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            form_layout.Size = new Size(506, 269);
            form_layout.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(description_txt);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(120, 136);
            panel1.Margin = new Padding(0, 0, 0, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(386, 117);
            panel1.TabIndex = 12;
            // 
            // description_txt
            // 
            description_txt.BorderStyle = BorderStyle.None;
            description_txt.Cursor = Cursors.IBeam;
            description_txt.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            description_txt.Location = new Point(16, 2);
            description_txt.MaxLength = 200;
            description_txt.Multiline = true;
            description_txt.Name = "description_txt";
            description_txt.Size = new Size(356, 110);
            description_txt.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 136);
            label1.Margin = new Padding(3, 0, 3, 16);
            label1.Name = "label1";
            label1.Size = new Size(114, 52);
            label1.TabIndex = 11;
            label1.Text = "Description";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(base_price_num);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(120, 68);
            panel2.Margin = new Padding(0, 0, 0, 16);
            panel2.Name = "panel2";
            panel2.Size = new Size(386, 52);
            panel2.TabIndex = 10;
            // 
            // base_price_num
            // 
            base_price_num.BorderStyle = BorderStyle.None;
            base_price_num.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            base_price_num.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            base_price_num.Location = new Point(15, 11);
            base_price_num.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            base_price_num.Name = "base_price_num";
            base_price_num.Size = new Size(357, 30);
            base_price_num.TabIndex = 0;
            base_price_num.TextAlign = HorizontalAlignment.Center;
            base_price_num.ThousandsSeparator = true;
            // 
            // type_pn
            // 
            type_pn.BackColor = Color.White;
            type_pn.BorderStyle = BorderStyle.FixedSingle;
            type_pn.Controls.Add(name_txt);
            type_pn.Dock = DockStyle.Fill;
            type_pn.Location = new Point(120, 0);
            type_pn.Margin = new Padding(0, 0, 0, 16);
            type_pn.Name = "type_pn";
            type_pn.Size = new Size(386, 52);
            type_pn.TabIndex = 0;
            // 
            // name_txt
            // 
            name_txt.BorderStyle = BorderStyle.None;
            name_txt.Cursor = Cursors.IBeam;
            name_txt.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name_txt.Location = new Point(16, 12);
            name_txt.MaxLength = 100;
            name_txt.Name = "name_txt";
            name_txt.Size = new Size(356, 27);
            name_txt.TabIndex = 0;
            // 
            // name_lb
            // 
            name_lb.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name_lb.Location = new Point(3, 0);
            name_lb.Margin = new Padding(3, 0, 3, 16);
            name_lb.Name = "name_lb";
            name_lb.Size = new Size(114, 52);
            name_lb.TabIndex = 1;
            name_lb.Text = "Name";
            name_lb.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 68);
            label2.Margin = new Padding(3, 0, 3, 16);
            label2.Name = "label2";
            label2.Size = new Size(114, 52);
            label2.TabIndex = 8;
            label2.Text = "Base Price";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // action_layout
            // 
            action_layout.BackColor = Color.White;
            action_layout.ColumnCount = 2;
            action_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            action_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            action_layout.Controls.Add(cancel_btn, 0, 0);
            action_layout.Controls.Add(add_btn, 1, 0);
            action_layout.Location = new Point(32, 403);
            action_layout.Margin = new Padding(0);
            action_layout.Name = "action_layout";
            action_layout.RowCount = 1;
            action_layout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            action_layout.Size = new Size(506, 61);
            action_layout.TabIndex = 5;
            // 
            // cancel_btn
            // 
            cancel_btn.BackColor = Color.LightGray;
            cancel_btn.Cursor = Cursors.Hand;
            cancel_btn.FlatStyle = FlatStyle.Flat;
            cancel_btn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancel_btn.Location = new Point(0, 0);
            cancel_btn.Margin = new Padding(0);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(141, 61);
            cancel_btn.TabIndex = 0;
            cancel_btn.Text = "Cancel";
            cancel_btn.UseVisualStyleBackColor = false;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // add_btn
            // 
            add_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            add_btn.BackColor = Color.FromArgb(33, 52, 72);
            add_btn.Cursor = Cursors.Hand;
            add_btn.FlatStyle = FlatStyle.Flat;
            add_btn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_btn.ForeColor = Color.White;
            add_btn.Location = new Point(310, 0);
            add_btn.Margin = new Padding(0);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(196, 61);
            add_btn.TabIndex = 1;
            add_btn.Text = "Add Garment";
            add_btn.UseVisualStyleBackColor = false;
            add_btn.Click += add_btn_Click;
            // 
            // header_lb
            // 
            header_lb.AutoSize = true;
            header_lb.BackColor = Color.White;
            header_lb.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            header_lb.Location = new Point(179, 31);
            header_lb.Name = "header_lb";
            header_lb.Size = new Size(220, 35);
            header_lb.TabIndex = 2;
            header_lb.Text = "Garment Form";
            // 
            // GarmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 498);
            Controls.Add(root_layout);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GarmentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GarmentForm";
            Load += GarmentForm_Load;
            root_layout.ResumeLayout(false);
            root_layout.PerformLayout();
            form_layout.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)base_price_num).EndInit();
            type_pn.ResumeLayout(false);
            type_pn.PerformLayout();
            action_layout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel root_layout;
        private TableLayoutPanel form_layout;
        private Label label2;
        private Panel type_pn;
        private TextBox name_txt;
        private Label name_lb;
        private TableLayoutPanel action_layout;
        private Button cancel_btn;
        private Button add_btn;
        private Label header_lb;
        private Panel panel1;
        private TextBox description_txt;
        private Label label1;
        private Panel panel2;
        private NumericUpDown base_price_num;
    }
}