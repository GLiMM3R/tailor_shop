namespace app.Presentation
{
    partial class FabricForm
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
            clear_image_btn = new Button();
            browse_btn = new Button();
            panel4 = new Panel();
            fabric_pb = new PictureBox();
            form_layout = new TableLayoutPanel();
            panel3 = new Panel();
            color_code_txt = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            unit_price_txt = new NumericUpDown();
            label2 = new Label();
            panel1 = new Panel();
            color_name_txt = new TextBox();
            label1 = new Label();
            type_pn = new Panel();
            type_txt = new TextBox();
            name_lb = new Label();
            choose_color_pn = new Panel();
            color_pn = new Panel();
            choose_color_btn = new Button();
            phone_lb = new Label();
            action_layout = new TableLayoutPanel();
            cancel_btn = new Button();
            add_btn = new Button();
            header_lb = new Label();
            root_layout.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fabric_pb).BeginInit();
            form_layout.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)unit_price_txt).BeginInit();
            panel1.SuspendLayout();
            type_pn.SuspendLayout();
            choose_color_pn.SuspendLayout();
            action_layout.SuspendLayout();
            SuspendLayout();
            // 
            // root_layout
            // 
            root_layout.BackColor = Color.White;
            root_layout.BorderStyle = BorderStyle.FixedSingle;
            root_layout.Controls.Add(clear_image_btn);
            root_layout.Controls.Add(browse_btn);
            root_layout.Controls.Add(panel4);
            root_layout.Controls.Add(form_layout);
            root_layout.Controls.Add(action_layout);
            root_layout.Controls.Add(header_lb);
            root_layout.Dock = DockStyle.Fill;
            root_layout.Location = new Point(0, 0);
            root_layout.Name = "root_layout";
            root_layout.Size = new Size(573, 727);
            root_layout.TabIndex = 7;
            // 
            // clear_image_btn
            // 
            clear_image_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            clear_image_btn.BackColor = Color.FromArgb(33, 52, 72);
            clear_image_btn.Cursor = Cursors.Hand;
            clear_image_btn.FlatStyle = FlatStyle.Flat;
            clear_image_btn.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clear_image_btn.ForeColor = Color.White;
            clear_image_btn.Location = new Point(375, 187);
            clear_image_btn.Margin = new Padding(0);
            clear_image_btn.Name = "clear_image_btn";
            clear_image_btn.Size = new Size(131, 57);
            clear_image_btn.TabIndex = 10;
            clear_image_btn.Text = "ລຶບ";
            clear_image_btn.UseVisualStyleBackColor = false;
            clear_image_btn.Click += clear_image_btn_Click;
            // 
            // browse_btn
            // 
            browse_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            browse_btn.BackColor = Color.FromArgb(33, 52, 72);
            browse_btn.Cursor = Cursors.Hand;
            browse_btn.FlatStyle = FlatStyle.Flat;
            browse_btn.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            browse_btn.ForeColor = Color.White;
            browse_btn.Location = new Point(375, 120);
            browse_btn.Margin = new Padding(0);
            browse_btn.Name = "browse_btn";
            browse_btn.Size = new Size(131, 57);
            browse_btn.TabIndex = 9;
            browse_btn.Text = "ເລືອກຮູບ";
            browse_btn.UseVisualStyleBackColor = false;
            browse_btn.Click += browse_btn_Click;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(fabric_pb);
            panel4.Location = new Point(151, 83);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 200);
            panel4.TabIndex = 6;
            // 
            // fabric_pb
            // 
            fabric_pb.Dock = DockStyle.Fill;
            fabric_pb.Location = new Point(0, 0);
            fabric_pb.Name = "fabric_pb";
            fabric_pb.Size = new Size(198, 198);
            fabric_pb.SizeMode = PictureBoxSizeMode.StretchImage;
            fabric_pb.TabIndex = 0;
            fabric_pb.TabStop = false;
            // 
            // form_layout
            // 
            form_layout.BackColor = Color.White;
            form_layout.ColumnCount = 2;
            form_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            form_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            form_layout.Controls.Add(panel3, 1, 1);
            form_layout.Controls.Add(label3, 0, 1);
            form_layout.Controls.Add(panel2, 1, 4);
            form_layout.Controls.Add(label2, 0, 4);
            form_layout.Controls.Add(panel1, 1, 2);
            form_layout.Controls.Add(label1, 0, 2);
            form_layout.Controls.Add(type_pn, 1, 0);
            form_layout.Controls.Add(name_lb, 0, 0);
            form_layout.Controls.Add(choose_color_pn, 1, 3);
            form_layout.Controls.Add(phone_lb, 0, 3);
            form_layout.Location = new Point(31, 305);
            form_layout.Name = "form_layout";
            form_layout.RowCount = 5;
            form_layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            form_layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            form_layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            form_layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            form_layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            form_layout.Size = new Size(506, 337);
            form_layout.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(color_code_txt);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(120, 68);
            panel3.Margin = new Padding(0, 0, 0, 16);
            panel3.Name = "panel3";
            panel3.Size = new Size(386, 52);
            panel3.TabIndex = 11;
            // 
            // color_code_txt
            // 
            color_code_txt.BorderStyle = BorderStyle.None;
            color_code_txt.Cursor = Cursors.IBeam;
            color_code_txt.Font = new Font("Noto Sans Lao", 11.999999F);
            color_code_txt.Location = new Point(16, 9);
            color_code_txt.MaxLength = 100;
            color_code_txt.Name = "color_code_txt";
            color_code_txt.Size = new Size(356, 33);
            color_code_txt.TabIndex = 0;
            // 
            // label3
            // 
            label3.Font = new Font("Noto Sans Lao", 10.1999989F);
            label3.Location = new Point(3, 68);
            label3.Margin = new Padding(3, 0, 3, 16);
            label3.Name = "label3";
            label3.Size = new Size(114, 52);
            label3.TabIndex = 10;
            label3.Text = "ລະຫັດສີ";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(unit_price_txt);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(120, 272);
            panel2.Margin = new Padding(0, 0, 0, 16);
            panel2.Name = "panel2";
            panel2.Size = new Size(386, 49);
            panel2.TabIndex = 9;
            panel2.Visible = false;
            // 
            // unit_price_txt
            // 
            unit_price_txt.BorderStyle = BorderStyle.None;
            unit_price_txt.Font = new Font("Noto Sans Lao", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unit_price_txt.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            unit_price_txt.Location = new Point(15, 5);
            unit_price_txt.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            unit_price_txt.Name = "unit_price_txt";
            unit_price_txt.Size = new Size(357, 41);
            unit_price_txt.TabIndex = 0;
            unit_price_txt.TextAlign = HorizontalAlignment.Center;
            unit_price_txt.ThousandsSeparator = true;
            // 
            // label2
            // 
            label2.Font = new Font("Noto Sans Lao", 10.1999989F);
            label2.Location = new Point(3, 272);
            label2.Margin = new Padding(3, 0, 3, 16);
            label2.Name = "label2";
            label2.Size = new Size(114, 49);
            label2.TabIndex = 8;
            label2.Text = "ລາຄາ";
            label2.TextAlign = ContentAlignment.MiddleRight;
            label2.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(color_name_txt);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(120, 136);
            panel1.Margin = new Padding(0, 0, 0, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(386, 52);
            panel1.TabIndex = 7;
            // 
            // color_name_txt
            // 
            color_name_txt.BorderStyle = BorderStyle.None;
            color_name_txt.Cursor = Cursors.IBeam;
            color_name_txt.Font = new Font("Noto Sans Lao", 11.999999F);
            color_name_txt.Location = new Point(16, 9);
            color_name_txt.MaxLength = 100;
            color_name_txt.Name = "color_name_txt";
            color_name_txt.Size = new Size(356, 33);
            color_name_txt.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Noto Sans Lao", 10.1999989F);
            label1.Location = new Point(3, 136);
            label1.Margin = new Padding(3, 0, 3, 16);
            label1.Name = "label1";
            label1.Size = new Size(114, 52);
            label1.TabIndex = 6;
            label1.Text = "ຊື່ສີ";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // type_pn
            // 
            type_pn.BackColor = Color.White;
            type_pn.BorderStyle = BorderStyle.FixedSingle;
            type_pn.Controls.Add(type_txt);
            type_pn.Dock = DockStyle.Fill;
            type_pn.Location = new Point(120, 0);
            type_pn.Margin = new Padding(0, 0, 0, 16);
            type_pn.Name = "type_pn";
            type_pn.Size = new Size(386, 52);
            type_pn.TabIndex = 0;
            // 
            // type_txt
            // 
            type_txt.BorderStyle = BorderStyle.None;
            type_txt.Cursor = Cursors.IBeam;
            type_txt.Font = new Font("Noto Sans Lao", 11.999999F);
            type_txt.Location = new Point(16, 9);
            type_txt.MaxLength = 100;
            type_txt.Name = "type_txt";
            type_txt.Size = new Size(356, 33);
            type_txt.TabIndex = 0;
            // 
            // name_lb
            // 
            name_lb.Font = new Font("Noto Sans Lao", 10.1999989F);
            name_lb.Location = new Point(3, 0);
            name_lb.Margin = new Padding(3, 0, 3, 16);
            name_lb.Name = "name_lb";
            name_lb.Size = new Size(114, 52);
            name_lb.TabIndex = 1;
            name_lb.Text = "ປະເພດວັດສະດຸ";
            name_lb.TextAlign = ContentAlignment.MiddleRight;
            // 
            // choose_color_pn
            // 
            choose_color_pn.Controls.Add(color_pn);
            choose_color_pn.Controls.Add(choose_color_btn);
            choose_color_pn.Location = new Point(120, 204);
            choose_color_pn.Margin = new Padding(0);
            choose_color_pn.Name = "choose_color_pn";
            choose_color_pn.Size = new Size(386, 57);
            choose_color_pn.TabIndex = 5;
            // 
            // color_pn
            // 
            color_pn.BorderStyle = BorderStyle.FixedSingle;
            color_pn.Location = new Point(0, 0);
            color_pn.Name = "color_pn";
            color_pn.Size = new Size(243, 57);
            color_pn.TabIndex = 9;
            // 
            // choose_color_btn
            // 
            choose_color_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            choose_color_btn.BackColor = Color.FromArgb(33, 52, 72);
            choose_color_btn.Cursor = Cursors.Hand;
            choose_color_btn.FlatStyle = FlatStyle.Flat;
            choose_color_btn.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            choose_color_btn.ForeColor = Color.White;
            choose_color_btn.Location = new Point(255, 0);
            choose_color_btn.Margin = new Padding(0);
            choose_color_btn.Name = "choose_color_btn";
            choose_color_btn.Size = new Size(131, 57);
            choose_color_btn.TabIndex = 8;
            choose_color_btn.Text = "ເລືອກສີ";
            choose_color_btn.UseVisualStyleBackColor = false;
            choose_color_btn.Click += choose_color_btn_Click;
            // 
            // phone_lb
            // 
            phone_lb.Font = new Font("Noto Sans Lao", 10.1999989F);
            phone_lb.Location = new Point(3, 204);
            phone_lb.Margin = new Padding(3, 0, 3, 16);
            phone_lb.Name = "phone_lb";
            phone_lb.Size = new Size(114, 52);
            phone_lb.TabIndex = 4;
            phone_lb.Text = "ຄ່າສີ";
            phone_lb.TextAlign = ContentAlignment.MiddleRight;
            // 
            // action_layout
            // 
            action_layout.BackColor = Color.White;
            action_layout.ColumnCount = 2;
            action_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            action_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            action_layout.Controls.Add(cancel_btn, 0, 0);
            action_layout.Controls.Add(add_btn, 1, 0);
            action_layout.Location = new Point(34, 645);
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
            cancel_btn.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold);
            cancel_btn.Location = new Point(0, 0);
            cancel_btn.Margin = new Padding(0);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(141, 61);
            cancel_btn.TabIndex = 0;
            cancel_btn.Text = "ຍົກເລີກ";
            cancel_btn.UseVisualStyleBackColor = false;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // add_btn
            // 
            add_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            add_btn.BackColor = Color.FromArgb(33, 52, 72);
            add_btn.Cursor = Cursors.Hand;
            add_btn.FlatStyle = FlatStyle.Flat;
            add_btn.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold);
            add_btn.ForeColor = Color.White;
            add_btn.Location = new Point(355, 0);
            add_btn.Margin = new Padding(0);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(151, 61);
            add_btn.TabIndex = 1;
            add_btn.Text = "ເພີ່ມ";
            add_btn.UseVisualStyleBackColor = false;
            add_btn.Click += add_btn_Click;
            // 
            // header_lb
            // 
            header_lb.BackColor = Color.FromArgb(33, 52, 72);
            header_lb.Dock = DockStyle.Top;
            header_lb.Font = new Font("Noto Sans Lao", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            header_lb.ForeColor = Color.White;
            header_lb.Location = new Point(0, 0);
            header_lb.Name = "header_lb";
            header_lb.Size = new Size(571, 60);
            header_lb.TabIndex = 2;
            header_lb.Text = "ຟອມຜ້າ";
            header_lb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FabricForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 727);
            Controls.Add(root_layout);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FabricForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FabricForm";
            Load += FabricForm_Load;
            root_layout.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)fabric_pb).EndInit();
            form_layout.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)unit_price_txt).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            type_pn.ResumeLayout(false);
            type_pn.PerformLayout();
            choose_color_pn.ResumeLayout(false);
            action_layout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel root_layout;
        private TableLayoutPanel form_layout;
        private Panel type_pn;
        private TextBox type_txt;
        private Label name_lb;
        private Label phone_lb;
        private TableLayoutPanel action_layout;
        private Button cancel_btn;
        private Button add_btn;
        private Label header_lb;
        private Panel choose_color_pn;
        private Panel color_pn;
        private Button choose_color_btn;
        private Panel panel1;
        private TextBox color_name_txt;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private NumericUpDown unit_price_txt;
        private Panel panel3;
        private TextBox color_code_txt;
        private Label label3;
        private Panel panel4;
        private Button clear_image_btn;
        private Button browse_btn;
        private PictureBox fabric_pb;
    }
}