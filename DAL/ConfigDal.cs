using System;
using System.Data.SqlServerCe;

namespace DAL
{
    public class ConfigDal
    {
        String strcon = "Data Source=.\\Database.sdf;Persist Security Info=False;";

        public void Insert(EConfig config)
        {
         
            //Creamos nuestro objeto de conexion
            using (SqlCeConnection cnx = new SqlCeConnection(strcon))
            {
                try
                {
                    cnx.Open();
                    //Declaramos nuestra consulta de Acción Sql parametrizada
                    const string sqlQuery =
                        "INSERT INTO Config (Type, Port) VALUES (@type, @port)";
                    using (SqlCeCommand cmd = new SqlCeCommand(sqlQuery, cnx))
                    {
                        cmd.Parameters.AddWithValue("@type", config.Type);
                        cmd.Parameters.AddWithValue("@port", config.Port);
                   
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (SqlCeException e) { Console.WriteLine(e); }
                cnx.Close();
            }
        }

        public void Update(EConfig config) {
            using (SqlCeConnection cnx = new SqlCeConnection(strcon))
            {
                try
                {
                    cnx.Open();
                    const string sqlQuery ="UPDATE Config SET Type= @type, Port=@port";
                    using (SqlCeCommand cmd = new SqlCeCommand(sqlQuery, cnx))
                    {
                        cmd.Parameters.AddWithValue("@type", config.Type);
                        cmd.Parameters.AddWithValue("@port", config.Port);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (SqlCeException e) { Console.WriteLine(e); }
                cnx.Close();
            }
        }

        /// <summary>
        /// Return configuration
        /// </summary>
        /// <returns>Configuration</returns>
        public EConfig GetConfig()
        {
            //Declaramos una lista del objeto EConfig la cual será la encargada de
            //regresar una colección de los elementos que se obtengan de la BD
            EConfig config=null;
            //La lista substituye a DataTable 
            try
            {
                using (SqlCeConnection cnx = new SqlCeConnection(strcon))
                {
                    cnx.Open();

                    const string sqlQuery = "SELECT * FROM Config";
                    using (SqlCeCommand cmd = new SqlCeCommand(sqlQuery, cnx))
                    {
                        SqlCeDataReader dataReader = cmd.ExecuteReader();
                        //
                        //Preguntamos si el DataReader fue devuelto con datos
                        if (dataReader.Read())
                        {
                            //
                            //Instanciamos al objeto Euser para llenar sus propiedades
                            config = new EConfig
                            {
                                Type = Convert.ToInt32(dataReader["Type"]),
                                Port = Convert.ToString(dataReader["Port"])
                            };     
                        }
                    }
                }
            }
            catch (Exception e) { Console.WriteLine(e); }
            return config;
        }
    }
}
