using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace WCF_RedLaboral
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioPuntuacionDura" in both code and config file together.
    [ServiceContract]
    public interface IServicioPuntuacionDura
    {
        [OperationContract]
        Boolean InsertarPuntuacionDura(PuntuacionDuraBE objPuntBlanda);

        [OperationContract]
        DataSet ListarPersonasPuntosHDura(int puntos, int id_habilidad);

        [OperationContract]
        DataSet ListarPuntuacionDuraPersona(int id_trabajo);

        [OperationContract]
        DataSet ListarPuntuacionDuraPersonaDetalles(String dni, int id_habilidad);
    }

    [DataContract]
    [Serializable]
    public class PuntuacionDuraBE
    {
        private Int32 _id_Trabajo;
        private Int32 _id_H_Dura;
        private Int32 _puntos;
        private String _estado;


        [DataMember]
        public Int32 Id_Trabajo
        {
            get { return this._id_Trabajo; }
            set { this._id_Trabajo = value; }
        }

        [DataMember]
        public Int32 Id_H_Dura
        {
            get { return this._id_H_Dura; }
            set { this._id_H_Dura = value; }
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
