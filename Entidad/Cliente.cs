using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    //    CREATE TABLE CLIENTES(
    //IdCliente INT PRIMARY KEY IDENTITY,
    //Nombres VARCHAR(100),
    //Apellidos VARCHAR(100),
    //Email VARCHAR(250),
    //Clave VARCHAR(150),
    //Restablecer BIT DEFAULT 0,
    //FechaRegistro DATETIME DEFAULT GETDATE()
    //)
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Clave { get; set; }
        public bool Restablecer { get; set; }

    }
}
