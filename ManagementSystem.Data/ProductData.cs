using ManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.Data
{
    public class ProductData
    {
        private readonly static string _connectionString = @"YOUR CONNETION DATABASE";
        public static List<Product> LoadProduct()
        {
            List<Product> listProduct = new List<Product>();

            string query = "SELECT Id,Descripciones,Costo,PrecioVenta,Stock,IdUsuario FROM Producto";

            try
            {
                using (SqlConnection connetion = new SqlConnection(_connectionString))
                {
                    connetion.Open();

                    using (SqlCommand command = new SqlCommand(query, connetion))
                    {
                        using (SqlDataReader dr = command.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    Product product = new Product();
                                    product.Id = Convert.ToInt32(dr["Id"]);
                                    product.Description = dr["Descripciones"].ToString();
                                    product.Cost = Convert.ToDecimal(dr["Costo"]);
                                    product.SalePrice = Convert.ToDecimal(dr["PrecioVenta"]);
                                    product.Stock = Convert.ToInt32(dr["Stock"]);
                                    product.IdUser = Convert.ToInt32(dr["IdUsuario"]);

                                    listProduct.Add(product);
                                }
                            }
                        }
                    }

                    connetion.Close();
                }

                return listProduct;

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static void CreateProduct(Product product)
        {
            string query = "INSERT INTO Producto (Descripciones, Costo, PrecioVenta, Stock, IdUsuario)" +
                            "VALUES(@Descripciones,@Costo, @PrecioVenta, @Stock, @IdUsuario); ";

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("Descripciones", SqlDbType.VarChar) { Value = product.Description });
                        command.Parameters.Add(new SqlParameter("Costo", SqlDbType.Decimal) { Value = product.Cost });
                        command.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Decimal) { Value = product.SalePrice });
                        command.Parameters.Add(new SqlParameter("Stock", SqlDbType.BigInt) { Value = product.Stock });
                        command.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt) { Value = product.IdUser });
                        command.ExecuteNonQuery();

                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void UpdateProduct(Product product)
        {
            string query = "UPDATE Producto SET Descripciones = @Descripciones, Costo = @Costo, PrecioVenta = @PrecioVenta, Stock = @Stock, IdUsuario = @IdUsuario WHERE Id = @Id ";

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("Id", SqlDbType.BigInt) { Value = product.Id });
                        command.Parameters.Add(new SqlParameter("Descripciones", SqlDbType.VarChar) { Value = product.Description });
                        command.Parameters.Add(new SqlParameter("Costo", SqlDbType.Decimal) { Value = product.Cost });
                        command.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Decimal) { Value = product.SalePrice });
                        command.Parameters.Add(new SqlParameter("Stock", SqlDbType.Decimal) { Value = product.Stock });
                        command.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt) { Value = product.IdUser });

                        command.ExecuteNonQuery();

                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw;
            }


        }
        public static void DeleteProduct(Product product)
        {

            string query = "DELETE FROM Producto WHERE Id = @Id ";

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("Id", SqlDbType.BigInt) { Value = product.Id });

                        command.ExecuteNonQuery();

                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw;
            }


        }
    }
}
