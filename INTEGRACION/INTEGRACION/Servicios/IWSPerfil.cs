﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace INTEGRACION.Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IIWSPerfil" in both code and config file together.
    [ServiceContract]
    public interface IWSPerfil
    {
        [OperationContract]
        bool CrearPerfil(string nombre, string descripcion);

        [OperationContract]
        bool EliminarPerfil(int id);

        [OperationContract]
        bool ActualizarPerfil(int idPerfil, string nombre, string descripcion);

        [OperationContract]
        DataTable MostrarPerfiles();

        [OperationContract]
        List<Perfil> BuscarPerfil(int id);

    }
    [DataContract]
    public class ClPerfil
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string nombre { get; set; }
        [DataMember]
        public string descripcion { get; set; }
    }
}
