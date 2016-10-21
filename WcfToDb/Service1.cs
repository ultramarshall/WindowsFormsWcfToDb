using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfToDb
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        SqlConnection conn;
        SqlCommand comm;
        SqlConnectionStringBuilder connStringBuilder;

        public Service1()
        {
            connectToDb();
        }

        void connectToDb()
        {
            connStringBuilder = new SqlConnectionStringBuilder();
            connStringBuilder.DataSource = "DESKTOP-1172569";
            connStringBuilder.InitialCatalog = "WCF";
            connStringBuilder.Encrypt = true;
            connStringBuilder.TrustServerCertificate = true;
            connStringBuilder.ConnectTimeout = 30;
            connStringBuilder.AsynchronousProcessing = true;
            connStringBuilder.MultipleActiveResultSets = true;
            connStringBuilder.IntegratedSecurity = true;

            conn = new SqlConnection(connStringBuilder.ToString());
            comm = conn.CreateCommand();
        }

        public int TambahBiodata(Biodata p)
        {

            try
            {
                comm.CommandText = "INSERT INTO TBioadata VALUES(@Id, @Nama, @Umur)";
                comm.Parameters.AddWithValue("Id", p.Id);
                comm.Parameters.AddWithValue("Nama", p.Nama);
                comm.Parameters.AddWithValue("Umur", p.Umur);
                comm.CommandType = CommandType.Text;
                conn.Open();
                return comm.ExecuteNonQuery();
            }
            catch (Exception)
            { 

                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }

        public int EditBiodata(Biodata p)
        {
            try
            {
                comm.CommandText = "UPDATE TBioadata SET Nama=@Nama, Umur=@Umur WHERE Id=@Id";
                comm.Parameters.AddWithValue("Id", p.Id);
                comm.Parameters.AddWithValue("Nama", p.Nama);
                comm.Parameters.AddWithValue("Umur", p.Umur);
                comm.CommandType = CommandType.Text;
                conn.Open();
                return comm.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public int HapusBiodata(Biodata p)
        {
            try
            {
                comm.CommandText = "DELETE FROM TBioadata WHERE Id=@Id";
                comm.Parameters.AddWithValue("Id", p.Id);
                comm.CommandType = CommandType.Text;
                conn.Open();
                return comm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public Biodata GetBiodata(Biodata p)
        {
            Biodata biodata = new Biodata();
            try
            {
                comm.CommandText = "SELECT * FROM TBioadata WHERE Id=@id";
                comm.Parameters.AddWithValue("Id", p.Id);
                comm.CommandType = CommandType.Text;

                conn.Open();

                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    biodata.Id = Convert.ToInt32(reader[0]);
                    biodata.Nama = reader[1].ToString();
                    biodata.Umur = Convert.ToInt32(reader[2]);
                }
                return biodata;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public List<Biodata> GetAllBiodata()
        {
            List<Biodata> biodataList = new List<Biodata>();
            try
            {
                comm.CommandText = "SELECT * FROM TBioadata";
                comm.CommandType = CommandType.Text;
                conn.Open();

                SqlDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    Biodata biodata = new Biodata()
                    {
                        Id = Convert.ToInt32(reader[0]),
                        Nama = reader[1].ToString(),
                        Umur = Convert.ToInt32(reader[2])
                    };
                    biodataList.Add(biodata);
                }
                return biodataList;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
