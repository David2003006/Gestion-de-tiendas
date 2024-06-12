using System;
using System.Collections.Generic;

namespace GestionTienda.Models;

public partial class Compra
{
    public int IdCompra { get; set; }

    public int? IdCarritoCompra { get; set; }

    public int? IdMetodoPago { get; set; }

    public virtual Carritocompra? IdCarritoCompraNavigation { get; set; }

    public virtual Metododepago? IdMetodoPagoNavigation { get; set; }
}
