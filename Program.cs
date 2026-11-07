using CoreWCF.Configuration;
using CoreWCF;
using CoreWCF.Description;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddServiceModelServices();
builder.Services.AddServiceModelMetadata();

var app = builder.Build();

// Enganchando CoreWCF a ASP.NET Core, y agregamos la clase con la logica
app.UseServiceModel(ServiceBuilder => {
    ServiceBuilder.AddService<CalculadoraService>();
    ServiceBuilder.AddServiceEndpoint<CalculadoraService, ICalculadoraService>(new BasicHttpBinding(), "/CalculadoraService.svc");

    // Activar la publicacion del WSDL
    var serviceMetadataBehavior = app.Services.GetRequiredService<ServiceMetadataBehavior>();
    serviceMetadataBehavior.HttpGetEnabled = true;
});

app.Run();