using System;
using System.Collections.Generic;

namespace GestionTienda.Models;

public partial class Metododepago
{
    public int IdMetodoDePago { get; set; }

    public string? Metodo { get; set; }

    public virtual ICollection<Compra> Compras { get; set; } = new List<Compra>();
}
