using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCF_RedLaboral.Dominio
{
    [DataContract]
    public class AplicacionOfertaLaboral
    {
        [DataMember]
        public int idOfertaLaboral { get; set; }
        [DataMember]
        public string dni { get; set; }
    }
}