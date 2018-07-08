using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace WCF_RedLaboral
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioPersonaCarrera" in both code and config file together.
    [ServiceContract]
    public interface IServicioPersonaCarrera
    {
        [OperationContract()]
        DataSet ListarCarreraporPersona(string dni);

        [OperationContract]
        DataSet ListarPersonaCarrera(int id_carrera);

        [OperationContract]
        DataSet ListarPersonarRubroCarrera(String rubro);

        [OperationContract]
        DataSet ListarPersonaPromedio(int nota);

        [OperationContract]
        PersonaCarreraDetalle ListarPersonaCarreraDetalles(string dni, int nombre_carrera);
    }

    [DataContract]
    [Serializable]
    public class PersonaCarreraDetalle
    {
        private String _dni;

        [DataMember]
        public String Dni
        {
            get { return this._dni; }
            set { this._dni = value; }
        }
        private String _datos;

        [DataMember]
        public String Datos
        {
            get { return this._datos; }
            set { this._datos = value; }
        }
        private String _email;

        [DataMember]
        public String Email
        {
            get { return this._email; }
            set { this._email = value; }
        }
        private String _telefono;

        [DataMember]
        public String Telefono
        {
            get { return this._telefono; }
            set { this._telefono = value; }
        }
        private String _celular;

        [DataMember]
        public String Celular
        {
            get { return this._celular; }
            set { this._celular = value; }
        }
        private String _direccion;

        [DataMember]
        public String Direccion
        {
            get { return this._direccion; }
            set { this._direccion = value; }
        }
        private String _distrito;

        [DataMember]
        public String Distrito
        {
            get { return this._distrito; }
            set { this._distrito = value; }
        }
        private String _provincia;

        [DataMember]
        public String Provincia
        {
            get { return this._provincia; }
            set { this._provincia = value; }
        }
        private String _departamento;

        [DataMember]
        public String Departamento
        {
            get { return this._departamento; }
            set { this._departamento = value; }
        }
        private String _carrera;

        [DataMember]
        public String Carrera
        {
            get { return this._carrera; }
            set { this._carrera = value; }
        }
        private String _institucion;

        [DataMember]
        public String Institucion
        {
            get { return this._institucion; }
            set { this._institucion = value; }
        }
        private Int32 _promedio;

        [DataMember]
        public Int32 Promedio
        {
            get { return this._promedio; }
            set { this._promedio = value; }
        }
        private Int32 _puesto_final;

        [DataMember]
        public Int32 Puesto_final
        {
            get { return this._puesto_final; }
            set { this._puesto_final = value; }
        }
        private System.DateTime _f_inicio;

        [DataMember]
        public System.DateTime F_inicio
        {
            get { return this._f_inicio; }
            set { this._f_inicio = value; }
        }
        private System.DateTime _f_fin;

        [DataMember]
        public System.DateTime F_fin
        {
            get { return this._f_fin; }
            set { this._f_fin = value; }
        }
    }
}
