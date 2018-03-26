using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Blue_Chip_Site.Models;

namespace Blue_Chip_Site.DAL
{
    public class ProductDAL
    {

        public List<Product> GetProducts()
        {
            List<Product> output = new List<Product>();

            try
            {
                const string ConnectionString = "Data Source=(LocalDb)\\BlueChipProducts;Initial Catalog=BlueChipProducts;Integrated Security=True;";
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM BlueChipProducts;", conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    
                    while (reader.Read())
                    {
                        Product product = new Product();
                        product.ProductID = Convert.ToInt16(reader["productID"]);
                        product.ProductName = Convert.ToString(reader["productName"]);
                        product.ProductDescription = Convert.ToString(reader["productDescription"]);

                        output.Add(product);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }

            return output;
        }

    }
}