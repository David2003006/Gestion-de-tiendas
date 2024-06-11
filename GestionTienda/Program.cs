using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using GestionTienda;


var builder = WebAssemblyHostBuilder.CreateDefault(args);

string conectionString= builder.Configuration.GetConnectionString("DefaultConnection");

if(!string.IsNullOrEmpty(conectionString)){
    builder.Services.AddDbContext<EventosContext>(options =>{
        options.UseMySql(
            conectionString,
            new MySqlServerVersion(new Version (8,0,19))
        );
    });
}
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
