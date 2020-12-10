using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CM = System.Configuration.ConfigurationManager;

namespace FinalDB.DataAccess
{
    class MySqlRepo : IMdbRepo
    {
        private static string connectionString = CM.ConnectionStrings["MusicBand"].ConnectionString;

        public void CreateMusician(Musician musician)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_musicianInsert", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FirstName", musician.firstName);
                cmd.Parameters.AddWithValue("@LastName", musician.lastName);
                cmd.Parameters.AddWithValue("@Instrument", musician.instrument);
                cmd.Parameters.AddWithValue("@RoleInBand", musician.roleInBand);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                //if (i != 0)
                //{
                //    //add error
                //}
            }

                
        }

        public DataTable GetData(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                    try
                    {
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                    catch (SqlException e)
                    {

                    }
            }
            catch (Exception e)
            {
                
            }
            return dt;
        }

        //reimplement these to be useful
        public DataTable GetProducts(int id)
        {
            string sql = ($"Select * FROM Products WHERE SupplierId = {id} ORDER BY ProductId;");
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (SqlException e)
            {

            }
            return dt;
        }

        public DataTable GetSuppliers()
        {
            string sql = ("Select SupplierId, CompanyName From Suppliers ORDER BY SupplierId");
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (SqlException e)
            {

            }
            return dt;
        }
    }
}
