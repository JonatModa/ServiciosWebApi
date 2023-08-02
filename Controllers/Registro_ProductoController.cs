using ServiciosWeb.Datos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServiciosWeb.WebApi.Controllers
{
    public class Registro_ProductoController : ApiController
    {
        LibreriaConnection BD = new LibreriaConnection();
        [HttpGet]
        public IEnumerable<Registro_Producto> Get()//viene del serviciosWeb.Datos
        {
            var listado = BD.Registro_Producto.ToList();
            return listado;
        }

        [HttpGet]
        public Registro_Producto Get(int Id_Producto)//viene del serviciosWeb.Datos
        {
            var listado = BD.Registro_Producto.FirstOrDefault(x => x.Id_Producto == Id_Producto);
            return listado;
        }
    }
}
