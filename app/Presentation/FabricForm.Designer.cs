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
            type_pn = new Panel();
            type_txt = new TextBox();
            name_lb = new Label();
            action_layout = new TableLayoutPanel();
            cancel_btn = new Button();
            add_btn = new Button();
            header_lb = new Label();
            root_layout.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fabric_pb).BeginInit();
            form_layout.SuspendLayout();
            panel3.SuspendLayout();
            type_pn.SuspendLayout();
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
            root_layout.Size = new Size(573, 552);
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
            form_layout.Controls.Add(type_pn, 1, 0);
            form_layout.Controls.Add(name_lb, 0, 0);
            form_layout.Location = new Point(31, 305);
            form_layout.Name = "form_layout";
            form_layout.RowCount = 2;
            form_layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            form_layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            form_layout.Size = new Size(506, 135);
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
            // action_layout
            // 
            action_layout.BackColor = Color.White;
            action_layout.ColumnCount = 2;
            action_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            action_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            action_layout.Controls.Add(cancel_btn, 0, 0);
            action_layout.Controls.Add(add_btn, 1, 0);
            action_layout.Location = new Point(31, 456);
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
            ClientSize = new Size(573, 552);
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
            type_pn.ResumeLayout(false);
            type_pn.PerformLayout();
            action_layout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel root_layout;
        private TableLayoutPanel form_layout;
        private Panel type_pn;
        private TextBox type_txt;
        private Label name_lb;
        private TableLayoutPanel action_layout;
        private Button cancel_btn;
        private Button add_btn;
        private Label header_lb;
        private Panel panel3;
        private TextBox color_code_txt;
        private Label label3;
        private Panel panel4;
        private Button clear_image_btn;
        private Button browse_btn;
        private PictureBox fabric_pb;
    }
}