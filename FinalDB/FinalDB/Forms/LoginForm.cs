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
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
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
