/*
* @file <filename>
*
* @author  <Joshua Morris joshuajrmorris@gmail.com>
* @version <1.0>
*
* change log
* name  Josh Morris    date Fall 2020
*
*
* @section Academic Integrity
*  I certify that this work is solely my own and complies with
*  NBCC Academic Integrity Policy (policy 1111)
*
*
* @section DESCRIPTION
*  < brief description of the purpose of this file >
*
*
* @section LICENSE
*  <any necessary attributions>
*
*  Copyright 2020
*  Permission to use, copy, modify, and/or distribute this software for
*  any purpose with or without fee is hereby granted, provided that the
*  above copyright notice and this permission notice appear in all copies.
*
*  THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES
*  WITH REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF
*  MERCHANTABILITY AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR
*  ANY SPECIAL, DIRECT, INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES
*  WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN
*  ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING OUT OF
*  OR IN CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE.
*
*/
//
//
//

using System;
using System.Drawing;
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
        private void addMusicianToBandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMusicianToBandForm toBandForm = new AddMusicianToBandForm();
            toBandForm.MdiParent = this;
            toBandForm.Show();
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
