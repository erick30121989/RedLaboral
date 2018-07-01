using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace WCF_RedLaboral
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioHabilidadBlanda" in both code and config file together.
    [ServiceContract]
    public interface IServicioHabilidadBlanda
    {
        [OperationContract]
        DataSet ListarHabilidadBlanda();

        [OperationContract]
        DataSet ListarRubroHabilidadBlanda();

        [OperationContract]
        DataSet ListarHabilidadBlandaxRubro(String nombre_rubro);
    }
}
