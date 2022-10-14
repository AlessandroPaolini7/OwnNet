using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Paolini.Datos
{
    public class UsuarioAdapter: Base
    {
        public List<Paolini.Entidades.Usuario> RecuperarTodos()
        {
            List<Paolini.Entidades.Usuario> Usuarios = new List<Entidades.Usuario>();
            OpenConn();
            SqlCommand cmdUsuario = new SqlCommand("SELECT * FROM Usuarios", SqlConn);
            SqlDataReader drUsuario = cmdUsuario.ExecuteReader();
            while (drUsuario.Read())
            {
                Entidades.Usuario user = new Entidades.Usuario();
                user.Clave = (string)drUsuario["Clave"];
                user.NombreUsuario = (string)drUsuario["NombreUsuario"];
                user.Email = (string)drUsuario["Email"];
                user.TipoUsuario = (int)drUsuario["TipoUsuario"];
                user.UltimoIngreso = (DateTime)drUsuario["UltimoIngreso"];
                Usuarios.Add(user);
            }
            CloseConn();
            return Usuarios;
        }

        public void Agregar(Paolini.Entidades.Usuario user)
        {
            OpenConn();
            SqlCommand cmdUsuario = new SqlCommand("INSERT INTO Usuarios (Clave, NombreUsuario, Email, TipoUsuario) values (@Clave, @NombreUsuario, @Email, @TipoUsuario)", SqlConn);
            cmdUsuario.Parameters.Add("@Clave", SqlDbType.VarChar, 50).Value = user.Clave;
            cmdUsuario.Parameters.Add("@NombreUsuario", SqlDbType.VarChar, 50).Value = user.NombreUsuario;
            cmdUsuario.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = user.Email;
            cmdUsuario.Parameters.Add("@TipoUsuario", SqlDbType.Int).Value = user.TipoUsuario;
            cmdUsuario.ExecuteNonQuery();
            CloseConn();
        }

        public Paolini.Entidades.Usuario RecuperarUno(string nombre)
        {
            try
            {
                List<Paolini.Entidades.Usuario> Usuarios = RecuperarTodos();
                Entidades.Usuario user = (Entidades.Usuario)(from Usuario in Usuarios where Usuario.NombreUsuario == nombre select Usuario);
                return user;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
