using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;

namespace DAL
{
    public class MainDal
    {
        String strConCE = "Data Source=.\\Database.sdf;Persist Security Info=False;";

        public void crearBBDD()
        {
            string fileName = "Database.sdf";
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            //Crea la BBDD de Sql Compact con la tabla necesarias para el prototipo
            SqlCeEngine en = new SqlCeEngine(strConCE);
            en.CreateDatabase();
            String sSql = "";
            sSql = "CREATE TABLE[Config] ([Port] nvarchar(5) NOT NULL, [Type] int NOT NULL)";
            EjecutarComandoCE(sSql, "");
            sSql="CREATE TABLE[Logs] ([Id] int IDENTITY(1,1) NOT NULL, [Description] nvarchar(1000) NOT NULL, [DateInserted] nvarchar(25) NULL)";
            EjecutarComandoCE(sSql, "");
            sSql = "ALTER TABLE[Logs] ADD CONSTRAINT[PK_Logs] PRIMARY KEY([Id])";
            EjecutarComandoCE(sSql, "");
            sSql = "CREATE TABLE[Servers] ([Id] int IDENTITY(1,1) NOT NULL, [Name] nvarchar(100) NOT NULL, [Ip] nvarchar(100) NOT NULL, [Port] int NOT NULL)";
            EjecutarComandoCE(sSql, "");
            sSql = "ALTER TABLE[Servers] ADD CONSTRAINT[PK_Server] PRIMARY KEY([Id])";
            EjecutarComandoCE(sSql, "");
            sSql = "CREATE TABLE[Users] ([Id] int IDENTITY(1,1) NOT NULL, [Name] nvarchar(100) NOT NULL, [Password] nvarchar(100) NOT NULL)";
            EjecutarComandoCE(sSql, "");
            sSql = "ALTER TABLE[Users] ADD CONSTRAINT[PK_Users] PRIMARY KEY([Id])";
            EjecutarComandoCE(sSql, "");
        }

        public void rellenarBBDD()
        {
            //Rellena la BBDD de Sql Compact de datos minimos para trabajar
            String sSql = "";
            sSql="INSERT INTO[Logs] ([Description],[DateInserted]) VALUES(N'Logs inicializados', N'10/04/2017 15:00')";
            EjecutarComandoCE(sSql, "");
            sSql = "INSERT INTO[Servers] ([Name],[Ip],[Port]) VALUES(N'CASA', N'192.168.0.1', 4444)";
            EjecutarComandoCE(sSql, "");
            sSql = "INSERT INTO[Servers]([Name],[Ip],[Port]) VALUES(N'UOC', N'192.168.6.150',4444)";
            EjecutarComandoCE(sSql, "");
            sSql="INSERT INTO[Users] ([Name],[Password]) VALUES(N'PACO', N'1235')";
            EjecutarComandoCE(sSql, "");
            sSql = "INSERT INTO[Users]([Name],[Password]) VALUES(N'LUIS', N'1234')";
            EjecutarComandoCE(sSql, "");
            sSql = "INSERT INTO[Users] ([Name],[Password]) VALUES(N'MARIA', N'1234')";
            EjecutarComandoCE(sSql, "");
            sSql = "INSERT INTO[Config] ([Type],[Port]) VALUES(0, N'2020')";
            EjecutarComandoCE(sSql, "");
        }

        public Boolean existeBBDD()
        {
            Boolean bExiste = false;
            string fileName = "Database.sdf";
            if (File.Exists(fileName))
            {
                bExiste = true;
            }
            return bExiste;
        }

        public bool EjecutarComandoCE(string SqlCons, string StrConexion = "")
        {
            if (string.IsNullOrEmpty(StrConexion))
            {
                StrConexion = strConCE;
            }
            if (string.IsNullOrEmpty(SqlCons))
            {
                return false;
            }
            SqlCeConnection Bd = new SqlCeConnection(StrConexion);
            SqlCeCommand Cm = default(SqlCeCommand);
            try
            {
                Bd.Open();
                Cm = new SqlCeCommand(SqlCons, Bd);
                Cm.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                Bd.Close();
            }
        }

    }
}
