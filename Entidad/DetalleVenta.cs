using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    //    CREATE TABLE DETALLE_VENTA(
    //IdDetalle_Venta INT PRIMARY KEY IDENTITY,
    //    Idventa INT,
    //CONSTRAINT FK_VTA_DETALLE FOREIGN KEY (Idventa) REFERENCES VENTAS(Idventa),
    //    IdProducto INT,
    //CONSTRAINT FK_PRODUCTO_DETALLE_VTA FOREIGN KEY (Idproducto) REFERENCES PRODUCTOS(IdProducto),
    //Cantidad INT,
    //Total DECIMAL(10,2)
    //)
    public class DetalleVenta
    {
        public int IdDetalle_Venta { get; set; }
        public int Idventa { get; set; }
        public Producto fkIdProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }
        public string IdTransaccion { get; set; }

    }
}
