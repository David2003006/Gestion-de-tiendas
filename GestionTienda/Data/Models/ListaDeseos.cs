using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace GestionTienda.Data.Models 
{
    public class ListaDeseos 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdLista {get; set;}

        public int IdUsuario {get; set;}

        public int IdArticulo {get; set;}

        [JsonIgnore]
        public virtual Usuarios Usuario {get; set;}
        
        [JsonIgnore]
        public virtual Articulo articulo {get; set;}
    }
}