using ManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.Data
{
    public class UserData
    {
        private readonly static string _connectionString = @"YOUR CONNETION DATABASE";
        public static List<User> LoadUser()
        {
            List<User> listUser = new List<User>();

            string query = "SELECT Id,Nombre,Apellido,NombreUsuario,Contraseña,Mail FROM Usuario";

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader dr = command.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    User user = new User();

                                    user.Id = Convert.ToInt32(dr["Id"]);
                                    user.NameUser = dr["Nombre"].ToString();
                                    user.Surname = dr["Apellido"].ToString();
                                    user.Username = dr["NombreUsuario"].ToString();
                                    user.Password = dr["Contraseña"].ToString();
                                    user.Email = dr["Mail"].ToString();

                                    listUser.Add(user);
                                }
                            }
                        }
                    }
                    connection.Close();
                }

                return listUser;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static void CreateUser(User user)
        {

            string query = "INSERT INTO Usuario (Nombre, Apellido, NombreUsuario, Contraseña, Mail) VALUES (@Nombre, @Apellido, @NombreUsuario, @Contraseña, @Mail) ";

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = user.NameUser });
                        command.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = user.Surname });
                        command.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = user.Username });
                        command.Parameters.Add(new SqlParameter("Contraseña", SqlDbType.VarChar) { Value = user.Password });
                        command.Parameters.Add(new SqlParameter("Mail", SqlDbType.VarChar) { Value = user.Email });
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

        public static void UpdateUser(User user)
        {

            string query = "UPDATE Usuario SET Nombre = @Nombre, Apellido = @Apellido, NombreUsuario = @NombreUsuario, Contraseña = @Contraseña, Mail = @Mail WHERE Id = @Id";

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("Id", SqlDbType.BigInt) { Value = user.Id });
                        command.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = user.NameUser });
                        command.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = user.Surname });
                        command.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = user.Username });
                        command.Parameters.Add(new SqlParameter("Contraseña", SqlDbType.VarChar) { Value = user.Password });
                        command.Parameters.Add(new SqlParameter("Mail", SqlDbType.VarChar) { Value = user.Email });
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

        public static void DeleteUser(User user)
        {

            string query = "DELETE Usuario WHERE Id = @Id";

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("Id", SqlDbType.BigInt) { Value = user.Id });

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
