using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
//    CREATE TABLE CUIDADES(
//Idcuidad INT PRIMARY KEY IDENTITY,
//Nombre VARCHAR(50),
//IdDepartamentos Int,
//CONSTRAINT FK_DEPARTAMENTOS FOREIGN KEY(IdDepartamentos) REFERENCES DEPARTAMENTOS(IdDepartamentos)
//)
    public class Cuidad
    {
        public int Idcuidad { get; set; }
        public string Nombre { get; set; }
        public Departamento fkIdDepartamentos { get; set; }

    }
}
