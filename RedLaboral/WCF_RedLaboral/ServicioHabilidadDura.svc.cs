using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_RedLaboral
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioHabilidadDura" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServicioHabilidadDura.svc or ServicioHabilidadDura.svc.cs at the Solution Explorer and start debugging.
    public class ServicioHabilidadDura : IServicioHabilidadDura
    {
        public void DoWork()
        {
        }

        public bool InsertarPuntuacionDura(PuntuacionDuraBE objPuntBlanda)
        {
            throw new NotImplementedException();
        }

        public DataSet ListarPersonasPuntosHDura(int puntos, int id_habilidad)
        {
            throw new NotImplementedException();
        }

        public DataSet ListarPuntuacionDuraPersona(int id_trabajo)
        {
            throw new NotImplementedException();
        }

        public DataSet ListarPuntuacionDuraPersonaDetalles(string dni, int id_habilidad)
        {
            throw new NotImplementedException();
        }
    }
}
