namespace FinalDB
{
    partial class ModifyMusicianForm
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
            this.mCmbBx = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // mCmbBx
            // 
            this.mCmbBx.FormattingEnabled = true;
            this.mCmbBx.Location = new System.Drawing.Point(233, 59);
            this.mCmbBx.Name = "mCmbBx";
            this.mCmbBx.Size = new System.Drawing.Size(213, 24);
            this.mCmbBx.TabIndex = 0;
            // 
            // MusicianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mCmbBx);
            this.Name = "MusicianForm";
            this.Text = "MusicianForm";
            this.Load += new System.EventHandler(this.MusicianForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox mCmbBx;
    }
}