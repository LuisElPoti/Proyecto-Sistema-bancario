﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CORE.Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IWSPerfil
    {

        [OperationContract]
        void AgregarPerfil(string Nombre, string Descripcion);

        [OperationContract]
        void EliminarPerfil(int id);

        [OperationContract]
        void ActualizarPerfil(int id, string Nombre, string Descripcion);

        [OperationContract]
        DataTable MostrarPerfil();

    }

    [DataContract]
    public class Perfil
    {
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
    }
}