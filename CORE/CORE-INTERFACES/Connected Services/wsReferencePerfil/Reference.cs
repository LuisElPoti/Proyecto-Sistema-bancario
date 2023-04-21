﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CoreServices;
using System.Collections.Generic;

namespace CORE_INTERFACES.wsReferencePerfil {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="wsReferencePerfil.IWSPerfil")]
    public interface IWSPerfil {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSPerfil/CrearPerfil", ReplyAction="http://tempuri.org/IWSPerfil/CrearPerfilResponse")]
        bool CrearPerfil(string nombre, string descripcion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSPerfil/CrearPerfil", ReplyAction="http://tempuri.org/IWSPerfil/CrearPerfilResponse")]
        System.Threading.Tasks.Task<bool> CrearPerfilAsync(string nombre, string descripcion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSPerfil/EliminarPerfil", ReplyAction="http://tempuri.org/IWSPerfil/EliminarPerfilResponse")]
        bool EliminarPerfil(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSPerfil/EliminarPerfil", ReplyAction="http://tempuri.org/IWSPerfil/EliminarPerfilResponse")]
        System.Threading.Tasks.Task<bool> EliminarPerfilAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSPerfil/ActualizarPerfil", ReplyAction="http://tempuri.org/IWSPerfil/ActualizarPerfilResponse")]
        bool ActualizarPerfil(int idPerfil, string nombre, string descripcion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSPerfil/ActualizarPerfil", ReplyAction="http://tempuri.org/IWSPerfil/ActualizarPerfilResponse")]
        System.Threading.Tasks.Task<bool> ActualizarPerfilAsync(int idPerfil, string nombre, string descripcion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSPerfil/MostrarPerfiles", ReplyAction="http://tempuri.org/IWSPerfil/MostrarPerfilesResponse")]
        System.Data.DataTable MostrarPerfiles();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSPerfil/MostrarPerfiles", ReplyAction="http://tempuri.org/IWSPerfil/MostrarPerfilesResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> MostrarPerfilesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSPerfil/BuscarPerfil", ReplyAction="http://tempuri.org/IWSPerfil/BuscarPerfilResponse")]
        System.Collections.Generic.List<Perfil> BuscarPerfil(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSPerfil/BuscarPerfil", ReplyAction="http://tempuri.org/IWSPerfil/BuscarPerfilResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Perfil>> BuscarPerfilAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWSPerfilChannel : CORE_INTERFACES.wsReferencePerfil.IWSPerfil, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSPerfilClient : System.ServiceModel.ClientBase<CORE_INTERFACES.wsReferencePerfil.IWSPerfil>, CORE_INTERFACES.wsReferencePerfil.IWSPerfil {
        
        public WSPerfilClient() {
        }
        
        public WSPerfilClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSPerfilClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSPerfilClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSPerfilClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool CrearPerfil(string nombre, string descripcion) {
            return base.Channel.CrearPerfil(nombre, descripcion);
        }
        
        public System.Threading.Tasks.Task<bool> CrearPerfilAsync(string nombre, string descripcion) {
            return base.Channel.CrearPerfilAsync(nombre, descripcion);
        }
        
        public bool EliminarPerfil(int id) {
            return base.Channel.EliminarPerfil(id);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarPerfilAsync(int id) {
            return base.Channel.EliminarPerfilAsync(id);
        }
        
        public bool ActualizarPerfil(int idPerfil, string nombre, string descripcion) {
            return base.Channel.ActualizarPerfil(idPerfil, nombre, descripcion);
        }
        
        public System.Threading.Tasks.Task<bool> ActualizarPerfilAsync(int idPerfil, string nombre, string descripcion) {
            return base.Channel.ActualizarPerfilAsync(idPerfil, nombre, descripcion);
        }
        
        public System.Data.DataTable MostrarPerfiles() {
            return base.Channel.MostrarPerfiles();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> MostrarPerfilesAsync() {
            return base.Channel.MostrarPerfilesAsync();
        }
        
        public System.Collections.Generic.List<Perfil> BuscarPerfil(int id) {
            return base.Channel.BuscarPerfil(id);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Perfil>> BuscarPerfilAsync(int id) {
            return base.Channel.BuscarPerfilAsync(id);
        }
    }
}
