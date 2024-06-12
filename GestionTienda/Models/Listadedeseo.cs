using System;
using System.Collections.Generic;

namespace GestionTienda.Models;

public partial class Listadedeseo
{
    public int IdLista { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdArticulo { get; set; }

    public virtual Articulo? IdArticuloNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
