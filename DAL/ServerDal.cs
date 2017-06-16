using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Configuration;

namespace DAL
{
    public class ServerDal
    {
        String strcon = "Data Source=.\\Database.sdf;Persist Security Info=False;";

        public void Insert(EServer server)
        {
         
            //Creamos nuestro objeto de conexion usando nuestro archivo de configuraciones
            //using (SqlCeConnection cnx = new SqlCeConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            using (SqlCeConnection cnx = new SqlCeConnection(strcon))
            {
                try
                {
                    cnx.Open();
                    //Declaramos nuestra consulta de Acción Sql parametrizada
                    const string sqlQuery =
                        "INSERT INTO Servers (Name, Ip, Port) VALUES (@name, @ip, @port)";
                    using (SqlCeCommand cmd = new SqlCeCommand(sqlQuery, cnx))
                    {
                        cmd.Parameters.AddWithValue("@name", server.Name);
                        cmd.Parameters.AddWithValue("@ip", server.Ip);
                        cmd.Parameters.AddWithValue("@port", server.Port);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (SqlCeException e) { Console.WriteLine(e); }
                cnx.Close();
            }
        }

        /// <summary>
        /// Devuelve una lista de servidores ordenados por el campo Id de manera Ascendente
        /// </summary>
        /// <returns>Lista de usuarios</returns>
        public List<EServer> GetAll()
        {
            //Declaramos una lista del objeto EUser la cual será la encargada de
            //regresar una colección de los elementos que se obtengan de la BD
            //
            //La lista substituye a DataTable 
            List<EServer> servers = new List<EServer>();
            try
            {
                using (SqlCeConnection cnx = new SqlCeConnection(strcon))
                {
                    cnx.Open();

                    const string sqlQuery = "SELECT * FROM Servers ORDER BY Id ASC";
                    using (SqlCeCommand cmd = new SqlCeCommand(sqlQuery, cnx))
                    {
                        SqlCeDataReader dataReader = cmd.ExecuteReader();
                        //
                        //Preguntamos si el DataReader fue devuelto con datos
                        while (dataReader.Read())
                        {
                            //
                            //Instanciamos al objeto Euser para llenar sus propiedades
                            EServer server = new EServer
                            {
                                Id = Convert.ToInt32(dataReader["Id"]),
                                Name = Convert.ToString(dataReader["Name"]),
                                Ip = Convert.ToString(dataReader["Ip"]),
                                Port = Convert.ToString(dataReader["Port"])
                            };
                            //
                            //Insertamos el objeto User dentro de la lista Users
                            servers.Add(server);
                        }
                    }
                }
            }
            catch (Exception e) { Console.WriteLine(e); }
            return servers;
        }

        /// <summary>
        /// Devuelve un Objeto Servwr
        /// </summary>
        /// <param name="idUser">Id del usuario a buscar</param>
        /// <returns>Un registro con los valores del Usuario</returns>
        public EServer GetByid(int idServer)
        {
            try
            {
                using (SqlCeConnection cnx = new SqlCeConnection(strcon))
            {
                cnx.Open();

                const string sqlGetById = "SELECT * FROM Servers WHERE Id = @id";
                using (SqlCeCommand cmd = new SqlCeCommand(sqlGetById, cnx))
                {
                    //
                    //Utilizamos el valor del parámetro idUser para enviarlo al parámetro declarado en la consulta
                    //de selección SQL
                    cmd.Parameters.AddWithValue("@id", idServer);
                    SqlCeDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.Read())
                    {
                        EServer server = new EServer
                        {
                            Id = Convert.ToInt32(dataReader["Id"]),
                            Name = Convert.ToString(dataReader["Name"]),
                            Ip = Convert.ToString(dataReader["Ip"]),
                            Port = Convert.ToString(dataReader["Port"])
                        };

                        return server;
                    }
                }
             }
            }
            catch (Exception e) { Console.WriteLine(e); }
            return null;
        }

        /// <summary>
        /// Devuelve un Objeto User
        /// </summary>
        /// <param name="User">Id del usuario a buscar</param>
        /// <returns>Un registro con los valores del Usuario</returns>
        public EServer GetByName(String Name)
        {
            try
            {
            using (SqlCeConnection cnx = new SqlCeConnection(strcon))
            {
                cnx.Open();

                const string sqlGetByUser = "SELECT * FROM Servers WHERE Name = @name";
                using (SqlCeCommand cmd = new SqlCeCommand(sqlGetByUser, cnx))
                {
                    //
                    //Utilizamos el valor del parámetro idUser para enviarlo al parámetro declarado en la consulta
                    //de selección SQL
                    cmd.Parameters.AddWithValue("@name", Name);
                    SqlCeDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.Read())
                    {
                        EServer server = new EServer
                        {
                            Id = Convert.ToInt32(dataReader["Id"]),
                            Name = Convert.ToString(dataReader["Name"]),
                            Ip = Convert.ToString(dataReader["Ip"]),
                            Port = Convert.ToString(dataReader["Port"])
                        };

                        return server;
                    }
                }
             }
            }
            catch (Exception e) { Console.WriteLine(e); }
            return null;
        }

        /// <summary>
        /// Actualiza el Usuario correspondiente al Id proporcionado
        /// </summary>
        /// <param name="server">Valores utilizados para hacer el Update al registro</param>
        public void Update(EServer server)
        {
            try
            { 
            using (SqlCeConnection cnx = new SqlCeConnection(strcon))
            {
                cnx.Open();
                const string sqlQuery =
                    "UPDATE Servers SET Name = @name, Ip= @ip, Port = @port WHERE Id = @id";
                using (SqlCeCommand cmd = new SqlCeCommand(sqlQuery, cnx))
                {
                    cmd.Parameters.AddWithValue("@name", server.Name);
                    cmd.Parameters.AddWithValue("@ip", server.Ip);
                    cmd.Parameters.AddWithValue("@port", server.Port);
                    cmd.Parameters.AddWithValue("@id", server.Id);

                    cmd.ExecuteNonQuery();
                }
                }
            }
            catch (Exception e) { Console.WriteLine(e); }
        }

        /// <summary>
        /// Elimina un registro coincidente con el Id Proporcionado
        /// </summary>
        /// <param name="idServer">Id del registro a Eliminar</param>
        public void Delete(int idServer)
        {
            try
            { 
            using (SqlCeConnection cnx = new SqlCeConnection(strcon))
            {
                cnx.Open();
                const string sqlQuery = "DELETE FROM Servers WHERE Id = @id";
                using (SqlCeCommand cmd = new SqlCeCommand(sqlQuery, cnx))
                {
                    cmd.Parameters.AddWithValue("@id", idServer);

                    cmd.ExecuteNonQuery();
                }
            }
            }
            catch (Exception e) { Console.WriteLine(e); }
        }
    }
}
