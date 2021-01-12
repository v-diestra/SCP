using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SCP.Core.ModelEntity
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public DateTime  FecRegistro { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
    }
}
