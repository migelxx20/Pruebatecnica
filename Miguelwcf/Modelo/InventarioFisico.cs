//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Miguelwcf.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class InventarioFisico
    {
        public int Id { get; set; }
        public int IdProducto { get; set; }
        public int IdAlmacen { get; set; }
        public int Cantidad { get; set; }
    
        public virtual Almacen Almacen { get; set; }
        public virtual Producto Producto { get; set; }
    }
}