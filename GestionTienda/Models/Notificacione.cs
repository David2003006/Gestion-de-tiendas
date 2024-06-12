using System;
using System.Collections.Generic;

namespace GestionTienda.Models;

public partial class Notificacione
{
    public int IdNotificacion { get; set; }

    public int? IdArticulo { get; set; }

    public int? IdUsuario { get; set; }

    public virtual Articulo? IdArticuloNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
