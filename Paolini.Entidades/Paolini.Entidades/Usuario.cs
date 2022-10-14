using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paolini.Entidades
{
    public class Usuario
    {
        public string Clave { get; set; }

        public string Email { get; set; }

        public string NombreUsuario { get; set; }

        public int TipoUsuario { get; set; }

        public DateTime UltimoIngreso { get; set; }

        private int _DiasUltimoIngreso;

        public int DiasUltimoIngreso
        {
            get {
                DateTime fechaDos = DateTime.Now;
                TimeSpan difFechas = fechaDos - UltimoIngreso;
                return difFechas.Days;
            }
            
        }

        public Usuario()
        {

        }

        public Usuario(string clave, string email, string nombreusuario,int tipousuario,DateTime ultimoingreso)
        {

        }

    }
}
