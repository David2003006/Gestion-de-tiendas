using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;


namespace GestionTienda.Data.Models 
{
    public class MetodoPago 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdMetodo {get; set;}

        public string Metodo {get; set;}

        [JsonIgnore]
        public virtual ICollection<Compra> Compra {get; set; }= null; 

    }
}