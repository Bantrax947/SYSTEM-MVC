using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Referencia hacia la capa de datos
using Entidad;
//Referencia para poder tener acceso a SLQCONECTION
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class CD_Usuarios//Clase en donde se trae los datos de la Base de datos
    {
        public List<Usuario> Listar()
        {
            List<Usuario> Lista = new List<Usuario>();

            try{
                using (SqlConnection oconexion = new SqlConnection(Conexion.cn))//La conexion de la Base de datos
                {
                    string querry = "SELECT IdUsuario, Nombres,Apellidos, Email,Restablecer,Clave,Activo FROM USUARIOS";

                    SqlCommand cmd = new SqlCommand(querry, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader()) //Da lectura al resultado de del querry 
                    {
                        while (dr.Read())
                        {
                            Lista.Add//Se Agregan todos los campos a la lista
                              (
                                new Usuario()
                                {
                                    IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                                    Nombres = dr["Nombres"].ToString(),
                                    Apellidos = dr["Apellidos"].ToString(),
                                    Email = dr["Email"].ToString(),
                                    Restablecer = Convert.ToBoolean(dr["Restablecer"]),
                                    Clave = dr["Clave"].ToString(),
                                    Activo = Convert.ToBoolean(dr["Activo"]),

                                }


                              );


                        }

                    }

                }

            }catch(Exception ex)
{
                // Log the exception
                Console.WriteLine(ex.Message);
                Lista = new List<Usuario>();
            }





            return Lista;
        }
    }
}
