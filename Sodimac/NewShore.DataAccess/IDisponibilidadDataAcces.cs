using NewShoreAir.Domain.Dtos;

namespace NewShore.DataAccess
{
    public interface IDisponibilidadDataAcces
    {
        int DisponibilidadNeta(string sKU);
        int TotalInventarioComprometido(string sKU);
        UnidadesPorUbicacion UnidadesPorUbicacion(string sKU);
    }
}