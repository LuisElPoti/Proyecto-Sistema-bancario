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

namespace CORE_INTERFACES.wsReferencePrestamo {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="wsReferencePrestamo.IWSPrestamo")]
    public interface IWSPrestamo {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSPrestamo/CrearPrestamo", ReplyAction="http://tempuri.org/IWSPrestamo/CrearPrestamoResponse")]
        bool CrearPrestamo(int idCuenta, decimal tasa, decimal montoOriginal, decimal montoActual, System.DateTime fechaCorte);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSPrestamo/CrearPrestamo", ReplyAction="http://tempuri.org/IWSPrestamo/CrearPrestamoResponse")]
        System.Threading.Tasks.Task<bool> CrearPrestamoAsync(int idCuenta, decimal tasa, decimal montoOriginal, decimal montoActual, System.DateTime fechaCorte);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSPrestamo/EliminarPrestamo", ReplyAction="http://tempuri.org/IWSPrestamo/EliminarPrestamoResponse")]
        bool EliminarPrestamo(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSPrestamo/EliminarPrestamo", ReplyAction="http://tempuri.org/IWSPrestamo/EliminarPrestamoResponse")]
        System.Threading.Tasks.Task<bool> EliminarPrestamoAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSPrestamo/ActualizarPrestamo", ReplyAction="http://tempuri.org/IWSPrestamo/ActualizarPrestamoResponse")]
        bool ActualizarPrestamo(int idPrestamo, int idCuenta, decimal tasa, decimal montoOriginal, decimal montoActual, System.DateTime fechaCorte);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSPrestamo/ActualizarPrestamo", ReplyAction="http://tempuri.org/IWSPrestamo/ActualizarPrestamoResponse")]
        System.Threading.Tasks.Task<bool> ActualizarPrestamoAsync(int idPrestamo, int idCuenta, decimal tasa, decimal montoOriginal, decimal montoActual, System.DateTime fechaCorte);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSPrestamo/MostrarPrestamos", ReplyAction="http://tempuri.org/IWSPrestamo/MostrarPrestamosResponse")]
        System.Collections.Generic.List<Prestamo> MostrarPrestamos(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSPrestamo/MostrarPrestamos", ReplyAction="http://tempuri.org/IWSPrestamo/MostrarPrestamosResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Prestamo>> MostrarPrestamosAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWSPrestamoChannel : CORE_INTERFACES.wsReferencePrestamo.IWSPrestamo, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSPrestamoClient : System.ServiceModel.ClientBase<CORE_INTERFACES.wsReferencePrestamo.IWSPrestamo>, CORE_INTERFACES.wsReferencePrestamo.IWSPrestamo {
        
        public WSPrestamoClient() {
        }
        
        public WSPrestamoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSPrestamoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSPrestamoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSPrestamoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool CrearPrestamo(int idCuenta, decimal tasa, decimal montoOriginal, decimal montoActual, System.DateTime fechaCorte) {
            return base.Channel.CrearPrestamo(idCuenta, tasa, montoOriginal, montoActual, fechaCorte);
        }
        
        public System.Threading.Tasks.Task<bool> CrearPrestamoAsync(int idCuenta, decimal tasa, decimal montoOriginal, decimal montoActual, System.DateTime fechaCorte) {
            return base.Channel.CrearPrestamoAsync(idCuenta, tasa, montoOriginal, montoActual, fechaCorte);
        }
        
        public bool EliminarPrestamo(int id) {
            return base.Channel.EliminarPrestamo(id);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarPrestamoAsync(int id) {
            return base.Channel.EliminarPrestamoAsync(id);
        }
        
        public bool ActualizarPrestamo(int idPrestamo, int idCuenta, decimal tasa, decimal montoOriginal, decimal montoActual, System.DateTime fechaCorte) {
            return base.Channel.ActualizarPrestamo(idPrestamo, idCuenta, tasa, montoOriginal, montoActual, fechaCorte);
        }
        
        public System.Threading.Tasks.Task<bool> ActualizarPrestamoAsync(int idPrestamo, int idCuenta, decimal tasa, decimal montoOriginal, decimal montoActual, System.DateTime fechaCorte) {
            return base.Channel.ActualizarPrestamoAsync(idPrestamo, idCuenta, tasa, montoOriginal, montoActual, fechaCorte);
        }
        
        public System.Collections.Generic.List<Prestamo> MostrarPrestamos(int id) {
            return base.Channel.MostrarPrestamos(id);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Prestamo>> MostrarPrestamosAsync(int id) {
            return base.Channel.MostrarPrestamosAsync(id);
        }
    }
}
