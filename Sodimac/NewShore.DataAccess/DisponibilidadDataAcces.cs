
using NewShoreAir.Domain.Dtos;
using NewShoreAir.Domain.Enum;
using NewShoreAir.Domain.Excepciones;
using NewShoreAir.Domain.Helpers;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace NewShore.DataAccess
{
    public class DisponibilidadDataAcces : IDisponibilidadDataAcces
    {
        public int DisponibilidadNeta(string sKU)
        {
            throw new NotImplementedException();
        }

        public int TotalInventarioComprometido(string sKU)
        {
            throw new NotImplementedException();
        }

        public UnidadesPorUbicacion UnidadesPorUbicacion(string sKU)
        {
            throw new NotImplementedException();
        }
    }
}
