using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoProgra3.Models
{
    public class Detalle_Compra
    {
        [Key]
        public int Detalle_CompraID { get; set; }

        //llaves foraneas
        public int CompraID { get; set; }
        public virtual Compras Compras { get; set; }

        public int ProductoID { get; set; }
        public virtual  Productos Productos { get; set; }

        public int ClienteID { get; set; }
        public virtual Clientes Clientes { get; set; }

    }
}