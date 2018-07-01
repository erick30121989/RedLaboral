using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_RedLaboral
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioEmpresa" in both code and config file together.
    [ServiceContract]
    public interface IServicioEmpresa
    {
        [OperationContract]
        EmpresaBE ConsultarEmpresa(String strCod);

        [OperationContract]
        Boolean ActualizarEmpresa(EmpresaBE objEmpresaBE);

        [OperationContract]
        Boolean ActualizarContraseña(EmpresaBE objEmpresaBE);   
    }

    [DataContract]
    [Serializable]
    public class EmpresaBE
    {
        private String _ruc;

        [DataMember]
        public String Ruc
        {
            get { return _ruc; }
            set { _ruc = value; }
        }
        private String _razon_social;

        [DataMember]
        public String Razon_social
        {
            get { return _razon_social; }
            set { _razon_social = value; }
        }
        private String _direccion;

        [DataMember]
        public String Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
        private Int32 _id_distrito;

        [DataMember]
        public Int32 Id_distrito
        {
            get { return _id_distrito; }
            set { _id_distrito = value; }
        }
        private String _correo;

        [DataMember]
        public String Correo
        {
            get { return _correo; }
            set { _correo = value; }
        }
        private String _contraseña;

        [DataMember]
        public String Contraseña
        {
            get { return _contraseña; }
            set { _contraseña = value; }
        }
        private String _estado;

        [DataMember]
        public String Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

    }
}
