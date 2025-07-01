namespace app.Presentation
{
    partial class MeasurementsForm
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
            measurements_dgv = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)measurements_dgv).BeginInit();
            SuspendLayout();
            // 
            // measurements_dgv
            // 
            measurements_dgv.BackgroundColor = Color.White;
            measurements_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            measurements_dgv.Dock = DockStyle.Fill;
            measurements_dgv.Location = new Point(0, 0);
            measurements_dgv.Name = "measurements_dgv";
            measurements_dgv.RowHeadersWidth = 51;
            measurements_dgv.Size = new Size(968, 638);
            measurements_dgv.TabIndex = 0;
            // 
            // MeasurementsForm
            // 
            AutoScaleDimensions = new SizeF(12F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(968, 638);
            Controls.Add(measurements_dgv);
            Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MeasurementsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Measurements";
            Load += MeasurementsForm_Load;
            ((System.ComponentModel.ISupportInitialize)measurements_dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView measurements_dgv;
    }
}