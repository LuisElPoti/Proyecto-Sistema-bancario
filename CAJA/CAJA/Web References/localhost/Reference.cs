﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace CAJA.localhost {
    using System.Diagnostics;
    using System;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System.Web.Services;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_IWSCliente", Namespace="http://tempuri.org/")]
    public partial class WSCliente : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback CrearClienteOperationCompleted;
        
        private System.Threading.SendOrPostCallback ActualizarClienteOperationCompleted;
        
        private System.Threading.SendOrPostCallback EliminarClienteOperationCompleted;
        
        private System.Threading.SendOrPostCallback MostrarClientesOperationCompleted;
        
        private System.Threading.SendOrPostCallback BuscarClienteOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WSCliente() {
            this.Url = global::CAJA.Properties.Settings.Default.CAJA_localhost_WSCliente;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event CrearClienteCompletedEventHandler CrearClienteCompleted;
        
        /// <remarks/>
        public event ActualizarClienteCompletedEventHandler ActualizarClienteCompleted;
        
        /// <remarks/>
        public event EliminarClienteCompletedEventHandler EliminarClienteCompleted;
        
        /// <remarks/>
        public event MostrarClientesCompletedEventHandler MostrarClientesCompleted;
        
        /// <remarks/>
        public event BuscarClienteCompletedEventHandler BuscarClienteCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IWSCliente/CrearCliente", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void CrearCliente([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string nombre, int tipoDocumento, [System.Xml.Serialization.XmlIgnoreAttribute()] bool tipoDocumentoSpecified, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string documento, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string correo, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string telefono, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string direccion, System.DateTime fechaNacimiento, [System.Xml.Serialization.XmlIgnoreAttribute()] bool fechaNacimientoSpecified, out bool CrearClienteResult, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool CrearClienteResultSpecified) {
            object[] results = this.Invoke("CrearCliente", new object[] {
                        nombre,
                        tipoDocumento,
                        tipoDocumentoSpecified,
                        documento,
                        correo,
                        telefono,
                        direccion,
                        fechaNacimiento,
                        fechaNacimientoSpecified});
            CrearClienteResult = ((bool)(results[0]));
            CrearClienteResultSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void CrearClienteAsync(string nombre, int tipoDocumento, bool tipoDocumentoSpecified, string documento, string correo, string telefono, string direccion, System.DateTime fechaNacimiento, bool fechaNacimientoSpecified) {
            this.CrearClienteAsync(nombre, tipoDocumento, tipoDocumentoSpecified, documento, correo, telefono, direccion, fechaNacimiento, fechaNacimientoSpecified, null);
        }
        
        /// <remarks/>
        public void CrearClienteAsync(string nombre, int tipoDocumento, bool tipoDocumentoSpecified, string documento, string correo, string telefono, string direccion, System.DateTime fechaNacimiento, bool fechaNacimientoSpecified, object userState) {
            if ((this.CrearClienteOperationCompleted == null)) {
                this.CrearClienteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCrearClienteOperationCompleted);
            }
            this.InvokeAsync("CrearCliente", new object[] {
                        nombre,
                        tipoDocumento,
                        tipoDocumentoSpecified,
                        documento,
                        correo,
                        telefono,
                        direccion,
                        fechaNacimiento,
                        fechaNacimientoSpecified}, this.CrearClienteOperationCompleted, userState);
        }
        
        private void OnCrearClienteOperationCompleted(object arg) {
            if ((this.CrearClienteCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CrearClienteCompleted(this, new CrearClienteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IWSCliente/ActualizarCliente", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void ActualizarCliente(int id, [System.Xml.Serialization.XmlIgnoreAttribute()] bool idSpecified, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string nombre, int tipoDocumento, [System.Xml.Serialization.XmlIgnoreAttribute()] bool tipoDocumentoSpecified, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string documento, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string correo, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string telefono, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string direccion, System.DateTime fechaNacimiento, [System.Xml.Serialization.XmlIgnoreAttribute()] bool fechaNacimientoSpecified, out bool ActualizarClienteResult, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool ActualizarClienteResultSpecified) {
            object[] results = this.Invoke("ActualizarCliente", new object[] {
                        id,
                        idSpecified,
                        nombre,
                        tipoDocumento,
                        tipoDocumentoSpecified,
                        documento,
                        correo,
                        telefono,
                        direccion,
                        fechaNacimiento,
                        fechaNacimientoSpecified});
            ActualizarClienteResult = ((bool)(results[0]));
            ActualizarClienteResultSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void ActualizarClienteAsync(int id, bool idSpecified, string nombre, int tipoDocumento, bool tipoDocumentoSpecified, string documento, string correo, string telefono, string direccion, System.DateTime fechaNacimiento, bool fechaNacimientoSpecified) {
            this.ActualizarClienteAsync(id, idSpecified, nombre, tipoDocumento, tipoDocumentoSpecified, documento, correo, telefono, direccion, fechaNacimiento, fechaNacimientoSpecified, null);
        }
        
        /// <remarks/>
        public void ActualizarClienteAsync(int id, bool idSpecified, string nombre, int tipoDocumento, bool tipoDocumentoSpecified, string documento, string correo, string telefono, string direccion, System.DateTime fechaNacimiento, bool fechaNacimientoSpecified, object userState) {
            if ((this.ActualizarClienteOperationCompleted == null)) {
                this.ActualizarClienteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnActualizarClienteOperationCompleted);
            }
            this.InvokeAsync("ActualizarCliente", new object[] {
                        id,
                        idSpecified,
                        nombre,
                        tipoDocumento,
                        tipoDocumentoSpecified,
                        documento,
                        correo,
                        telefono,
                        direccion,
                        fechaNacimiento,
                        fechaNacimientoSpecified}, this.ActualizarClienteOperationCompleted, userState);
        }
        
        private void OnActualizarClienteOperationCompleted(object arg) {
            if ((this.ActualizarClienteCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ActualizarClienteCompleted(this, new ActualizarClienteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IWSCliente/EliminarCliente", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void EliminarCliente(int id, [System.Xml.Serialization.XmlIgnoreAttribute()] bool idSpecified, out bool EliminarClienteResult, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool EliminarClienteResultSpecified) {
            object[] results = this.Invoke("EliminarCliente", new object[] {
                        id,
                        idSpecified});
            EliminarClienteResult = ((bool)(results[0]));
            EliminarClienteResultSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void EliminarClienteAsync(int id, bool idSpecified) {
            this.EliminarClienteAsync(id, idSpecified, null);
        }
        
        /// <remarks/>
        public void EliminarClienteAsync(int id, bool idSpecified, object userState) {
            if ((this.EliminarClienteOperationCompleted == null)) {
                this.EliminarClienteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnEliminarClienteOperationCompleted);
            }
            this.InvokeAsync("EliminarCliente", new object[] {
                        id,
                        idSpecified}, this.EliminarClienteOperationCompleted, userState);
        }
        
        private void OnEliminarClienteOperationCompleted(object arg) {
            if ((this.EliminarClienteCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.EliminarClienteCompleted(this, new EliminarClienteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IWSCliente/MostrarClientes", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Data.DataTable MostrarClientes() {
            object[] results = this.Invoke("MostrarClientes", new object[0]);
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void MostrarClientesAsync() {
            this.MostrarClientesAsync(null);
        }
        
        /// <remarks/>
        public void MostrarClientesAsync(object userState) {
            if ((this.MostrarClientesOperationCompleted == null)) {
                this.MostrarClientesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnMostrarClientesOperationCompleted);
            }
            this.InvokeAsync("MostrarClientes", new object[0], this.MostrarClientesOperationCompleted, userState);
        }
        
        private void OnMostrarClientesOperationCompleted(object arg) {
            if ((this.MostrarClientesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.MostrarClientesCompleted(this, new MostrarClientesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IWSCliente/BuscarCliente", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Data.DataTable BuscarCliente(int id, [System.Xml.Serialization.XmlIgnoreAttribute()] bool idSpecified) {
            object[] results = this.Invoke("BuscarCliente", new object[] {
                        id,
                        idSpecified});
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void BuscarClienteAsync(int id, bool idSpecified) {
            this.BuscarClienteAsync(id, idSpecified, null);
        }
        
        /// <remarks/>
        public void BuscarClienteAsync(int id, bool idSpecified, object userState) {
            if ((this.BuscarClienteOperationCompleted == null)) {
                this.BuscarClienteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnBuscarClienteOperationCompleted);
            }
            this.InvokeAsync("BuscarCliente", new object[] {
                        id,
                        idSpecified}, this.BuscarClienteOperationCompleted, userState);
        }
        
        private void OnBuscarClienteOperationCompleted(object arg) {
            if ((this.BuscarClienteCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.BuscarClienteCompleted(this, new BuscarClienteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void CrearClienteCompletedEventHandler(object sender, CrearClienteCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CrearClienteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CrearClienteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool CrearClienteResult {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool CrearClienteResultSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void ActualizarClienteCompletedEventHandler(object sender, ActualizarClienteCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ActualizarClienteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ActualizarClienteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool ActualizarClienteResult {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool ActualizarClienteResultSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void EliminarClienteCompletedEventHandler(object sender, EliminarClienteCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class EliminarClienteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal EliminarClienteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool EliminarClienteResult {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool EliminarClienteResultSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void MostrarClientesCompletedEventHandler(object sender, MostrarClientesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class MostrarClientesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal MostrarClientesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void BuscarClienteCompletedEventHandler(object sender, BuscarClienteCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BuscarClienteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal BuscarClienteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591