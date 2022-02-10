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
    
    public partial class RemisionEntrada
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RemisionEntrada()
        {
            this.RemisionEntradaDetalle = new HashSet<RemisionEntradaDetalle>();
        }
    
        public int Id { get; set; }
        public string Codigo { get; set; }
        public System.DateTime FechaDcumento { get; set; }
        public int IdProveedor { get; set; }
        public int IdAlmacen { get; set; }
        public int Estado { get; set; }
    
        public virtual Almacen Almacen { get; set; }
        public virtual Proveedor Proveedor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RemisionEntradaDetalle> RemisionEntradaDetalle { get; set; }
    }
}