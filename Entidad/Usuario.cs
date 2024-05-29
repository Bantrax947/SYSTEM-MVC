using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    //    CREATE TABLE USUARIOS(
    //IdUsuario INT PRIMARY KEY IDENTITY,
    //Nombres VARCHAR(100),
    //Apellidos VARCHAR(100),
    //Email VARCHAR(50),
    //Clave VARCHAR(50),
    //Restablecer BIT DEFAULT 1,
    //Activo BIT DEFAULT 1,
    //FechaRegistro DATETIME DEFAULT GETDATE()
    //)
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public bool Restablecer { get; set; }
        public string Clave { get; set; }
        public bool Activo { get; set; }
    }
}
