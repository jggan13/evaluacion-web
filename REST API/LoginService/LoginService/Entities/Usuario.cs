using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginService.Entities
{
    public class Usuario
    {
        public Usuario(string nombre, string password)
        {
            this.Nombre = nombre;
            this.Password = password;
        }

        public string Nombre { get; set; }
        public string Password { get; set; }
    }
}