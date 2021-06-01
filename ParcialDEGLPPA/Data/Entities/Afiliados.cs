using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParcialDEGLPPA.Data.Entities
{
    public class Afiliados : IdentityBase
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Cuit { get; set; }

        public string NCompleto
        {
            get
            {
                return Nombre + " " + Apellido;
            }
        }
    }
}