using System;
using System.Collections.Generic;

namespace NewShore.DataAccess;

public partial class TblInvInventarioOn
{
    public decimal IdInvInventario { get; set; }

    public decimal? IdItem { get; set; }

    public string? SkuId { get; set; }

    public decimal? Qty { get; set; }

    public virtual TblSku? Sku { get; set; }
}
