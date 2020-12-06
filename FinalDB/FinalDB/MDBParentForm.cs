using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalDB
{
    public partial class MDBParentForm : Form
    {
        
        public MDBParentForm()
        {
            InitializeComponent();
            SetStatus("Succesfully logged in", Color.Black);
        }

       

        public void SetStatus(String text, Color color)
        {
            lblStatus.Text = text;

            lblStatus.ForeColor = color;
        }

        private void musiciansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewMusicianForm viewMusicianForm = new ViewMusicianForm();
            
            viewMusicianForm.MdiParent = this;
            viewMusicianForm.Show();
            
        }

        private void bandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBandForm viewBandForm = new ViewBandForm();
            viewBandForm.MdiParent = this;
            viewBandForm.Show();
        }

        private void musiciansInBandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBandMusicianForm viewBandMusicianForm = new ViewBandMusicianForm();
            viewBandMusicianForm.MdiParent = this;
            viewBandMusicianForm.Show();
        }

        private void musiciansToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ModifyMusicianForm modifyMusicianForm = new ModifyMusicianForm();
            
            modifyMusicianForm.MdiParent = this;
  
            modifyMusicianForm.Show();
        }

        private void bandsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ModifyBandForm modifyBandForm = new ModifyBandForm();
            modifyBandForm.MdiParent = this;
            modifyBandForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.MdiParent = this;
            aboutForm.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {              
                child.Close();
            }
        }
    }
}
