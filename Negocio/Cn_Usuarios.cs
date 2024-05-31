using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;
using Entidad;

namespace Negocio
{
    public class Cn_Usuarios
    {
        private CD_Usuarios ObjDato = new CD_Usuarios();//Método para llamar a los datos de la capa datos en la Clase CD_Usuarios

        public List<Usuario> listar() 
        { //Acá se puede realizar todo tipo de logica de filtrado o de 
            return ObjDato.listar();
        }



    }
}
