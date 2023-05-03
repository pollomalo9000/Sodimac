using System;
using System.Collections.Generic;

namespace NewShore.DataAccess;

public partial class TblSku
{
    public string SkuId { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual ICollection<TblInvCoDespachadasN> TblInvCoDespachadasNs { get; set; } = new List<TblInvCoDespachadasN>();

    public virtual ICollection<TblInvInventarioOn> TblInvInventarioOns { get; set; } = new List<TblInvInventarioOn>();

    public virtual ICollection<TblInvNpComprometidasN> TblInvNpComprometidasNs { get; set; } = new List<TblInvNpComprometidasN>();

    public virtual ICollection<TblInvUbicacionesN> TblInvUbicacionesNs { get; set; } = new List<TblInvUbicacionesN>();
}
