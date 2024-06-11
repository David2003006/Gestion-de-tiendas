using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace GestionTienda.Data.Models 
{
    public class Articulo
    {   
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public  int IdArticulo {get; set; }

        public string Nombre {get; set; }

        public int Cantidad  {get; set;}

        public double Precio {get; set;}

        public string imagen {get; set;} = null;

        [JsonIgnore]
        public virtual ICollection<ListaDeseos> lista {get; set;}

        [JsonIgnore]
        public virtual ICollection<CarritoCompra> Compra {get; set;}

        [JsonIgnore]
        public virtual ICollection<Notificaciones> notificaciones {get; set;}
    }
}