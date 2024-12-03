using Conector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EltranquiloAPI.Controllers
{
    public class UsuariosController : ApiController
    {
        // GET: api/Usuarios
        public IEnumerable<Usuarios> Get()
        {
            using (ElTranquiloDBEntities objEntidad = new ElTranquiloDBEntities())
            {
                return objEntidad.Usuarios.ToList();
            }

        }

        // GET: api/Usuarios/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Usuarios
        [HttpPost]
        [Route("api/Usuarios/Authenticate")]
        public IHttpActionResult Authenticate([FromBody] UsuarioLogin login)
        {
            using (ElTranquiloDBEntities objEntidad = new ElTranquiloDBEntities())
            {
                var user = objEntidad.Usuarios.FirstOrDefault(u => u.Username == login.Username && u.Passwordh == login.PasswordH);
                if (user != null)
                {
                    return Ok(new { success = true, message = "Authentication successful", rol = user.Rol });
                }
                else
                {
                    return Ok(new { success = false, message = "Invalid username or password" });
                }
            }
        }

        // PUT: api/Usuarios/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Usuarios/5
        public void Delete(int id)
        {
        }
    }

    public class UsuarioLogin
    {
        public string Username { get; set; }
        public string PasswordH { get; set; }
    }
}
