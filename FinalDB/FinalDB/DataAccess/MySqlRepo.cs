﻿/*
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
using CM = System.Configuration.ConfigurationManager;
using FinalDB.Models;

namespace FinalDB.DataAccess
{
    class MySqlRepo : IMdbRepo
    {
        private static string connectionString = CM.ConnectionStrings["MusicBand"].ConnectionString;

        public void CreateBand(Band band)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_bandInsert", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BandName", band.bandName);
                cmd.Parameters.AddWithValue("@YearFounded", band.yearFounded);
                cmd.Parameters.AddWithValue("@IsStillTogether", band.stillTogether);
                cmd.Parameters.AddWithValue("@NumberOfReleases", band.releases);
                cmd.Parameters.AddWithValue("@Genre", band.genre);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                //if (i != 0)
                //{
                //    //add error
                //}
            }
        }

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
        internal static DataTable GetDataTable(SqlCommand cmd)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                cmd.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
            }

            return dt;
        }


        
        public DataTable GetBands()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_selectBands", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                

                
            }
            return dt;
        }

        public DataTable GetBand(string id)
        {

            var cmd = 
               new SqlCommand("EXEC sp_GetSingleBand ");
                cmd.Parameters.AddWithValue("@BandID", id);
            
            return GetDataTable(cmd);
        }

        public DataTable GetMusicians()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_selectMusicians", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);



            }
            return dt;
        }

        public void CreateRelationship(MusicianBand musicianBand)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_MusicianBandInsert", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MusicianID", musicianBand.musicianId);
                cmd.Parameters.AddWithValue("@BandID", musicianBand.bandId);
                cmd.Parameters.AddWithValue("@JoinedBand", musicianBand.joinedBand);
                cmd.Parameters.AddWithValue("@LeftBand", musicianBand.leftBand);
                cmd.Parameters.AddWithValue("@PlayedOnRelease", musicianBand.playedOnRelease);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                //if (i != 0)
                //{
                //    //add error
                //}
            }
        }

        public DataTable GetRelationship(int bandId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_GetReleationship", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BandID", bandId);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);



            }
            return dt;
        }
    }
}
