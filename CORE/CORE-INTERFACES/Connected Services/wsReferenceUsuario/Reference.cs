﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CORE_INTERFACES.wsReferenceUsuario {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="wsReferenceUsuario.IWSUsuario")]
    public interface IWSUsuario {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuario/AgregarUsuario", ReplyAction="http://tempuri.org/IWSUsuario/AgregarUsuarioResponse")]
        void AgregarUsuario(int idPerfil, string Nombre, string Clave);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuario/AgregarUsuario", ReplyAction="http://tempuri.org/IWSUsuario/AgregarUsuarioResponse")]
        System.Threading.Tasks.Task AgregarUsuarioAsync(int idPerfil, string Nombre, string Clave);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuario/EliminarUsuario", ReplyAction="http://tempuri.org/IWSUsuario/EliminarUsuarioResponse")]
        void EliminarUsuario(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuario/EliminarUsuario", ReplyAction="http://tempuri.org/IWSUsuario/EliminarUsuarioResponse")]
        System.Threading.Tasks.Task EliminarUsuarioAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuario/ActualizarUsuario", ReplyAction="http://tempuri.org/IWSUsuario/ActualizarUsuarioResponse")]
        void ActualizarUsuario(int id, int idPerfil, string Nombre, string Clave);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuario/ActualizarUsuario", ReplyAction="http://tempuri.org/IWSUsuario/ActualizarUsuarioResponse")]
        System.Threading.Tasks.Task ActualizarUsuarioAsync(int id, int idPerfil, string Nombre, string Clave);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuario/MostrarUsuarios", ReplyAction="http://tempuri.org/IWSUsuario/MostrarUsuariosResponse")]
        System.Data.DataTable MostrarUsuarios();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuario/MostrarUsuarios", ReplyAction="http://tempuri.org/IWSUsuario/MostrarUsuariosResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> MostrarUsuariosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuario/BuscarUsuario", ReplyAction="http://tempuri.org/IWSUsuario/BuscarUsuarioResponse")]
        System.Data.DataTable BuscarUsuario(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuario/BuscarUsuario", ReplyAction="http://tempuri.org/IWSUsuario/BuscarUsuarioResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> BuscarUsuarioAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWSUsuarioChannel : CORE_INTERFACES.wsReferenceUsuario.IWSUsuario, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSUsuarioClient : System.ServiceModel.ClientBase<CORE_INTERFACES.wsReferenceUsuario.IWSUsuario>, CORE_INTERFACES.wsReferenceUsuario.IWSUsuario {
        
        public WSUsuarioClient() {
        }
        
        public WSUsuarioClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSUsuarioClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSUsuarioClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSUsuarioClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AgregarUsuario(int idPerfil, string Nombre, string Clave) {
            base.Channel.AgregarUsuario(idPerfil, Nombre, Clave);
        }
        
        public System.Threading.Tasks.Task AgregarUsuarioAsync(int idPerfil, string Nombre, string Clave) {
            return base.Channel.AgregarUsuarioAsync(idPerfil, Nombre, Clave);
        }
        
        public void EliminarUsuario(int id) {
            base.Channel.EliminarUsuario(id);
        }
        
        public System.Threading.Tasks.Task EliminarUsuarioAsync(int id) {
            return base.Channel.EliminarUsuarioAsync(id);
        }
        
        public void ActualizarUsuario(int id, int idPerfil, string Nombre, string Clave) {
            base.Channel.ActualizarUsuario(id, idPerfil, Nombre, Clave);
        }
        
        public System.Threading.Tasks.Task ActualizarUsuarioAsync(int id, int idPerfil, string Nombre, string Clave) {
            return base.Channel.ActualizarUsuarioAsync(id, idPerfil, Nombre, Clave);
        }
        
        public System.Data.DataTable MostrarUsuarios() {
            return base.Channel.MostrarUsuarios();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> MostrarUsuariosAsync() {
            return base.Channel.MostrarUsuariosAsync();
        }
        
        public System.Data.DataTable BuscarUsuario(int id) {
            return base.Channel.BuscarUsuario(id);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> BuscarUsuarioAsync(int id) {
            return base.Channel.BuscarUsuarioAsync(id);
        }
    }
}