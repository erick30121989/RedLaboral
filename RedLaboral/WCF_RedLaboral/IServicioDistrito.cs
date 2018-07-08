using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace WCF_RedLaboral
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioDistrito" in both code and config file together.
    [ServiceContract]
    public interface IServicioDistrito
    {
        [OperationContract]
        DataSet ListarDepartamento();

        [OperationContract]
        DataSet ListarProvincia(String departamento);

        [OperationContract]
        DataSet ListarDistrito(String provincia);

        [OperationContract]
        String ObtenerDepartamento(Int32 IdDistrito);

        [OperationContract]
        String ObtenerProvincia(Int32 IdDistrito);
    }
}
