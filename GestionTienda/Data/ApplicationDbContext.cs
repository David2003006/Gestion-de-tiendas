using Microsoft.EntityFrameworkCore;

namespace GestionTienda.Data{

public class ApplicationDbContext: DbContext{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public  DbSet<MetodosPago> Metodos {get; set; } 

        public DbSet <Usuarios> Usuario {get; set; } 

        public  DbSet<Articulo> Articulos {get; set; }

        public DbSet <ListaDeseos> Listas {get; set; }

        public  DbSet<Notificaciones> Notificaciones {get; set; } 

        public DbSet <Compra> Compras {get; set; }

        public  DbSet<CarritoCompra> Carritos {get; set; }

     protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuarios>()
            .HasKey(u => u.IdUsuario);
            
        modelBuilder.Entity<Eventos>().HasKey(u => u.IdEvento);
        
         // Define UsuarioId como la clave primaria
    }

}

}