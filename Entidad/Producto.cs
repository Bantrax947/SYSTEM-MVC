using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    //    CREATE TABLE PRODUCTOS(
    //IdProducto INT PRIMARY KEY IDENTITY,
    //Nombre VARCHAR(250),
    //Descripcion VARCHAR(250),
    //Idmarca INT,
    //CONSTRAINT FK_MARCA FOREIGN KEY(Idmarca)REFERENCES MARCAS(Idmarca),
    //IdCategoria INT,
    //CONSTRAINT FK_CATEGORIA FOREIGN KEY(IdCategoria) REFERENCES CATEGORIAS(IdCategoria),
    //Precio DECIMAL(10,2) DEFAULT 0,
    //Stock INT,
    //RutaImagen VARCHAR(100),
    //NombreImagen VARCHAR(100),
    //Activo BIT DEFAULT 1,
    //FechaRegistro DATETIME DEFAULT GETDATE()
    //)
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marca fkMarca { get; set; }
        public Categoria fkCategoria { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public string RutaImagen { get; set; }
        public string NombreImagen { get; set; }
        public bool Activo { get; set; }

    }
}
