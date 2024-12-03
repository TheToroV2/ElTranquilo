using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElTranquilo
{
    public class Usuario
    {
        public int UsuarioID { get; set; }
        public string Username { get; set; }
        public string PasswordH { get; set; }
        public string Rol { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
