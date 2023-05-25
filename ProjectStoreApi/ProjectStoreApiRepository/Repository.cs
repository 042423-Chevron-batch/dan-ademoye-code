using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using ProjectStoreApiModels;


namespace ProjectStoreApiRepository
{
    public class Repository
    {
        //here we will write the ADO.NET code to access the Database.
        // 
        private static SqlConnection con { get; set; } = new SqlConnection("Server=tcp:ademoye-server.database.windows.net,1433;Initial Catalog=ademoye-db;Persist Security Info=False;User ID=ademoye123;Password=Daniel123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");


        public static int Test(string fname, string lname, string email)
        {
            SqlCommand comm = new SqlCommand("INSERT INTO Customer (CustomerId, FirstName, LastName,Email) VALUES ((SELECT MAX(CustomerId) FROM [dbo].[Customer])+1,@fname, @lname,@email);", con);
            comm.Parameters.AddWithValue("@fname", fname);
            comm.Parameters.AddWithValue("@lname", lname);
            comm.Parameters.AddWithValue("@email", email);
            con.Open();
            int res = 0;
            try
            {
                res = comm.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                // write this exception to a file, exception.
                Console.WriteLine($"the exception was {ex.Message} - {ex.InnerException}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"the exception was {ex.Message} - {ex.InnerException}");
            }
            Console.WriteLine($"The value is =>{res}.");
            return res;
        }

    
        private readonly string _connectionString;

        // public StoreRepository(string connectionString)
        // {
        //     _connectionString = connectionString;
        // }

        public List<Store> GetAllStores()
        {
            List<Store> stores = new List<Store>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "SELECT Id, Name, Location FROM Stores";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Store store = new Store
                            {
                                Id = (int)reader["Id"],
                                Name = (string)reader["Name"],
                                // Location = (string)reader["Location"]
                            };

                            stores.Add(store);
                        }
                    }
                }
            }

            return stores;
        }

        public List<Product> GetProductsByStoreId(int storeId)
        {
            List<Product> products = new List<Product>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "SELECT Id, Name, Price, Description FROM Products WHERE StoreId = @StoreId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StoreId", storeId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product product = new Product
                            {
                                Id = (int)reader["Id"],
                                Name = (string)reader["Name"],
                                Price = (decimal)reader["Price"],
                                Description = (string)reader["Description"]
                            };

                            products.Add(product);
                        }
                    }
                }
            }

            return products;
        }

    }
    
    // method retrieves the order history for a specific store

    // public void InsertOrder(Order order)
    // {
    //     using (SqlConnection connection = new SqlConnection(_connectionString))
    //     {
    //         connection.Open();

    //         string query = "INSERT INTO Orders (CustomerId, StoreId, OrderTime) VALUES (@CustomerId, @StoreId, @OrderTime)";

    //         using (SqlCommand command = new SqlCommand(query, connection))
    //         {
    //             command.Parameters.AddWithValue("@CustomerId", order.CustomerId);
    //             command.Parameters.AddWithValue("@StoreId", order.StoreId);
    //             command.Parameters.AddWithValue("@OrderTime", order.OrderTime);

    //             command.ExecuteNonQuery();
    //         }
    //     }
    // }

    // public List<Order> GetOrderHistoryByStoreId(int storeId)
    // {
    //     List<Order> orders = new List<Order>();

    //     using (SqlConnection connection = new SqlConnection(_connectionString))
    //     {
    //         connection.Open();

    //         string query = "SELECT Id, CustomerId, StoreId, OrderTime FROM Orders WHERE StoreId = @StoreId";

    //         using (SqlCommand command = new SqlCommand(query, connection))
    //         {
    //             command.Parameters.AddWithValue("@StoreId", storeId);

    //             using (SqlDataReader reader = command.ExecuteReader())
    //             {
    //                 while (reader.Read())
    //                 {
    //                     Order order = new Order
    //                     {
    //                         Id = (int)reader["Id"],
    //                         CustomerId = (int)reader["CustomerId"],
    //                         StoreId = (int)reader["StoreId"],
    //                         OrderTime = (DateTime)reader["OrderTime"]
    //                     };

    //                     orders.Add(order);
    //                 }
    //             }
    //         }
    //     }

        // return orders;
    }







    
