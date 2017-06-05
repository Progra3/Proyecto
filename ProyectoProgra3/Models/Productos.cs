using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoProgra3.Models
{
    public class Productos
    {
        [Key]
        public int ProductoID { get; set; }
        public string Nombre { get; set; }
        public string Detalle { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }

        //llave foranea de Categoria
        public int CategoriaID { get; set; }
        public virtual Categoria Categoria { get; set; }
        //llave foranea de proveedores
        public int ProveedorID { get; set; }
        public virtual Proveedores Proveedores { get; set; }

        //propiedad de navegacion
        public virtual List<Detalle_Compra> Detalle_Compra { get; set; }


    }
}