using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace WCF_RedLaboral
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioPuntuacionBlanda" in both code and config file together.
    [ServiceContract]
    public interface IServicioPuntuacionBlanda
    {
        [OperationContract]
        Boolean InsertarPuntuacionBlanda(PuntuacionBlandaBE objPuntBlanda);

        [OperationContract]
        DataSet ListarPersonasPuntosHBlanda(int puntos, int id_habilidad);

        [OperationContract]
        DataSet ListarPuntuacionBlandoPersona(int id_trabajo);

        [OperationContract]
        DataSet ListarPuntuacionBlandoPersonaDetalles(String dni, int id_habilidad);
    }

    [DataContract]
    [Serializable]
    public class PuntuacionBlandaBE
    {
        private Int32 _id_Trabajo;
        private Int32 _id_H_Blanda;
        private Int32 _puntos;
        private String _estado;


        [DataMember]
        public Int32 Id_Trabajo
        {
            get { return this._id_Trabajo; }
            set { this._id_Trabajo = value; }
        }

        [DataMember]
        public Int32 Id_H_Blanda
        {
            get { return this._id_H_Blanda; }
            set { this._id_H_Blanda = value; }
        }

        [DataMember]
        public Int32 Puntos
        {
            get { return this._puntos; }
            set { this._puntos = value; }
        }

        [DataMember]
        public String Estado
        {
            get { return this._estado; }
            set { this._estado = value; }
        }
    }
}
