﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CORE_INTERFACES.wsReferencePrestamo {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="wsReferencePrestamo.IWSPrestamo")]
    public interface IWSPrestamo {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSPrestamo/CrearPrestamo", ReplyAction="http://tempuri.org/IWSPrestamo/CrearPrestamoResponse")]
        void CrearPrestamo(int idCuenta, decimal Tasa, decimal MontoOriginal, decimal MontoActual, System.DateTime FechaCorte);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSPrestamo/CrearPrestamo", ReplyAction="http://tempuri.org/IWSPrestamo/CrearPrestamoResponse")]
        System.Threading.Tasks.Task CrearPrestamoAsync(int idCuenta, decimal Tasa, decimal MontoOriginal, decimal MontoActual, System.DateTime FechaCorte);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSPrestamo/EliminarPrestamo", ReplyAction="http://tempuri.org/IWSPrestamo/EliminarPrestamoResponse")]
        void EliminarPrestamo(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSPrestamo/EliminarPrestamo", ReplyAction="http://tempuri.org/IWSPrestamo/EliminarPrestamoResponse")]
        System.Threading.Tasks.Task EliminarPrestamoAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSPrestamo/ModificarPrestamo", ReplyAction="http://tempuri.org/IWSPrestamo/ModificarPrestamoResponse")]
        void ModificarPrestamo(int id, int idCuenta, decimal Tasa, decimal MontoOriginal, decimal MontoActual, System.DateTime FechaCorte);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSPrestamo/ModificarPrestamo", ReplyAction="http://tempuri.org/IWSPrestamo/ModificarPrestamoResponse")]
        System.Threading.Tasks.Task ModificarPrestamoAsync(int id, int idCuenta, decimal Tasa, decimal MontoOriginal, decimal MontoActual, System.DateTime FechaCorte);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSPrestamo/MostrarPrestamos", ReplyAction="http://tempuri.org/IWSPrestamo/MostrarPrestamosResponse")]
        System.Data.DataTable MostrarPrestamos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSPrestamo/MostrarPrestamos", ReplyAction="http://tempuri.org/IWSPrestamo/MostrarPrestamosResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> MostrarPrestamosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSPrestamo/BuscarPrestamo", ReplyAction="http://tempuri.org/IWSPrestamo/BuscarPrestamoResponse")]
        System.Data.DataTable BuscarPrestamo(int idCuenta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSPrestamo/BuscarPrestamo", ReplyAction="http://tempuri.org/IWSPrestamo/BuscarPrestamoResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> BuscarPrestamoAsync(int idCuenta);
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
        
        public void CrearPrestamo(int idCuenta, decimal Tasa, decimal MontoOriginal, decimal MontoActual, System.DateTime FechaCorte) {
            base.Channel.CrearPrestamo(idCuenta, Tasa, MontoOriginal, MontoActual, FechaCorte);
        }
        
        public System.Threading.Tasks.Task CrearPrestamoAsync(int idCuenta, decimal Tasa, decimal MontoOriginal, decimal MontoActual, System.DateTime FechaCorte) {
            return base.Channel.CrearPrestamoAsync(idCuenta, Tasa, MontoOriginal, MontoActual, FechaCorte);
        }
        
        public void EliminarPrestamo(int id) {
            base.Channel.EliminarPrestamo(id);
        }
        
        public System.Threading.Tasks.Task EliminarPrestamoAsync(int id) {
            return base.Channel.EliminarPrestamoAsync(id);
        }
        
        public void ModificarPrestamo(int id, int idCuenta, decimal Tasa, decimal MontoOriginal, decimal MontoActual, System.DateTime FechaCorte) {
            base.Channel.ModificarPrestamo(id, idCuenta, Tasa, MontoOriginal, MontoActual, FechaCorte);
        }
        
        public System.Threading.Tasks.Task ModificarPrestamoAsync(int id, int idCuenta, decimal Tasa, decimal MontoOriginal, decimal MontoActual, System.DateTime FechaCorte) {
            return base.Channel.ModificarPrestamoAsync(id, idCuenta, Tasa, MontoOriginal, MontoActual, FechaCorte);
        }
        
        public System.Data.DataTable MostrarPrestamos() {
            return base.Channel.MostrarPrestamos();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> MostrarPrestamosAsync() {
            return base.Channel.MostrarPrestamosAsync();
        }
        
        public System.Data.DataTable BuscarPrestamo(int idCuenta) {
            return base.Channel.BuscarPrestamo(idCuenta);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> BuscarPrestamoAsync(int idCuenta) {
            return base.Channel.BuscarPrestamoAsync(idCuenta);
        }
    }
}
