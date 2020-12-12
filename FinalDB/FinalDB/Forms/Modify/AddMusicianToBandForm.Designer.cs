namespace FinalDB
{
    partial class AddMusicianToBandForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.lsbxMusicians = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbxBands = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtJoined = new System.Windows.Forms.TextBox();
            this.txtLeft = new System.Windows.Forms.TextBox();
            this.rBtnPlayed = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add To Band";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lsbxMusicians
            // 
            this.lsbxMusicians.FormattingEnabled = true;
            this.lsbxMusicians.ItemHeight = 16;
            this.lsbxMusicians.Location = new System.Drawing.Point(62, 208);
            this.lsbxMusicians.Name = "lsbxMusicians";
            this.lsbxMusicians.Size = new System.Drawing.Size(317, 132);
            this.lsbxMusicians.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Musician";
            // 
            // cmbxBands
            // 
            this.cmbxBands.FormattingEnabled = true;
            this.cmbxBands.Location = new System.Drawing.Point(124, 92);
            this.cmbxBands.Name = "cmbxBands";
            this.cmbxBands.Size = new System.Drawing.Size(195, 24);
            this.cmbxBands.TabIndex = 3;
            this.cmbxBands.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Year Joined";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Year Left";
            // 
            // txtJoined
            // 
            this.txtJoined.Location = new System.Drawing.Point(167, 383);
            this.txtJoined.Name = "txtJoined";
            this.txtJoined.Size = new System.Drawing.Size(152, 22);
            this.txtJoined.TabIndex = 7;
            // 
            // txtLeft
            // 
            this.txtLeft.Location = new System.Drawing.Point(167, 427);
            this.txtLeft.Name = "txtLeft";
            this.txtLeft.Size = new System.Drawing.Size(152, 22);
            this.txtLeft.TabIndex = 8;
            // 
            // rBtnPlayed
            // 
            this.rBtnPlayed.AutoSize = true;
            this.rBtnPlayed.Location = new System.Drawing.Point(153, 484);
            this.rBtnPlayed.Name = "rBtnPlayed";
            this.rBtnPlayed.Size = new System.Drawing.Size(185, 26);
            this.rBtnPlayed.TabIndex = 9;
            this.rBtnPlayed.TabStop = true;
            this.rBtnPlayed.Text = "Played on Release";
            this.rBtnPlayed.UseMnemonic = false;
            this.rBtnPlayed.UseVisualStyleBackColor = true;
            // 
            // AddMusicianToBandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 652);
            this.Controls.Add(this.rBtnPlayed);
            this.Controls.Add(this.txtLeft);
            this.Controls.Add(this.txtJoined);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbxBands);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsbxMusicians);
            this.Controls.Add(this.button1);
            this.Name = "AddMusicianToBandForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Musicians To Band";
            this.Load += new System.EventHandler(this.AddMusicianToBandForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lsbxMusicians;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbxBands;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtJoined;
        private System.Windows.Forms.TextBox txtLeft;
        private System.Windows.Forms.RadioButton rBtnPlayed;
    }
}