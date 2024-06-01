using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Negocio;
using Entidad;
using System.Configuration;
using System.Data.SqlClient;

namespace Sistema_Web_De_Ventas_ADMIN.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Usuarios()
        {
            return View();
        }


        [HttpGet]//url que devuelve datos Httppost es caudno pedis y te devuelve
        public JsonResult ListarUsuarios()
        {
            List<Usuario> mLista = new List<Usuario>();

            mLista = new Cn_Usuarios().Listar();

            return Json( new { data = mLista }, JsonRequestBehavior.AllowGet);
        }


        ////*************Nueva acción para verificar la conexión***********************
        //public JsonResult VerificarConexion()
        //{
        //   string connectionString = ConfigurationManager.ConnectionStrings["Conexion"].ToString();
        //    bool conexionExitosa = false;
        //   string mensaje = "";

        //   using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        try
        //       {
        //           connection.Open();
        //            conexionExitosa = true;
        //           mensaje = "Conexión exitosa.";
        //     }
        //       catch (Exception ex)
        //       {
        //            mensaje = "Error al conectar: " + ex.Message;
        //        }
        //    }

        //   return Json(new { conexionExitosa, mensaje }, JsonRequestBehavior.AllowGet);
        //}
    }
}