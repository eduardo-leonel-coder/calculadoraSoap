using CoreWCF.Configuration;
using CoreWCF;
using CoreWCF.Description;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddServiceModelServices();
builder.Services.AddServiceModelMetadata();

var app = builder.Build();

// Enganchando CoreWCF a ASP.NET Core, y agregamos la clase con la logica
app.UseServiceModel(ServiceBuilder => {
    ServiceBuilder.AddService<CalculadoraSoap>();
    ServiceBuilder.AddServiceEndpoint<CalculadoraSoap, ICalculadoraSoap>(new BasicHttpBinding(), "/Calculadora.svc")

    // Activar la publicacion del WSDL
    var serviceMetadataBehavior = app.Services.GetRequiredService<ServiceMetadataBehavior>();
    serviceMetadataBehavior.HttpGetEnabled = true;
})

app.Run();