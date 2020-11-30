namespace FinalDB
{
    partial class LandingForm
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
            this.btnAddMusc = new System.Windows.Forms.Button();
            this.btnAddBand = new System.Windows.Forms.Button();
            this.btnViewBoth = new System.Windows.Forms.Button();
            this.btnViewMusc = new System.Windows.Forms.Button();
            this.btnViewBand = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddMusc
            // 
            this.btnAddMusc.Location = new System.Drawing.Point(148, 83);
            this.btnAddMusc.Name = "btnAddMusc";
            this.btnAddMusc.Size = new System.Drawing.Size(174, 57);
            this.btnAddMusc.TabIndex = 0;
            this.btnAddMusc.Text = "Add Musician";
            this.btnAddMusc.UseVisualStyleBackColor = true;
            this.btnAddMusc.Click += new System.EventHandler(this.btnAddMusc_Click);
            // 
            // btnAddBand
            // 
            this.btnAddBand.Location = new System.Drawing.Point(148, 177);
            this.btnAddBand.Name = "btnAddBand";
            this.btnAddBand.Size = new System.Drawing.Size(174, 57);
            this.btnAddBand.TabIndex = 1;
            this.btnAddBand.Text = "Add Band";
            this.btnAddBand.UseVisualStyleBackColor = true;
            this.btnAddBand.Click += new System.EventHandler(this.btnAddBand_Click);
            // 
            // btnViewBoth
            // 
            this.btnViewBoth.Location = new System.Drawing.Point(269, 269);
            this.btnViewBoth.Name = "btnViewBoth";
            this.btnViewBoth.Size = new System.Drawing.Size(174, 57);
            this.btnViewBoth.TabIndex = 2;
            this.btnViewBoth.Text = "Musicians In Bands";
            this.btnViewBoth.UseVisualStyleBackColor = true;
            // 
            // btnViewMusc
            // 
            this.btnViewMusc.Location = new System.Drawing.Point(393, 83);
            this.btnViewMusc.Name = "btnViewMusc";
            this.btnViewMusc.Size = new System.Drawing.Size(174, 57);
            this.btnViewMusc.TabIndex = 3;
            this.btnViewMusc.Text = "Browse Musician";
            this.btnViewMusc.UseVisualStyleBackColor = true;
            this.btnViewMusc.Click += new System.EventHandler(this.btnViewMusc_Click);
            // 
            // btnViewBand
            // 
            this.btnViewBand.Location = new System.Drawing.Point(393, 177);
            this.btnViewBand.Name = "btnViewBand";
            this.btnViewBand.Size = new System.Drawing.Size(174, 57);
            this.btnViewBand.TabIndex = 4;
            this.btnViewBand.Text = "Browse Band";
            this.btnViewBand.UseVisualStyleBackColor = true;
            this.btnViewBand.Click += new System.EventHandler(this.btnViewBand_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Modify";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "View";
            // 
            // LandingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnViewBand);
            this.Controls.Add(this.btnViewMusc);
            this.Controls.Add(this.btnViewBoth);
            this.Controls.Add(this.btnAddBand);
            this.Controls.Add(this.btnAddMusc);
            this.Name = "LandingForm";
            this.Text = "LandingForm";
            this.Load += new System.EventHandler(this.LandingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddMusc;
        private System.Windows.Forms.Button btnAddBand;
        private System.Windows.Forms.Button btnViewBoth;
        private System.Windows.Forms.Button btnViewMusc;
        private System.Windows.Forms.Button btnViewBand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}