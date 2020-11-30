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
        public ModifyMusicianForm()
        {
            InitializeComponent();
        }

        private void LoadTest()
        {
            string names = "SELECT FirstName, MusicianID FROM Musician";
            Utilities.FillListControl(mCmbBx, "FirstName", "MusicianID", DataAccess.GetData(names), true, "Pick a name");
        }

        private void MusicianForm_Load(object sender, EventArgs e)
        {
            LoadTest();
        }
    }
}
