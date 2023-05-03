
using NewShoreAir.Domain.Dtos;

using NewShoreAir.Domain.Excepciones;
using NewShoreAir.Domain.Helpers;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NewShore.DataAccess
{
    public class DisponibilidadDataAcces : IDisponibilidadDataAcces
    {
        public int DisponibilidadNeta(string sKU)
        {
            using (var context = new SodimacContext())
            {
                var qty = (from ubicaciones in context.TblInvUbicacionesNs
                           join despachadas in context.TblInvCoDespachadasNs on ubicaciones.Whse equals despachadas.Whse
                           join comprometidas in context.TblInvNpComprometidasNs on ubicaciones.SkuId equals comprometidas.SkuId
                           where ubicaciones.SkuId == sKU
                           select ubicaciones.OnHandQty - (despachadas.CoDesp + comprometidas.QtyPend)
                           
                           ).Sum();

                return (int)qty;

            }

            return 0;
        }
        public int TotalInventarioComprometido(string sKU)
        {
           
            using (var context = new SodimacContext())
            {
                var qty = (from ubicaciones in context.TblInvUbicacionesNs
                           join despachadas in context.TblInvCoDespachadasNs on ubicaciones.Whse equals despachadas.Whse
                           join comprometidas in context.TblInvNpComprometidasNs on ubicaciones.SkuId equals comprometidas.SkuId
                           where ubicaciones.SkuId == sKU && ubicaciones.Ubicacion == null 
                           select ubicaciones.OnHandQty + despachadas.CoDesp + comprometidas.QtyPend
                           
                           ).Sum();

                return (int)qty;

            }

            return 0;
        }

        public UnidadesPorUbicacion UnidadesPorUbicacion(string sKU)
        {
            UnidadesPorUbicacion restult = new UnidadesPorUbicacion();
            using (var context = new SodimacContext())
            {
                var qty = (from ubicaciones in context.TblInvUbicacionesNs
                           where ubicaciones.SkuId == sKU
                           select ubicaciones);

               

                restult.CantidadNoAlmacenada = (int)qty.Sum(c => c.QtyCantidadNoAlmacenada);

                restult.CantidadReserva = (int)qty.Sum(c => c.QtyReserva);


                restult.CantidadActivo = (int)qty.Sum(c => c.OnHandQty);


               
            }

            return restult;
        }
    }
}
