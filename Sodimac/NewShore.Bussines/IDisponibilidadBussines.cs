using NewShoreAir.Domain.Dtos;

namespace NewShore.Bussines
{
    public interface IDisponibilidadBussines
    {
        int DisponibilidadNeta(string sKU);
        UnidadesPorUbicacion UnidadesPorUbicacion(string sKU);
        int TotalInventarioComprometido(string sKU);
    }
}