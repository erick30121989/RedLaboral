using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace WCF_RedLaboral
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioCarrera" in both code and config file together.
    [ServiceContract]
    public interface IServicioCarrera
    {

        [OperationContract]
        DataSet ListarCarreras();

        [OperationContract]
        DataSet ListarRubros();

        [OperationContract]
        DataSet ListarCarreras2();

        [OperationContract]
        Int32 BuscarIdCarrera(String nombre_carrera);

    }
}
