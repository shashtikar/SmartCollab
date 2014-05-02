using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Collections;


namespace SmartCollab
{
    public class dataConn
    {
        
        
        public int publishService(String service_URL, String service_description, int tenant_id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=SHASHANK-PC;Initial Catalog=master;Integrated Security=True";
            conn.Open();
            SqlCommand qry = new SqlCommand();
            String qryText = "insert into service_dir values (((select MAX (service_id) from service_dir)+1), " + "'" + service_URL + "'," + "'" + service_description + "'," + tenant_id.ToString() + ",1);";
            qry.CommandText = qryText;
            qry.Connection = conn;
            
            try
            {
                qry.ExecuteNonQuery();
                return 200;
            }
            catch (Exception e)
            {
               return 400;
            }
            finally
            {
                conn.Close();
            }
            

        }

        public int unpublishService(int service_id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=SHASHANK-PC;Initial Catalog=master;Integrated Security=True";
            conn.Open();
            SqlCommand query = new SqlCommand();
            query.CommandText = "update service_dir set published=0 where service_id= "+service_id.ToString()+";";
            query.Connection = conn;
            try
            {
                query.ExecuteNonQuery();
                return 200;
            }
            catch
            {
                return 400;
            }
            finally
            {
                conn.Close();
            }
        
        }

        public bool isPublished(String regEx)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=SHASHANK-PC;Initial Catalog=master;Integrated Security=True";
            conn.Open();
            SqlCommand query = new SqlCommand();
            query.CommandText = "select published from service_dir where service_name like '%"+regEx+"%';";
            query.Connection = conn;

            try
            {
                return (int.Parse(query.ExecuteScalar().ToString())==1);
                
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public int unpublish_req(int req_id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=SHASHANK-PC;Initial Catalog=master;Integrated Security=True";
            conn.Open();
            SqlCommand query = new SqlCommand();
            query.CommandText = "delete from requirement where req_id = " + req_id.ToString() + ";";
            query.Connection = conn;
            try
            {
                query.ExecuteNonQuery();
                return 200;
            }
            catch
            {
                return 400;
            }
            finally
            {
                conn.Close();
            }
        
        }

        public int getReqOwnerId(int req_id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=SHASHANK-PC;Initial Catalog=master;Integrated Security=True";
            conn.Open();
            SqlCommand query = new SqlCommand();
            query.CommandText = "select publisher_tenant_id from requirement where req_id = " + req_id.ToString() + ";";
            query.Connection = conn;
            try
            {
                return (int)query.ExecuteScalar();
               
            }
            catch
            {
                return 400;
            }
            finally
            {
                conn.Close();
            }
        
        }

        public int publish_requirement(String req_desc, int tenant_id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=SHASHANK-PC;Initial Catalog=master;Integrated Security=True";
            conn.Open();
            SqlCommand query = new SqlCommand();
            query.CommandText = "insert into requirements values(((select MAX (req_id) from requirements)+1), '" + req_desc + "'," + tenant_id.ToString() + ");";
            query.Connection = conn;
            try
            {
                query.ExecuteNonQuery();
                return 200;
            }
            catch
            {
                return 400;
            }
            finally
            {
                conn.Close();
            }
        }

        public ArrayList getServiceList(int tenant_id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=SHASHANK-PC;Initial Catalog=master;Integrated Security=True";
            conn.Open();
            SqlCommand query = new SqlCommand();
            query.CommandText = "select service_name from service_dir where tenant_id=" + tenant_id.ToString()+";";
            query.Connection = conn;
            ArrayList al = new ArrayList();
          
            try
            {
                SqlDataReader reader = query.ExecuteReader();
                while (reader.Read())
                {
                    al.Add(reader["service_name"].ToString());
                   
                }
                return al;
            }
            catch
            {
                al.Add("400");
                return al;
            }
            finally
            {
                conn.Close();
            }

        }

        public int bindService(int service_id, int tenant_id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=SHASHANK-PC;Initial Catalog=master;Integrated Security=True";
            conn.Open();
            SqlCommand query = new SqlCommand();
            query.CommandText = "insert into service_bind values (" + service_id.ToString()+","+tenant_id.ToString() + ");";
            query.Connection = conn;
            try
            {
                query.ExecuteNonQuery();
                return 200;
            }
            catch
            {
                return 400;
            }
            finally
            {
                conn.Close();
            }
        }

        public int bindRequirement(int req_id, int tenant_id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=SHASHANK-PC;Initial Catalog=master;Integrated Security=True";
            conn.Open();
            SqlCommand query = new SqlCommand();
            query.CommandText = "insert into req_bind values (" + req_id.ToString() + "," + tenant_id.ToString() + ");";
            query.Connection = conn;
            try
            {
                query.ExecuteNonQuery();
                return 200;
            }
            catch
            {
                return 400;
            }
            finally
            {
                conn.Close();
            }
        }

        public ArrayList getServiceSubscribers(int service_id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=SHASHANK-PC;Initial Catalog=master;Integrated Security=True";
            conn.Open();
            SqlCommand query = new SqlCommand();
            query.CommandText = "select tenant_id from service_bind where service_id=" + service_id.ToString() + ";";
            query.Connection = conn;
            ArrayList al = new ArrayList();

            try
            {
                SqlDataReader reader = query.ExecuteReader();
                while (reader.Read())
                {
                    al.Add(int.Parse(reader["tenant_id"].ToString()));

                }
                return al;
            }
            catch
            {
                al.Add(int.Parse("400"));
                return al;
            }
            finally
            {
                conn.Close();
            }

        }

        public ArrayList getRequirementSubscribers(int req_id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=SHASHANK-PC;Initial Catalog=master;Integrated Security=True";
            conn.Open();
            SqlCommand query = new SqlCommand();
            query.CommandText = "select tenant_id from req_bind where req_id=" + req_id.ToString() + ";";
            query.Connection = conn;
            ArrayList al = new ArrayList();

            try
            {
                SqlDataReader reader = query.ExecuteReader();
                while (reader.Read())
                {
                    al.Add(int.Parse(reader["tenant_id"].ToString()));

                }
                return al;
            }
            catch
            {
                al.Add(int.Parse("400"));
                return al;
            }
            finally
            {
                conn.Close();
            }

        }





    }
}