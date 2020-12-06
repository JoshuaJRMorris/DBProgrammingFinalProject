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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.txtInstrument = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.btnCreateMusician = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Instrument";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Role In Band: ";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(258, 75);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(175, 22);
            this.txtFName.TabIndex = 4;
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(258, 238);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(175, 22);
            this.txtRole.TabIndex = 5;
            // 
            // txtInstrument
            // 
            this.txtInstrument.Location = new System.Drawing.Point(258, 186);
            this.txtInstrument.Name = "txtInstrument";
            this.txtInstrument.Size = new System.Drawing.Size(175, 22);
            this.txtInstrument.TabIndex = 6;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(258, 131);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(175, 22);
            this.txtLName.TabIndex = 7;
            // 
            // btnCreateMusician
            // 
            this.btnCreateMusician.Location = new System.Drawing.Point(254, 318);
            this.btnCreateMusician.Name = "btnCreateMusician";
            this.btnCreateMusician.Size = new System.Drawing.Size(179, 40);
            this.btnCreateMusician.TabIndex = 8;
            this.btnCreateMusician.Text = "Create Musician";
            this.btnCreateMusician.UseVisualStyleBackColor = true;
            this.btnCreateMusician.Click += new System.EventHandler(this.btnCreateMusician_Click);
            // 
            // ModifyMusicianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreateMusician);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtInstrument);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModifyMusicianForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modify Musician";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.TextBox txtInstrument;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Button btnCreateMusician;
    }
}