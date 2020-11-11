using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Billetera.Web.Models
{
    public class LoginRequest
    {
        private string nombreUsuario;
        private string password;
        public string NombreUsuario { get=> nombreUsuario; set=> nombreUsuario = value; }
        public string Password { get=> password; set=>password=value; }
    }
}