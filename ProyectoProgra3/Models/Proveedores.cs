using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoProgra3.Models
{
    public class Proveedores
    {
        [Key]
        public int ProveedorID { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        //Propiedad de navegacion para productos
        public virtual List<Productos > Productos { get; set; }

    }
}