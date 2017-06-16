using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;

namespace DAL
{
    public class LogDal
    {
        String strcon = "Data Source=.\\Database.sdf;Persist Security Info=False;";

        public void Insert(ELog log)
        {
         
            //Creamos nuestro objeto de conexion
            using (SqlCeConnection cnx = new SqlCeConnection(strcon))
            {
                try
                {
                    cnx.Open();
                    //Declaramos nuestra consulta de Acción Sql parametrizada
                    const string sqlQuery =
                        "INSERT INTO Logs (Description, DateInserted) VALUES (@description, @dateinserted)";
                    using (SqlCeCommand cmd = new SqlCeCommand(sqlQuery, cnx))
                    {
                        cmd.Parameters.AddWithValue("@description", log.Description);
                        cmd.Parameters.AddWithValue("@dateInserted", log.DateInserted);
                   
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (SqlCeException e) { Console.WriteLine(e); }
                cnx.Close();
            }
        }

        /// <summary>
        /// Devuelve una lista de registros ordenados por el campo Id de manera Ascendente
        /// </summary>
        /// <returns>Lista de usuarios</returns>
        public List<ELog> GetAll()
        {
            //Declaramos una lista del objeto EUser la cual será la encargada de
            //regresar una colección de los elementos que se obtengan de la BD
            //
            //La lista substituye a DataTable 
            List<ELog> logs = new List<ELog>();
            try
            {
                using (SqlCeConnection cnx = new SqlCeConnection(strcon))
                {
                    cnx.Open();

                    const string sqlQuery = "SELECT * FROM Logs ORDER BY DateInserted DESC";
                    using (SqlCeCommand cmd = new SqlCeCommand(sqlQuery, cnx))
                    {
                        SqlCeDataReader dataReader = cmd.ExecuteReader();
                        //
                        //Preguntamos si el DataReader fue devuelto con datos
                        while (dataReader.Read())
                        {
                            //
                            //Instanciamos al objeto Euser para llenar sus propiedades
                            ELog log = new ELog
                            {
                                Id = Convert.ToInt32(dataReader["Id"]),
                                Description = Convert.ToString(dataReader["Description"]),
                                DateInserted = Convert.ToString(dataReader["DateInserted"])
                            };
                            //
                            //Insertamos el objeto User dentro de la lista Users
                            logs.Add(log);
                        }
                    }
                }
            }
            catch (Exception e) { Console.WriteLine(e); }
            return logs;
        }
    }
}
