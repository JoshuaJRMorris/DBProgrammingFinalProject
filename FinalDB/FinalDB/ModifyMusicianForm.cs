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
    public partial class ModifyMusicianForm : Form
    {
        String fName = "";
        String lName = "";
        String instrument = "";
        String role = "";
        
        public ModifyMusicianForm()
        {
            InitializeComponent();
        }

        private void btnCreateMusician_Click(object sender, EventArgs e)
        {
            fName = txtFName.Text;
            lName = txtLName.Text;
            instrument = txtInstrument.Text;
            role = txtRole.Text;


        }
    }
}
