using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;


namespace WCF_RedLaboral
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioTrabajo" in both code and config file together.
    [ServiceContract]
    public interface IServicioTrabajo
    {
        [OperationContract]
        DataSet ListarPersonaExperiencia(int experiencia);

        [OperationContract]
        DataSet ListarPersonaExperienciarRubro(int experiencia, String rubro);

        [OperationContract]
        DataSet ListarTrabajoporPersona(string strCod);

        [OperationContract]
        Boolean InsertarTrabajo(TrabajoBE objtrabajo);
    }

    [DataContract]
    [Serializable]
    public class TrabajoBE
    {
        private String _dni;

        [DataMember]
        public String Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }
        private String _ruc;

        [DataMember]
        public String Ruc
        {
            get { return _ruc; }
            set { _ruc = value; }
        }
        private Int32 id_puesto;

        [DataMember]
        public Int32 Id_puesto
        {
            get { return id_puesto; }
            set { id_puesto = value; }
        }
        private System.DateTime _fecha_inicio;

        [DataMember]
        public System.DateTime Fecha_inicio
        {
            get { return _fecha_inicio; }
            set { _fecha_inicio = value; }
        }
        private System.DateTime _fecha_fin;

        [DataMember]
        public System.DateTime Fecha_fin
        {
            get { return _fecha_fin; }
            set { _fecha_fin = value; }
        }

    }
}
