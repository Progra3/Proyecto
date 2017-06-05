using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoProgra3.Models
{
    public class Clientes
    {
        [Key]
        public int ClienteID { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        //propiedad de navegacion para Detalle_Compra
        public virtual  List<Detalle_Compra> Detalle_Compra { get; set; }

    }
}