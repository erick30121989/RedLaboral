using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCF_RedLaboral.Dominio;
using WCF_RedLaboral.Errores;
using WCF_RedLaboral.Persistencia;

namespace WCF_RedLaboral
{
    public class OfertaLaboralService : IOfertaLaboralService
    {
        private OfertaLaboralDAO ofertaLaboralDAO = new OfertaLaboralDAO();

        public OfertaLaboral CrearOfertaLaboral(OfertaLaboral ofertaLaboralACrear)
        {
            if (ofertaLaboralDAO.Obtener(ofertaLaboralACrear.idOfertaLaboral) != null)
            {
                throw new FaultException<OfertaLaboralException>(
                    new OfertaLaboralException()
                    {
                        Codigo = "101",
                        Descripcion = "Oferta Laboral ya existe"
                    },
                    new FaultReason("Error al intentar creación"));
            }
            return ofertaLaboralDAO.Crear(ofertaLaboralACrear);
        }
        
        public OfertaLaboral ObtenerOfertaLaboral(int idOfertaLaboral)
        {
            return ofertaLaboralDAO.Obtener(idOfertaLaboral);
        }

        AplicacionOfertaLaboral IOfertaLaboralService.AplicarOfertaLaboral(AplicacionOfertaLaboral aplicacionOfertaLaboralACrear)
        {
            throw new NotImplementedException();
        }
    }
}
