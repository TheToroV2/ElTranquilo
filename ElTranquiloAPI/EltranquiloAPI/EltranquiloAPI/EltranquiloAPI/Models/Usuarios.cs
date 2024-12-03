using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EltranquiloAPI.Models
{
    public class Usuarios
    {       
            public int UsuarioID { get; set; }
            public string Username { get; set; }
            public string PasswordH { get; set; }
            public string Rol { get; set; }
            public DateTime FechaCreacion { get; set; }
    }
}