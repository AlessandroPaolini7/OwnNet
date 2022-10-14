using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Paolini.Datos;
using Paolini.Entidades;

namespace Paolini.Negocio
{
    public class Usuario
    {
        UsuarioAdapter user;

        static public List<Paolini.Entidades.Usuario> RecuperarTodos()
        {
            UsuarioAdapter ua = new UsuarioAdapter();
            return ua.RecuperarTodos();
        }

        static public void Agregar(Paolini.Entidades.Usuario user)
        {
            UsuarioAdapter ua = new UsuarioAdapter();
            ua.Agregar(user);
        }

        static public Paolini.Entidades.Usuario RecuperarUno(string nombre)
        {
            UsuarioAdapter ua = new UsuarioAdapter();
            return ua.RecuperarUno(nombre);
        }
    }
}
