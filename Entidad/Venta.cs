using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    //    CREATE TABLE VENTAS(
    //    Idventa INT PRIMARY KEY IDENTITY,
    //IdCliente INT,
    //CONSTRAINT FK_CLIENTE_VTA FOREIGN KEY (IdCliente) REFERENCES CLIENTES(IdCliente),
    //TotalProducto INT,
    //MontoTotal DECIMAL (10,2),
    //Contacto VARCHAR(50),
    //Idcuidad VARCHAR(50),
    //Telefono VARCHAR(50),
    //Direccion VARCHAR(500),
    //IdTransaccion VARCHAR(50),
    //FechaVenta DATETIME DEFAULT GETDATE()
    //)
    public class Venta
    {
        public int Idventa { get; set; }
        public int IdCliente { get; set; }
        public int TotalProducto { get; set; }
        public decimal MontoTotal { get; set; }
        public string Contacto { get; set; }
        public string idcuidad { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string IdTransaccion { get; set; }

        public List<DetalleVenta> oDetalleVenta { get; set; }

    }
}
