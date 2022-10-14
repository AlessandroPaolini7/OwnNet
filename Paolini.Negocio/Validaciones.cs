using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Paolini.Datos;
using Paolini.Entidades;

namespace Paolini.Negocio
{
    public class Validaciones
    {
        public static bool EsMailValido(string email)
        {
            return Regex.IsMatch(email, @"([0-9a-zA-Z])+@([a-zA-Z])+.com");
        }

        static Paolini.Entidades.Usuario EsNombreNulo(string nombre)
        {
            try
            {
                UsuarioAdapter ua = new UsuarioAdapter();
                return ua.RecuperarUno(nombre);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
