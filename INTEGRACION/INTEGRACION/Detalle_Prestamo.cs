//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace INTEGRACION
{
    using System;
    using System.Collections.Generic;
    
    public partial class Detalle_Prestamo
    {
        public int idDetallePrestamo { get; set; }
        public int idPrestamo { get; set; }
        public int idEstado { get; set; }
        public decimal MontoPago { get; set; }
        public decimal InteresesGenerados { get; set; }
        public decimal CapitalAmortizado { get; set; }
        public System.DateTime FechaPago { get; set; }
        public decimal SaldoPendiente { get; set; }
        public System.DateTime FechaVencimiento { get; set; }
        public Nullable<System.DateTime> FechaIngreso { get; set; }
    
        public virtual Estado Estado { get; set; }
        public virtual Prestamo Prestamo { get; set; }
    }
}
