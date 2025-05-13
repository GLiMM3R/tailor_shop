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
            form_layout = new TableLayoutPanel();
            type_pn = new Panel();
            type_txt = new TextBox();
            name_lb = new Label();
            phone_lb = new Label();
            panel1 = new Panel();
            color_pn = new Panel();
            choose_color_btn = new Button();
            action_layout = new TableLayoutPanel();
            cancel_btn = new Button();
            add_btn = new Button();
            header_lb = new Label();
            root_layout.SuspendLayout();
            form_layout.SuspendLayout();
            type_pn.SuspendLayout();
            panel1.SuspendLayout();
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
            root_layout.Size = new Size(565, 424);
            root_layout.TabIndex = 7;
            // 
            // form_layout
            // 
            form_layout.BackColor = Color.White;
            form_layout.ColumnCount = 2;
            form_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            form_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            form_layout.Controls.Add(type_pn, 1, 0);
            form_layout.Controls.Add(name_lb, 0, 0);
            form_layout.Controls.Add(phone_lb, 0, 1);
            form_layout.Controls.Add(panel1, 1, 1);
            form_layout.Location = new Point(32, 100);
            form_layout.Name = "form_layout";
            form_layout.RowCount = 2;
            form_layout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            form_layout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            form_layout.Size = new Size(506, 147);
            form_layout.TabIndex = 4;
            // 
            // type_pn
            // 
            type_pn.BackColor = Color.White;
            type_pn.BorderStyle = BorderStyle.FixedSingle;
            type_pn.Controls.Add(type_txt);
            type_pn.Dock = DockStyle.Fill;
            type_pn.Location = new Point(101, 0);
            type_pn.Margin = new Padding(0, 0, 0, 16);
            type_pn.Name = "type_pn";
            type_pn.Size = new Size(405, 57);
            type_pn.TabIndex = 0;
            // 
            // type_txt
            // 
            type_txt.BorderStyle = BorderStyle.None;
            type_txt.Cursor = Cursors.IBeam;
            type_txt.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            type_txt.Location = new Point(16, 12);
            type_txt.MaxLength = 100;
            type_txt.Name = "type_txt";
            type_txt.Size = new Size(372, 27);
            type_txt.TabIndex = 0;
            // 
            // name_lb
            // 
            name_lb.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name_lb.Location = new Point(3, 0);
            name_lb.Margin = new Padding(3, 0, 3, 16);
            name_lb.Name = "name_lb";
            name_lb.Size = new Size(95, 52);
            name_lb.TabIndex = 1;
            name_lb.Text = "Type";
            name_lb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // phone_lb
            // 
            phone_lb.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phone_lb.Location = new Point(3, 73);
            phone_lb.Margin = new Padding(3, 0, 3, 16);
            phone_lb.Name = "phone_lb";
            phone_lb.Size = new Size(95, 52);
            phone_lb.TabIndex = 4;
            phone_lb.Text = "Color";
            phone_lb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(color_pn);
            panel1.Controls.Add(choose_color_btn);
            panel1.Location = new Point(104, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(399, 57);
            panel1.TabIndex = 5;
            // 
            // color_pn
            // 
            color_pn.Location = new Point(-3, 0);
            color_pn.Name = "color_pn";
            color_pn.Size = new Size(261, 57);
            color_pn.TabIndex = 9;
            // 
            // choose_color_btn
            // 
            choose_color_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            choose_color_btn.BackColor = Color.FromArgb(33, 52, 72);
            choose_color_btn.Cursor = Cursors.Hand;
            choose_color_btn.FlatStyle = FlatStyle.Flat;
            choose_color_btn.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            choose_color_btn.ForeColor = Color.White;
            choose_color_btn.Location = new Point(264, -3);
            choose_color_btn.Name = "choose_color_btn";
            choose_color_btn.Size = new Size(135, 60);
            choose_color_btn.TabIndex = 8;
            choose_color_btn.Text = "Choose Color";
            choose_color_btn.UseVisualStyleBackColor = false;
            choose_color_btn.Click += choose_color_btn_Click;
            // 
            // action_layout
            // 
            action_layout.BackColor = Color.White;
            action_layout.ColumnCount = 2;
            action_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            action_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            action_layout.Controls.Add(cancel_btn, 0, 0);
            action_layout.Controls.Add(add_btn, 1, 0);
            action_layout.Location = new Point(31, 319);
            action_layout.Name = "action_layout";
            action_layout.RowCount = 1;
            action_layout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            action_layout.Size = new Size(506, 61);
            action_layout.TabIndex = 5;
            // 
            // cancel_btn
            // 
            cancel_btn.BackColor = Color.White;
            cancel_btn.Cursor = Cursors.Hand;
            cancel_btn.FlatStyle = FlatStyle.Flat;
            cancel_btn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancel_btn.Location = new Point(3, 3);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(141, 55);
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
            add_btn.Location = new Point(343, 3);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(160, 55);
            add_btn.TabIndex = 1;
            add_btn.Text = "Add Fabric";
            add_btn.UseVisualStyleBackColor = false;
            add_btn.Click += add_btn_Click;
            // 
            // header_lb
            // 
            header_lb.AutoSize = true;
            header_lb.BackColor = Color.White;
            header_lb.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            header_lb.Location = new Point(211, 36);
            header_lb.Name = "header_lb";
            header_lb.Size = new Size(187, 35);
            header_lb.TabIndex = 2;
            header_lb.Text = "Fabric Form";
            // 
            // FabricForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 424);
            Controls.Add(root_layout);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FabricForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FabricForm";
            root_layout.ResumeLayout(false);
            root_layout.PerformLayout();
            form_layout.ResumeLayout(false);
            type_pn.ResumeLayout(false);
            type_pn.PerformLayout();
            panel1.ResumeLayout(false);
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
        private Panel panel1;
        private Panel color_pn;
        private Button choose_color_btn;
    }
}