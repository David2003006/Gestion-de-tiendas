using System;
using System.Collections.Generic;

namespace GestionTienda.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string? Nombre { get; set; }

    public string? Apellidos { get; set; }

    public string? Correo { get; set; }

    public virtual ICollection<Carritocompra> Carritocompras { get; set; } = new List<Carritocompra>();

    public virtual ICollection<Listadedeseo> Listadedeseos { get; set; } = new List<Listadedeseo>();

    public virtual ICollection<Notificacione> Notificaciones { get; set; } = new List<Notificacione>();
}
