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
    public partial class ModifyBandForm : Form
    {
        public ModifyBandForm()
        {
            InitializeComponent();
        }

        private void btnCreateBand_Click(object sender, EventArgs e)
        {
            AddMusicianToBandForm toBandForm = new AddMusicianToBandForm();
            toBandForm.Show();
        }
    }
}
