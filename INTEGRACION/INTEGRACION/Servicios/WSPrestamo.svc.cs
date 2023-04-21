﻿using INTEGRACION.Operaciones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace INTEGRACION.Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "IWSPrestamo" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select IWSPrestamo.svc or IWSPrestamo.svc.cs at the Solution Explorer and start debugging.
    public class WSPrestamo : IWSPrestamo
    {
        OperacionesPrestamo Operaciones = new OperacionesPrestamo();
        public bool CrearPrestamo(int idCuenta, decimal tasa, decimal montoOriginal, decimal montoActual, DateTime fechaCorte)
        {
            return Operaciones.InsertPrestamo(idCuenta, tasa, montoOriginal, montoActual, fechaCorte);
        }

        public bool EliminarPrestamo(int id)
        {
            return Operaciones.DeletePrestamo(id);
        }
        public bool ActualizarPrestamo(int idPrestamo, int idCuenta, decimal tasa, decimal montoOriginal, decimal montoActual, DateTime fechaCorte)
        {
            return Operaciones.UpdatePrestamos(idPrestamo, idCuenta, tasa, montoOriginal, montoActual, fechaCorte);
        }

        public DataTable MostrarPrestamos()
        {
            return Operaciones.GetPrestamos();
        }

        public DataTable BuscarPrestamo(int id)
        {
            return Operaciones.GetPrestamobyCuenta(id);
        }

        public DataTable MostarPrestamoCliente()
        {
            return Operaciones.GetAllPrestamobyCliente();
        }

    }
}
