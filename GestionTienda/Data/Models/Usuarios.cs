using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GestionTienda.Data.Models
{
    public class Usuarios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUsuario { get; set; }

        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        public string Correo { get; set; }

        [JsonIgnore]
        public virtual ICollection<ListaDeseos> Lista { get; set; }

        [JsonIgnore]
        public virtual ICollection<CarritoCompra> Compra { get; set; }

        [JsonIgnore]
        public virtual ICollection<Notificaciones> Notificaciones { get; set; }

        public Usuarios()
        {
            Lista = new List<ListaDeseos>();
            Compra = new List<CarritoCompra>();
            Notificaciones = new List<Notificaciones>();
        }
    }
}