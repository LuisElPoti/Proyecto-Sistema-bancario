﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DBNetBankingEntities1 : DbContext
    {
        public DBNetBankingEntities1()
            : base("name=DBNetBankingEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TblBanco> TblBancoes { get; set; }
        public virtual DbSet<TblBeneficiario> TblBeneficiarios { get; set; }
        public virtual DbSet<TblCuentaBeneficiario> TblCuentaBeneficiarios { get; set; }
        public virtual DbSet<TblEstado> TblEstadoes { get; set; }
        public virtual DbSet<TblMonedaTransaccion> TblMonedaTransaccions { get; set; }
        public virtual DbSet<TblTipoTransaccion> TblTipoTransaccions { get; set; }
        public virtual DbSet<TblTransaccion> TblTransaccions { get; set; }
        public virtual DbSet<TblUsuario> TblUsuarios { get; set; }
    
        public virtual int spInsertarBanco(string descripcion)
        {
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsertarBanco", descripcionParameter);
        }
    
        public virtual int spInsertarBeneficiario(Nullable<int> usuarioID, Nullable<int> tipoDocumento, string documento, string alias, string correo, Nullable<int> bancoID)
        {
            var usuarioIDParameter = usuarioID.HasValue ?
                new ObjectParameter("UsuarioID", usuarioID) :
                new ObjectParameter("UsuarioID", typeof(int));
    
            var tipoDocumentoParameter = tipoDocumento.HasValue ?
                new ObjectParameter("TipoDocumento", tipoDocumento) :
                new ObjectParameter("TipoDocumento", typeof(int));
    
            var documentoParameter = documento != null ?
                new ObjectParameter("Documento", documento) :
                new ObjectParameter("Documento", typeof(string));
    
            var aliasParameter = alias != null ?
                new ObjectParameter("Alias", alias) :
                new ObjectParameter("Alias", typeof(string));
    
            var correoParameter = correo != null ?
                new ObjectParameter("Correo", correo) :
                new ObjectParameter("Correo", typeof(string));
    
            var bancoIDParameter = bancoID.HasValue ?
                new ObjectParameter("BancoID", bancoID) :
                new ObjectParameter("BancoID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsertarBeneficiario", usuarioIDParameter, tipoDocumentoParameter, documentoParameter, aliasParameter, correoParameter, bancoIDParameter);
        }
    
        public virtual int spInsertarEstado(string descripcion)
        {
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsertarEstado", descripcionParameter);
        }
    
        public virtual int spInsertarMonedaTransaccion(string descripcion)
        {
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsertarMonedaTransaccion", descripcionParameter);
        }
    
        public virtual int spInsertarTipoTransaccion(string descripcion)
        {
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsertarTipoTransaccion", descripcionParameter);
        }
    
        public virtual int spInsertarTransaccion(Nullable<int> tipoTransaccionID, Nullable<int> monedaID, string concepto, string correoCliente, string correoBeneficiario, Nullable<int> estadoID, Nullable<decimal> monto, string cuentaOrigen, string cuentaDestino)
        {
            var tipoTransaccionIDParameter = tipoTransaccionID.HasValue ?
                new ObjectParameter("TipoTransaccionID", tipoTransaccionID) :
                new ObjectParameter("TipoTransaccionID", typeof(int));
    
            var monedaIDParameter = monedaID.HasValue ?
                new ObjectParameter("MonedaID", monedaID) :
                new ObjectParameter("MonedaID", typeof(int));
    
            var conceptoParameter = concepto != null ?
                new ObjectParameter("Concepto", concepto) :
                new ObjectParameter("Concepto", typeof(string));
    
            var correoClienteParameter = correoCliente != null ?
                new ObjectParameter("CorreoCliente", correoCliente) :
                new ObjectParameter("CorreoCliente", typeof(string));
    
            var correoBeneficiarioParameter = correoBeneficiario != null ?
                new ObjectParameter("CorreoBeneficiario", correoBeneficiario) :
                new ObjectParameter("CorreoBeneficiario", typeof(string));
    
            var estadoIDParameter = estadoID.HasValue ?
                new ObjectParameter("EstadoID", estadoID) :
                new ObjectParameter("EstadoID", typeof(int));
    
            var montoParameter = monto.HasValue ?
                new ObjectParameter("Monto", monto) :
                new ObjectParameter("Monto", typeof(decimal));
    
            var cuentaOrigenParameter = cuentaOrigen != null ?
                new ObjectParameter("CuentaOrigen", cuentaOrigen) :
                new ObjectParameter("CuentaOrigen", typeof(string));
    
            var cuentaDestinoParameter = cuentaDestino != null ?
                new ObjectParameter("CuentaDestino", cuentaDestino) :
                new ObjectParameter("CuentaDestino", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsertarTransaccion", tipoTransaccionIDParameter, monedaIDParameter, conceptoParameter, correoClienteParameter, correoBeneficiarioParameter, estadoIDParameter, montoParameter, cuentaOrigenParameter, cuentaDestinoParameter);
        }
    
        public virtual int spInsertarUsuario(string nombreUsuario, string documento, Nullable<int> tipoDocumento, string nombres, string apellidos, string correo, string telefono, string clave, Nullable<int> estadoID)
        {
            var nombreUsuarioParameter = nombreUsuario != null ?
                new ObjectParameter("NombreUsuario", nombreUsuario) :
                new ObjectParameter("NombreUsuario", typeof(string));
    
            var documentoParameter = documento != null ?
                new ObjectParameter("Documento", documento) :
                new ObjectParameter("Documento", typeof(string));
    
            var tipoDocumentoParameter = tipoDocumento.HasValue ?
                new ObjectParameter("TipoDocumento", tipoDocumento) :
                new ObjectParameter("TipoDocumento", typeof(int));
    
            var nombresParameter = nombres != null ?
                new ObjectParameter("Nombres", nombres) :
                new ObjectParameter("Nombres", typeof(string));
    
            var apellidosParameter = apellidos != null ?
                new ObjectParameter("Apellidos", apellidos) :
                new ObjectParameter("Apellidos", typeof(string));
    
            var correoParameter = correo != null ?
                new ObjectParameter("Correo", correo) :
                new ObjectParameter("Correo", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            var claveParameter = clave != null ?
                new ObjectParameter("Clave", clave) :
                new ObjectParameter("Clave", typeof(string));
    
            var estadoIDParameter = estadoID.HasValue ?
                new ObjectParameter("EstadoID", estadoID) :
                new ObjectParameter("EstadoID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsertarUsuario", nombreUsuarioParameter, documentoParameter, tipoDocumentoParameter, nombresParameter, apellidosParameter, correoParameter, telefonoParameter, claveParameter, estadoIDParameter);
        }
    
        public virtual int spInsertCuentaBeneficiario(string noCuenta, Nullable<int> beneficiarioID)
        {
            var noCuentaParameter = noCuenta != null ?
                new ObjectParameter("NoCuenta", noCuenta) :
                new ObjectParameter("NoCuenta", typeof(string));
    
            var beneficiarioIDParameter = beneficiarioID.HasValue ?
                new ObjectParameter("BeneficiarioID", beneficiarioID) :
                new ObjectParameter("BeneficiarioID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsertCuentaBeneficiario", noCuentaParameter, beneficiarioIDParameter);
        }
    }
}
