﻿using System;
using System.Collections.Generic;

namespace GestionTienda.Models;

public partial class Carritocompra
{
    public int IdCarrito { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdArticulo { get; set; }

    public virtual ICollection<Compra> Compras { get; set; } = new List<Compra>();

    public virtual Articulo? IdArticuloNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
