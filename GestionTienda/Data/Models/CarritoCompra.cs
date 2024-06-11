using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace GestionTienda.Data.Models
{
    public class CarritoCompra 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCarrito {get; set; } 

        public int IdUsuario {get; set; }

        public int IdArticulo {get; set;}

        [JsonIgnore]
        public virtual ICollection<Compra> Compra {get; set;}
    }


}