using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Paolini.Entidades;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Paolini.Datos
{
    public class Base
    {
        public SqlConnection SqlConn { get; set; }

        public void OpenConn()
        {
            SqlConn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Program Files\\Microsoft SQL Server\\MSSQL15.SQLEXPRESS01\\MSSQL\\Backup\\Net.DB.Usuario.mdf\"; Integrated Security=True;Connect Timeout=30");
            SqlConn.Open();
        }

        public void CloseConn()
        {
            SqlConn.Close();
            SqlConn = null;
        }
    }
}
