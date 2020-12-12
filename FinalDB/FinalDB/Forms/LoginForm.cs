using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CM = System.Configuration.ConfigurationManager;

namespace FinalDB
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //MDBParentForm parentForm = new MDBParentForm();
            //parentForm.Show();

            using (IDbConnection connection = new SqlConnection(CM.ConnectionStrings["MusicBand"].ConnectionString))
            {
                string query =
                    "Select * from LoginStore Where UserName = '" + txtUsername.Text.Trim() +
                    "' and Password = '" + txtPassword.Text.Trim() + "'";
                SqlDataAdapter sqlDataAdapter =
                    new SqlDataAdapter(query, CM.ConnectionStrings["MusicBand"].ConnectionString.ToString());
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count == 1)
                {
                    this.Close();
                    MDBParentForm parentForm = new MDBParentForm();
                    parentForm.Show();
                }
                else
                {
                    MessageBox.Show("Username/Password incorrect, please try again.");
                }

            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
