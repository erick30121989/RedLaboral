using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCF_RedLaboral.Dominio
{
    public class RedLaboral
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