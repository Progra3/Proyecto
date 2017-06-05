using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoProgra3.Models
{
    public class Compras
    {
        [Key]
        public int CompraID { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total_Compra { get; set; }

        //propiedad de navegacion para la tabla Detalle_Compras
        public virtual List<Detalle_Compra> Detalle_Compra { get; set; }

    }
}