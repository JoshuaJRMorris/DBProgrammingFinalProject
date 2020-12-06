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
    public partial class ViewMusicianForm : Form
    {
        public ViewMusicianForm()
        {
            InitializeComponent();
        }

        private void LoadTest()
        {
            string names = "SELECT FirstName, MusicianID FROM Musician";
            Utilities.FillListControl(mCmbBox, "FirstName", "MusicianID", DataAccess.GetData(names), true, "Pick a name");
        }

        

        private void ViewMusicianForm_Load(object sender, EventArgs e)
        {
            LoadTest();
        }
    }
}
