namespace FinalDB
{
    partial class ViewBandMusicianForm
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
            this.cmbxBands = new System.Windows.Forms.ComboBox();
            this.dgvMusicians = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusicians)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbxBands
            // 
            this.cmbxBands.FormattingEnabled = true;
            this.cmbxBands.Location = new System.Drawing.Point(227, 84);
            this.cmbxBands.Name = "cmbxBands";
            this.cmbxBands.Size = new System.Drawing.Size(276, 24);
            this.cmbxBands.TabIndex = 0;
            this.cmbxBands.SelectedIndexChanged += new System.EventHandler(this.cmbxBands_SelectedIndexChanged);
            // 
            // dgvMusicians
            // 
            this.dgvMusicians.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusicians.Location = new System.Drawing.Point(41, 187);
            this.dgvMusicians.Name = "dgvMusicians";
            this.dgvMusicians.RowHeadersWidth = 51;
            this.dgvMusicians.RowTemplate.Height = 24;
            this.dgvMusicians.Size = new System.Drawing.Size(720, 178);
            this.dgvMusicians.TabIndex = 1;
            this.dgvMusicians.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMusicians_CellContentClick);
            // 
            // ViewBandMusicianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMusicians);
            this.Controls.Add(this.cmbxBands);
            this.Name = "ViewBandMusicianForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musicians and their Bands";
            this.Load += new System.EventHandler(this.ViewBandMusicianForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusicians)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbxBands;
        private System.Windows.Forms.DataGridView dgvMusicians;
    }
}