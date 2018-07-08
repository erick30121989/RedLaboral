using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_RedLaboral
{
    [ServiceContract]
    public interface IOfertaLaboralService
    {
        [OperationContract]
        void DoWork();
    }
}
