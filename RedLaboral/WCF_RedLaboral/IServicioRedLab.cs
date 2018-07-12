using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WCF_RedLaboral
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioRedLab" en el código y en el archivo de configuración a la vez.


    [ServiceContract]
    public interface IServicioRedLab
    {
        [OperationContract]
        DataSet ListaRedLab(Int64 vPuesto, Int64 vContrato);

        [OperationContract]
        DataSet ListaPuesto();

        [OperationContract]
        DataSet ListaContrato();

        [OperationContract]
        String prueba();
    }

    [DataContract]
    [Serializable]

    public class RedLab
    {
        [DataMember]
        public int idOferta { get; set; }
        [DataMember]
        public string ruc { get; set; }
        [DataMember]
        public string titulo { get; set; }
        [DataMember]
        public string lugar { get; set; }
        [DataMember]
        public int idPuesto { get; set; }
        [DataMember]
        public string descrip { get; set; }
        [DataMember]
        public string funciones { get; set; }
        [DataMember]
        public int idJornada { get; set; }
        [DataMember]
        public int idTipoContrato { get; set; }
        [DataMember]
        public string requisitos { get; set; }
        [DataMember]
        public string competencias { get; set; }
        [DataMember]
        public string estado { get; set; }
    }


   
}
