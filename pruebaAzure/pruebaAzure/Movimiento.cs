//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pruebaAzure
{
    using System;
    using System.Collections.Generic;
    
    public partial class Movimiento
    {
        public int idMovimiento { get; set; }
        public int idCuenta { get; set; }
        public int idTransaccion { get; set; }
        public decimal Monto { get; set; }
        public string Descripcion { get; set; }
        public Nullable<System.DateTime> FechaIngreso { get; set; }
    
        public virtual Cuenta Cuenta { get; set; }
        public virtual Transaccion Transaccion { get; set; }
    }
}
