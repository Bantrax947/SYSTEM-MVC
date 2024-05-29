using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    //    CREATE TABLE CATEGORIAS(
    //IdCategoria INT PRIMARY KEY IDENTITY,
    //Descripcion VARCHAR(100),
    //Activo BIT DEFAULT 1,
    //FechaRegistro DATETIME DEFAULT getdate()
    //)

    public class Categoria
    {
        public int IdCategoria { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
    }
}
