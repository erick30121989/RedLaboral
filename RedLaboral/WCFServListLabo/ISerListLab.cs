using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServListLabo
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ISerListLab" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ISerListLab
    {
        [OperationContract]
        void DoWork();
        [OperationContract]
        string ListLaboral(int contrato, int puesto);

    }
}
