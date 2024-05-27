using Microsoft.EntityFrameworkCore;

namespace GestionTienda.Data{

public class ApplicationDbContext: DbContext{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : 
    base(options) { }

    
}

}