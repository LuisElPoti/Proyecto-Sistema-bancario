//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CAJA
{
    using System;
    using System.Collections.Generic;
    
    public partial class cajero
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cajero()
        {
            this.cuadres = new HashSet<cuadre>();
            this.transacciones = new HashSet<transaccione>();
        }
    
        public int id_cajero { get; set; }
        public int id_caja { get; set; }
        public string nombre_cajero { get; set; }
        public string apellido_cajero { get; set; }
        public string clave_cajero { get; set; }
        public int id_sucursal { get; set; }
        public System.DateTime fecha_ingreso { get; set; }
    
        public virtual sucursale sucursale { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cuadre> cuadres { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<transaccione> transacciones { get; set; }
    }
}
