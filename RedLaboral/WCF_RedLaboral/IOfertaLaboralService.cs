using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCF_RedLaboral.Dominio;

namespace WCF_RedLaboral
{
    [ServiceContract]
    public interface IOfertaLaboralService
    {
        [OperationContract]
        OfertaLaboral CrearOfertaLaboral(OfertaLaboral ofertaLaboralACrear);
    }
}
