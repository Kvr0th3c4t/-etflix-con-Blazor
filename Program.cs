using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using Ñetflix;
using Ñetflix.Interfaces;
using Ñetflix.Services;
using Refit;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var baseURl = builder.Configuration["BaseAPI"] ?? "https://peticiones.online/api/";

builder.Services.AddMudServices();

builder.Services.AddRefitClient<ISerie>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri(baseURl));

builder.Services.AddScoped<ISeriesService, SeriesService>();

await builder.Build().RunAsync();
