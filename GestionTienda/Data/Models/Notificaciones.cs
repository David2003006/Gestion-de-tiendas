using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace GestionTienda.Data.Models
{
    public class Notificaciones 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdNotificacion {get; set;}

        public int IdArticulo {get; set;}

        public int IdUsuario {get; set;}

         [JsonIgnore]

        public virtual Usuarios Usuario {get; set;}
        
         [JsonIgnore]
        public virtual Articulo articulo {get; set;} 

    }
}