using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Final_Model;

namespace Final_Repository
{
     public class Repository
    {
        private static SqlConnection chev = new SqlConnection("Server=tcp:ademoye-server.database.windows.net,1433;Initial Catalog=ademoye-db;Persist Security Info=False;User ID=ademoye123;Password=Daniel123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public List<Store> GetStores()
        {
            SqlCommand comm = new SqlCommand("SELECT * FROM Stores", chev);
            chev.Open();
            List<Store> stores = new List<Store>();
            SqlDataReader res = null;
            
            try
            {
                res = comm.ExecuteReader();
                while (res.Read())
                {
                    stores.Add(new Store(res.GetGuid(0), res.GetString(1), res.GetString(2)));
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"The exception was {ex.Message} - {ex.InnerException}");
            }
            finally
            {
                res?.Close();
                chev.Close();
            }

            return stores;
        }

        public Person GetUserByUnamePword(string userName, string password)
        {
            SqlCommand comm = new SqlCommand("SELECT TOP 1 * FROM Customers WHERE UserName = @username AND Password = @password", chev);
            comm.Parameters.AddWithValue("@username", userName);
            comm.Parameters.AddWithValue("@password", password);
            chev.Open();
            SqlDataReader res = null;
            Person p = null;
            
            try
            {
                res = comm.ExecuteReader();
                if (res.Read())
                {
                    p = new Person(res.GetGuid(0), res.GetString(1), res.GetString(2), res.GetDateTime(3), res.GetString(4), res.GetString(5), res.GetString(6));
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"The exception was {ex.Message} - {ex.InnerException}");
            }
            finally
            {
                res?.Close();
                chev.Close();
            }

            return p;
        }

        public int RegisterNewCustomer(Person p)
        {
            SqlCommand comm = new SqlCommand("INSERT INTO Customers VALUES (@cid, @fn, @ln, @lod, @r, @un, @pw)", chev);
            comm.Parameters.AddWithValue("@cid", p.CustomerId);
            comm.Parameters.AddWithValue("@fn", p.FirstName);
            comm.Parameters.AddWithValue("@ln", p.LastName);
            comm.Parameters.AddWithValue("@lod", p.LastOrderDate);
            comm.Parameters.AddWithValue("@r", p.Remarks);
            comm.Parameters.AddWithValue("@un", p.UserName);
            comm.Parameters.AddWithValue("@pw", p.Password);
            chev.Open();
            int res = 0;
            
            try
            {
                res = comm.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"The exception was {ex.Message} - {ex.InnerException}");
            }
            finally
            {
                chev.Close();
            }

            return res;
        }

        public Store GetStoreInfo(Guid storeId)
        {
            SqlCommand comm = new SqlCommand("SELECT * FROM Stores LEFT JOIN StoreProductJunction ON Stores.StoreId = StoreProductJunction.StoreId WHERE Stores.StoreId = @storeId", chev);
            comm.Parameters.AddWithValue("@storeId", storeId);
            chev.Open();
            Store s = null;
            SqlDataReader res = null;
            
            try
            {
                res = comm.ExecuteReader();
                if (res.Read())
                {
                    s = new Store(res.GetGuid(0), res.GetString(1), res.GetString(2));
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"The exception was {ex.Message} - {ex.InnerException}");
            }
            finally
            {
                res?.Close();
                chev.Close();
            }

            return s;
        }

        public bool UserNamePasswordInDb(string username, string password)
        {
            SqlCommand comm = new SqlCommand("SELECT * FROM Customers WHERE UserName = @username AND Password = @password", chev);
            comm.Parameters.AddWithValue("@username", username);
            comm.Parameters.AddWithValue("@password", password);
            chev.Open();
            SqlDataReader res = null;
            
            try
            {
                res = comm.ExecuteReader();
                return res.Read();
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"The exception was {ex.Message} - {ex.InnerException}");
                return false;
            }
            finally
            {
                res?.Close();
                chev.Close();
            }
        }
    }
}