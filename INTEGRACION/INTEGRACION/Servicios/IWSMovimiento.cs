﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace INTEGRACION.Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMovimiento" in both code and config file together.
    [ServiceContract]
    public interface IWSMovimiento
    {
        [OperationContract]
        DataTable MostrarMovimientoCuenta();
    }
}

