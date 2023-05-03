using Microsoft.Extensions.Caching.Memory;
using NewShore.DataAccess;
using NewShoreAir.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShore.Bussines
{
    public class DisponibilidadBussines : IDisponibilidadBussines
    {
        public IDisponibilidadDataAcces _disponibilidadDataAcces;

        public DisponibilidadBussines(IDisponibilidadDataAcces disponibilidadDataAcces)
        {

            _disponibilidadDataAcces = disponibilidadDataAcces;
        }

        public int DisponibilidadNeta(string sKU)
        {
            return _disponibilidadDataAcces.DisponibilidadNeta(sKU);

        }

        public int TotalInventarioComprometido(string sKU)
        {
            return _disponibilidadDataAcces.TotalInventarioComprometido(sKU);
        }

        public UnidadesPorUbicacion UnidadesPorUbicacion(string sKU)
        {
            return _disponibilidadDataAcces.UnidadesPorUbicacion(sKU);
        }
    }
}

