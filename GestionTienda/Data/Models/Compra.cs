using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization;

namespace GestionTienda.Data.Models
{
    public class Compra
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCompra {get; set;}

        public int IdCarritoCompra {get; set;}  

        public int IdMetodoPago {get; set;} 

        [JsonIgnore]
        public virtual CarritoCompra carrito {get; set;}=null; 
        
        [JsonIgnore]
        public virtual MetodoPago metodo {get; set;}

    }
}