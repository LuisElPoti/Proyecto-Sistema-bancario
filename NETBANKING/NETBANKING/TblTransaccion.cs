//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NETBANKING
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblTransaccion
    {
        public int TransaccionID { get; set; }
        public int TipoTransaccionID { get; set; }
        public int MonedaID { get; set; }
        public string Concepto { get; set; }
        public string CorreoCliente { get; set; }
        public string CorreoBeneficiario { get; set; }
        public int EstadoID { get; set; }
        public decimal Monto { get; set; }
        public string CuentaOrigen { get; set; }
        public string CuentaDestino { get; set; }
        public System.DateTime FechaRegistro { get; set; }
    
        public virtual TblEstado TblEstado { get; set; }
        public virtual TblMonedaTransaccion TblMonedaTransaccion { get; set; }
        public virtual TblTipoTransaccion TblTipoTransaccion { get; set; }
    }
}
