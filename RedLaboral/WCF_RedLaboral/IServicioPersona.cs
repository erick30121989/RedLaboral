using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace WCF_RedLaboral
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioPersona" in both code and config file together.
    [ServiceContract]
    public interface IServicioPersona
    {
        [OperationContract]
        Boolean InsertarPersona(PersonaBE objVendedor);

        [OperationContract]
        Boolean ActualizarPersona(PersonaBE objVendedor);

        [OperationContract]
        Boolean EliminarPersona(String strCod);

        [OperationContract]
        PersonaBE ConsultarPersona(String strCod);

        [OperationContract]
        Persona_DatosBE DatosPersona(String strCod);

        [OperationContract]
        DataSet ListarPersona();

        [OperationContract()]
        string Validacion(string correo, string contraseña);

        [OperationContract]
        Boolean ActualizarContraseña(PersonaBE objPersona);
    }

    [DataContract]
    [Serializable]
    public class PersonaBE
    {
        private String _dni;
        private String _nombres;
        private String _apellidoPaterno;
        private String _apellidoMaterno;
        private String _telefono;
        private String _celular;
        private String _email;
        private System.DateTime _fechaNacimiento;
        private String _direccion;
        private Int32 _idDistrito;
        private String _password;
        private String _estado;

        [DataMember]
        public String Dni
        {
            get { return this._dni; }
            set { this._dni = value; }
        }

        [DataMember]
        public String Nombres
        {
            get { return this._nombres; }
            set { this._nombres = value; }
        }

        [DataMember]
        public String ApellidoPaterno
        {
            get { return this._apellidoPaterno; }
            set { this._apellidoPaterno = value; }
        }

        [DataMember]
        public String ApellidoMaterno
        {
            get { return this._apellidoMaterno; }
            set { this._apellidoMaterno = value; }
        }

        [DataMember]
        public String Telefono
        {
            get { return this._telefono; }
            set { this._telefono = value; }
        }

        [DataMember]
        public String Celular
        {
            get { return this._celular; }
            set { this._celular = value; }
        }

        [DataMember]
        public String Email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        [DataMember]
        public System.DateTime FechaNacimiento
        {
            get { return this._fechaNacimiento; }
            set { this._fechaNacimiento = value; }
        }

        [DataMember]
        public String Direccion
        {
            get { return this._direccion; }
            set { this._direccion = value; }
        }

        [DataMember]
        public Int32 IdDistrito
        {
            get { return this._idDistrito; }
            set { this._idDistrito = value; }
        }

        [DataMember]
        public String Password
        {
            get { return this._password; }
            set { this._password = value; }
        }

        [DataMember]
        public String Estado
        {
            get { return this._estado; }
            set { this._estado = value; }
        }
    }

    [DataContract]
    [Serializable]
    public class Persona_DatosBE
    {
        private String _dni;

        [DataMember]
        public String Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }
        private String _nombres;

        [DataMember]
        public String Nombres
        {
            get { return _nombres; }
            set { _nombres = value; }
        }
        private String _ape_paterno;

        [DataMember]
        public String Ape_paterno
        {
            get { return _ape_paterno; }
            set { _ape_paterno = value; }
        }
        private String _ape_materno;

        [DataMember]
        public String Ape_materno
        {
            get { return _ape_materno; }
            set { _ape_materno = value; }
        }
        private String _correo;

        [DataMember]
        public String Correo
        {
            get { return _correo; }
            set { _correo = value; }
        }
        private System.DateTime _fecha;

        [DataMember]
        public System.DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }
        private String _telefono;

        [DataMember]
        public String Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        private String _celular;

        [DataMember]
        public String Celular
        {
            get { return _celular; }
            set { _celular = value; }
        }
        private String _direccion;

        [DataMember]
        public String Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
        private String _provincia;

        [DataMember]
        public String Provincia
        {
            get { return _provincia; }
            set { _provincia = value; }
        }
        private String _departamento;

        [DataMember]
        public String Departamento
        {
            get { return _departamento; }
            set { _departamento = value; }
        }

    }
}
