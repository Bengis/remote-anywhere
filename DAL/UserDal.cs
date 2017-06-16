using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;

namespace DAL
{
    public class UserDal
    {
        String strcon = "Data Source=.\\Database.sdf;Persist Security Info=False;";

        public void Insert(EUser user)
        {
         
            //Creamos nuestro objeto de conexion
            using (SqlCeConnection cnx = new SqlCeConnection(strcon))
            {
                try
                {
                    cnx.Open();
                    //Declaramos nuestra consulta de Acción Sql parametrizada
                    const string sqlQuery =
                        "INSERT INTO Users (Name, Password) VALUES (@user, @password)";
                    using (SqlCeCommand cmd = new SqlCeCommand(sqlQuery, cnx))
                    {
                        cmd.Parameters.AddWithValue("@user", user.User);
                        cmd.Parameters.AddWithValue("@password", user.Password);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (SqlCeException e) { Console.WriteLine(e); }
                cnx.Close();
            }
        }

        /// <summary>
        /// Devuelve una lista de usuarios ordenados por el campo Id de manera Ascendente
        /// </summary>
        /// <returns>Lista de usuarios</returns>
        public List<EUser> GetAll()
        {
            //Declaramos una lista del objeto EUser la cual será la encargada de
            //regresar una colección de los elementos que se obtengan de la BD
            //
            //La lista substituye a DataTable 
            List<EUser> users = new List<EUser>();
            try
            {
                using (SqlCeConnection cnx = new SqlCeConnection(strcon))
                {
                    cnx.Open();

                    const string sqlQuery = "SELECT * FROM Users ORDER BY Id ASC";
                    using (SqlCeCommand cmd = new SqlCeCommand(sqlQuery, cnx))
                    {
                        SqlCeDataReader dataReader = cmd.ExecuteReader();
                        //
                        //Preguntamos si el DataReader fue devuelto con datos
                        while (dataReader.Read())
                        {
                            //
                            //Instanciamos al objeto Euser para llenar sus propiedades
                            EUser user = new EUser
                            {
                                Id = Convert.ToInt32(dataReader["Id"]),
                                User = Convert.ToString(dataReader["Name"]),
                                Password = Convert.ToString(dataReader["Password"])
                            };
                            //
                            //Insertamos el objeto User dentro de la lista Users
                            users.Add(user);
                        }
                    }
                }
            }
            catch (Exception e) { Console.WriteLine(e); }
            return users;
        }

        /// <summary>
        /// Devuelve un Objeto User
        /// </summary>
        /// <param name="idUser">Id del usuario a buscar</param>
        /// <returns>Un registro con los valores del Usuario</returns>
        public EUser GetById(int idUser)
        {
            using (SqlCeConnection cnx = new SqlCeConnection(strcon))
            {
                cnx.Open();

                const string sqlGetById = "SELECT * FROM Users WHERE Id = @id";
                using (SqlCeCommand cmd = new SqlCeCommand(sqlGetById, cnx))
                {
                    //
                    //Utilizamos el valor del parámetro idUser para enviarlo al parámetro declarado en la consulta
                    //de selección SQL
                    cmd.Parameters.AddWithValue("@id", idUser);
                    SqlCeDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.Read())
                    {
                        EUser user = new EUser
                        {
                            Id = Convert.ToInt32(dataReader["Id"]),
                            User = Convert.ToString(dataReader["Name"]),
                            Password = Convert.ToString(dataReader["Password"])
                        };

                        return user;
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Devuelve un Objeto User
        /// </summary>
        /// <param name="User">Id del usuario a buscar</param>
        /// <returns>Un registro con los valores del Usuario</returns>
        public EUser GetByUser(String User)
        {
            using (SqlCeConnection cnx = new SqlCeConnection(strcon))
            {
                cnx.Open();

                const string sqlGetByUser = "SELECT * FROM Users WHERE Name = @user";
                using (SqlCeCommand cmd = new SqlCeCommand(sqlGetByUser, cnx))
                {
                    //
                    //Utilizamos el valor del parámetro idUser para enviarlo al parámetro declarado en la consulta
                    //de selección SQL
                    cmd.Parameters.AddWithValue("@user", User);
                    SqlCeDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.Read())
                    {
                        EUser user = new EUser
                        {
                            Id = Convert.ToInt32(dataReader["Id"]),
                            User = Convert.ToString(dataReader["Name"]),
                            Password = Convert.ToString(dataReader["Password"])
                        };

                        return user;
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Actualiza el Usuario correspondiente al Id proporcionado
        /// </summary>
        /// <param name="user">Valores utilizados para hacer el Update al registro</param>
        public void Update(EUser user)
        {
            using (SqlCeConnection cnx = new SqlCeConnection(strcon))
            {
                cnx.Open();
                const string sqlQuery =
                    "UPDATE Users SET Name = @user, Password = @password WHERE Id = @id";
                using (SqlCeCommand cmd = new SqlCeCommand(sqlQuery, cnx))
                {
                    cmd.Parameters.AddWithValue("@user", user.User);
                    cmd.Parameters.AddWithValue("@password", user.Password);
                    cmd.Parameters.AddWithValue("@id", user.Id);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Elimina un registro coincidente con el Id Proporcionado
        /// </summary>
        /// <param name="idUser">Id del registro a Eliminar</param>
        public void Delete(int idUser)
        {
            using (SqlCeConnection cnx = new SqlCeConnection(strcon))
            {
                cnx.Open();
                const string sqlQuery = "DELETE FROM Users WHERE Id = @id";
                using (SqlCeCommand cmd = new SqlCeCommand(sqlQuery, cnx))
                {
                    cmd.Parameters.AddWithValue("@id", idUser);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
