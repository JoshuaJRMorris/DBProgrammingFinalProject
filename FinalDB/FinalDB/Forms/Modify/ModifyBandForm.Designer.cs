namespace FinalDB
{
    partial class ModifyBandForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBandName = new System.Windows.Forms.TextBox();
            this.txtReleases = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtDateFormed = new System.Windows.Forms.TextBox();
            this.rBtnTogether = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreateBand = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Band Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date Founded: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of Releases: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Genre: ";
            // 
            // txtBandName
            // 
            this.txtBandName.Location = new System.Drawing.Point(175, 44);
            this.txtBandName.Name = "txtBandName";
            this.txtBandName.Size = new System.Drawing.Size(195, 22);
            this.txtBandName.TabIndex = 5;
            // 
            // txtReleases
            // 
            this.txtReleases.Location = new System.Drawing.Point(175, 131);
            this.txtReleases.Name = "txtReleases";
            this.txtReleases.Size = new System.Drawing.Size(195, 22);
            this.txtReleases.TabIndex = 7;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(175, 173);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(195, 22);
            this.txtGenre.TabIndex = 8;
            // 
            // txtDateFormed
            // 
            this.txtDateFormed.Location = new System.Drawing.Point(175, 85);
            this.txtDateFormed.Name = "txtDateFormed";
            this.txtDateFormed.Size = new System.Drawing.Size(195, 22);
            this.txtDateFormed.TabIndex = 9;
            // 
            // rBtnTogether
            // 
            this.rBtnTogether.AutoSize = true;
            this.rBtnTogether.Location = new System.Drawing.Point(175, 221);
            this.rBtnTogether.Name = "rBtnTogether";
            this.rBtnTogether.Size = new System.Drawing.Size(113, 21);
            this.rBtnTogether.TabIndex = 10;
            this.rBtnTogether.TabStop = true;
            this.rBtnTogether.Text = "Still Together";
            this.rBtnTogether.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreateBand);
            this.groupBox1.Controls.Add(this.rBtnTogether);
            this.groupBox1.Controls.Add(this.txtDateFormed);
            this.groupBox1.Controls.Add(this.txtGenre);
            this.groupBox1.Controls.Add(this.txtReleases);
            this.groupBox1.Controls.Add(this.txtBandName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(131, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 349);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // btnCreateBand
            // 
            this.btnCreateBand.Location = new System.Drawing.Point(175, 270);
            this.btnCreateBand.Name = "btnCreateBand";
            this.btnCreateBand.Size = new System.Drawing.Size(188, 53);
            this.btnCreateBand.TabIndex = 11;
            this.btnCreateBand.Text = "Create Band";
            this.btnCreateBand.UseVisualStyleBackColor = true;
            this.btnCreateBand.Click += new System.EventHandler(this.btnCreateBand_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 39);
            this.label3.TabIndex = 12;
            this.label3.Text = "Add a Band";
            // 
            // ModifyBandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModifyBandForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modify Band";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBandName;
        private System.Windows.Forms.TextBox txtReleases;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtDateFormed;
        private System.Windows.Forms.RadioButton rBtnTogether;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreateBand;
        private System.Windows.Forms.Label label3;
    }
}