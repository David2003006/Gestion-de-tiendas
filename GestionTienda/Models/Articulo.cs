using System;
using System.Collections.Generic;

namespace GestionTienda.Models;

public partial class Articulo
{
    public int IdArticulo { get; set; }

    public string? Nombre { get; set; }

    public int? Cantidad { get; set; }

    public double? Precio { get; set; }

    public string? Imagen { get; set; }

    public virtual ICollection<Carritocompra> Carritocompras { get; set; } = new List<Carritocompra>();

    public virtual ICollection<Listadedeseo> Listadedeseos { get; set; } = new List<Listadedeseo>();

    public virtual ICollection<Notificacione> Notificaciones { get; set; } = new List<Notificacione>();
}
