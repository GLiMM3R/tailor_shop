namespace app.Presentation
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            form_layout = new TableLayoutPanel();
            address_pn = new Panel();
            address_txt = new TextBox();
            address_lb = new Label();
            phone_pn = new Panel();
            phone_txt = new TextBox();
            phone_lb = new Label();
            gender_lb = new Label();
            name_pn = new Panel();
            name_txt = new TextBox();
            name_lb = new Label();
            gender_pn = new Panel();
            gender_female_rb = new RadioButton();
            gender_male_rb = new RadioButton();
            action_layout = new TableLayoutPanel();
            cancel_btn = new Button();
            add_btn = new Button();
            header_lb = new Label();
            root_layout = new Panel();
            form_layout.SuspendLayout();
            address_pn.SuspendLayout();
            phone_pn.SuspendLayout();
            name_pn.SuspendLayout();
            gender_pn.SuspendLayout();
            action_layout.SuspendLayout();
            root_layout.SuspendLayout();
            SuspendLayout();
            // 
            // form_layout
            // 
            form_layout.BackColor = Color.White;
            form_layout.ColumnCount = 2;
            form_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            form_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            form_layout.Controls.Add(address_pn, 1, 3);
            form_layout.Controls.Add(address_lb, 0, 3);
            form_layout.Controls.Add(phone_pn, 1, 2);
            form_layout.Controls.Add(phone_lb, 0, 2);
            form_layout.Controls.Add(gender_lb, 0, 1);
            form_layout.Controls.Add(name_pn, 1, 0);
            form_layout.Controls.Add(name_lb, 0, 0);
            form_layout.Controls.Add(gender_pn, 1, 1);
            form_layout.Location = new Point(32, 100);
            form_layout.Name = "form_layout";
            form_layout.RowCount = 4;
            form_layout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            form_layout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            form_layout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            form_layout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            form_layout.Size = new Size(506, 275);
            form_layout.TabIndex = 0;
            // 
            // address_pn
            // 
            address_pn.BackColor = Color.White;
            address_pn.BorderStyle = BorderStyle.FixedSingle;
            address_pn.Controls.Add(address_txt);
            address_pn.Dock = DockStyle.Fill;
            address_pn.Location = new Point(101, 204);
            address_pn.Margin = new Padding(0, 0, 0, 16);
            address_pn.Name = "address_pn";
            address_pn.Size = new Size(405, 55);
            address_pn.TabIndex = 7;
            // 
            // address_txt
            // 
            address_txt.BorderStyle = BorderStyle.None;
            address_txt.Cursor = Cursors.IBeam;
            address_txt.Font = new Font("Noto Sans Lao", 11.999999F);
            address_txt.Location = new Point(15, 10);
            address_txt.MaxLength = 200;
            address_txt.Name = "address_txt";
            address_txt.Size = new Size(372, 33);
            address_txt.TabIndex = 1;
            // 
            // address_lb
            // 
            address_lb.Font = new Font("Noto Sans Lao", 10.1999989F);
            address_lb.Location = new Point(3, 204);
            address_lb.Margin = new Padding(3, 0, 3, 16);
            address_lb.Name = "address_lb";
            address_lb.Size = new Size(95, 55);
            address_lb.TabIndex = 6;
            address_lb.Text = "ທີ່ຢູ່";
            address_lb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // phone_pn
            // 
            phone_pn.BackColor = Color.White;
            phone_pn.BorderStyle = BorderStyle.FixedSingle;
            phone_pn.Controls.Add(phone_txt);
            phone_pn.Dock = DockStyle.Fill;
            phone_pn.Location = new Point(101, 136);
            phone_pn.Margin = new Padding(0, 0, 0, 18);
            phone_pn.Name = "phone_pn";
            phone_pn.Size = new Size(405, 50);
            phone_pn.TabIndex = 5;
            // 
            // phone_txt
            // 
            phone_txt.BorderStyle = BorderStyle.None;
            phone_txt.Cursor = Cursors.IBeam;
            phone_txt.Font = new Font("Noto Sans Lao", 11.999999F);
            phone_txt.Location = new Point(15, 8);
            phone_txt.MaxLength = 12;
            phone_txt.Name = "phone_txt";
            phone_txt.Size = new Size(372, 33);
            phone_txt.TabIndex = 1;
            // 
            // phone_lb
            // 
            phone_lb.Font = new Font("Noto Sans Lao", 10.1999989F);
            phone_lb.Location = new Point(3, 136);
            phone_lb.Margin = new Padding(3, 0, 3, 16);
            phone_lb.Name = "phone_lb";
            phone_lb.Size = new Size(95, 52);
            phone_lb.TabIndex = 4;
            phone_lb.Text = "ເບີໂທ";
            phone_lb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gender_lb
            // 
            gender_lb.Font = new Font("Noto Sans Lao", 10.1999989F);
            gender_lb.Location = new Point(3, 68);
            gender_lb.Margin = new Padding(3, 0, 3, 16);
            gender_lb.Name = "gender_lb";
            gender_lb.Size = new Size(95, 52);
            gender_lb.TabIndex = 2;
            gender_lb.Text = "ເພດ";
            gender_lb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // name_pn
            // 
            name_pn.BackColor = Color.White;
            name_pn.BorderStyle = BorderStyle.FixedSingle;
            name_pn.Controls.Add(name_txt);
            name_pn.Dock = DockStyle.Fill;
            name_pn.Location = new Point(101, 0);
            name_pn.Margin = new Padding(0, 0, 0, 16);
            name_pn.Name = "name_pn";
            name_pn.Size = new Size(405, 52);
            name_pn.TabIndex = 0;
            // 
            // name_txt
            // 
            name_txt.BorderStyle = BorderStyle.None;
            name_txt.Cursor = Cursors.IBeam;
            name_txt.Font = new Font("Noto Sans Lao", 11.999999F);
            name_txt.Location = new Point(16, 9);
            name_txt.MaxLength = 100;
            name_txt.Name = "name_txt";
            name_txt.Size = new Size(372, 33);
            name_txt.TabIndex = 0;
            // 
            // name_lb
            // 
            name_lb.Font = new Font("Noto Sans Lao", 10.1999989F);
            name_lb.Location = new Point(3, 0);
            name_lb.Margin = new Padding(3, 0, 3, 16);
            name_lb.Name = "name_lb";
            name_lb.Size = new Size(95, 52);
            name_lb.TabIndex = 1;
            name_lb.Text = "ຊື່";
            name_lb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gender_pn
            // 
            gender_pn.Controls.Add(gender_female_rb);
            gender_pn.Controls.Add(gender_male_rb);
            gender_pn.Dock = DockStyle.Fill;
            gender_pn.Location = new Point(101, 68);
            gender_pn.Margin = new Padding(0, 0, 0, 16);
            gender_pn.Name = "gender_pn";
            gender_pn.Size = new Size(405, 52);
            gender_pn.TabIndex = 3;
            // 
            // gender_female_rb
            // 
            gender_female_rb.AutoSize = true;
            gender_female_rb.Font = new Font("Noto Sans Lao", 10.1999989F);
            gender_female_rb.Location = new Point(123, 10);
            gender_female_rb.Name = "gender_female_rb";
            gender_female_rb.Size = new Size(49, 32);
            gender_female_rb.TabIndex = 1;
            gender_female_rb.TabStop = true;
            gender_female_rb.Text = "ຍິງ";
            gender_female_rb.UseVisualStyleBackColor = true;
            // 
            // gender_male_rb
            // 
            gender_male_rb.AutoSize = true;
            gender_male_rb.Font = new Font("Noto Sans Lao", 10.1999989F);
            gender_male_rb.Location = new Point(33, 10);
            gender_male_rb.Name = "gender_male_rb";
            gender_male_rb.Size = new Size(59, 32);
            gender_male_rb.TabIndex = 0;
            gender_male_rb.TabStop = true;
            gender_male_rb.Text = "ຊາຍ";
            gender_male_rb.UseVisualStyleBackColor = true;
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
            action_layout.Name = "action_layout";
            action_layout.RowCount = 1;
            action_layout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            action_layout.Size = new Size(506, 61);
            action_layout.TabIndex = 1;
            // 
            // cancel_btn
            // 
            cancel_btn.BackColor = Color.White;
            cancel_btn.Cursor = Cursors.Hand;
            cancel_btn.FlatStyle = FlatStyle.Flat;
            cancel_btn.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold);
            cancel_btn.Location = new Point(3, 3);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(141, 55);
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
            add_btn.Location = new Point(360, 3);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(143, 55);
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
            header_lb.Size = new Size(569, 60);
            header_lb.TabIndex = 2;
            header_lb.Text = "ຟອມລູກຄ້າ";
            header_lb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // root_layout
            // 
            root_layout.BackColor = Color.White;
            root_layout.BorderStyle = BorderStyle.FixedSingle;
            root_layout.Controls.Add(action_layout);
            root_layout.Controls.Add(form_layout);
            root_layout.Controls.Add(header_lb);
            root_layout.Dock = DockStyle.Fill;
            root_layout.Location = new Point(0, 0);
            root_layout.Name = "root_layout";
            root_layout.Size = new Size(571, 494);
            root_layout.TabIndex = 3;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(571, 494);
            Controls.Add(root_layout);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer Form";
            Load += CustomerForm_Load;
            form_layout.ResumeLayout(false);
            address_pn.ResumeLayout(false);
            address_pn.PerformLayout();
            phone_pn.ResumeLayout(false);
            phone_pn.PerformLayout();
            name_pn.ResumeLayout(false);
            name_pn.PerformLayout();
            gender_pn.ResumeLayout(false);
            gender_pn.PerformLayout();
            action_layout.ResumeLayout(false);
            root_layout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel form_layout;
        private TableLayoutPanel action_layout;
        private Label header_lb;
        private Label gender_lb;
        private Panel name_pn;
        private Label name_lb;
        private Panel gender_pn;
        private RadioButton gender_female_rb;
        private RadioButton gender_male_rb;
        private Panel address_pn;
        private Label address_lb;
        private Panel phone_pn;
        private Label phone_lb;
        private Button cancel_btn;
        private Button add_btn;
        private Panel root_layout;
        private TextBox name_txt;
        private TextBox address_txt;
        private TextBox phone_txt;
    }
}