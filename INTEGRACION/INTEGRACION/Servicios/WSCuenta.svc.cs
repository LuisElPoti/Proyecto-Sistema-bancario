﻿using System;
using INTEGRACION.Operaciones;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace INTEGRACION.Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class WSCuenta : IWSCuenta
    {
        OperacionesCuenta Operaciones = new OperacionesCuenta();

        public bool CrearCuenta(int idCliente, int idTipoCuenta, int idBanco, string NumeroCuenta, bool Estado)
        {
            return Operaciones.InsertCuentas(idCliente, idTipoCuenta, idBanco, NumeroCuenta, Estado);
        }

        public bool EliminarCuenta(int id)
        {
            return Operaciones.DeleteCuentas(id);
        }
        public bool ActualizarCuenta(int idCuenta, bool Estado, decimal Balance)
        {
            return Operaciones.UpdateCuentas(idCuenta, Estado, Balance);
        }

        public DataTable MostrarCuentas()
        {
            return Operaciones.GetCuentas();
        }

        public DataTable BuscarCuenta(int id)
        {
            return Operaciones.GetCuentabyID(id);
        }

        public DataTable MostrarCuentaCliente(int idCliente)
        {
            return Operaciones.GetCuentabyCliente(idCliente);
        }

        public bool Deposito_Retiro(int tipo, string NumeroCuenta, decimal Monto)
        {
            return Operaciones.Deposito_Retiro(tipo, NumeroCuenta, Monto);
        }

        public bool Pago_Prestamo(int idPrestamo, decimal Monto)
        {
            return Operaciones.Pago(idPrestamo, Monto);
        }

        public bool Transferencia_MismoBanco(string CuentaOrigen, string CuentaDestino, decimal Monto)
        {
            return Operaciones.Transferencia_Mismo(CuentaOrigen, CuentaDestino, Monto);
        }
    }
}
