using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    ////    CREATE TABLE CARRITO(
    ////    Idcarrito INT PRIMARY KEY IDENTITY,
    ////IdClientes INT CONSTRAINT FK_CLIENTE_CARRITO FOREIGN KEY (IdClientes) REFERENCES CLIENTES(IdCliente),
    ////IdProducto INT CONSTRAINT FK_PRODUCO_CARRITO FOREIGN KEY (IdProducto) REFERENCES PRODUCTOS(IdProducto),
    ////Cantidad INT
    ////)
    public class Carrito
    {
        public int Idcarrito { get; set; }
        public Cliente fkCliente { get; set; }
        public Producto fkProducto { get; set; }
        public int Cantidad { get; set; }
    }
}
