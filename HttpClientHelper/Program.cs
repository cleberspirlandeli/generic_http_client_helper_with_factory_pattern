using Api.Test.Externo;
using Api.Test.Externo.Base;
using Api.Test.Externo.Factory;
using Api.Test.Externo.InvestimentGeneral;
using Api.Test.Service.InvestimentGeneral;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHttpClient("InvestimentGeneral", client =>
{
    client.BaseAddress = new Uri("https://viacep.com.br/ws/01001000/json/");
    client.DefaultRequestHeaders.Add("Accept", "application/json");
    // Add more configurations
});

builder.Services.AddHttpClient("UserAccount", client =>
{
    client.BaseAddress = new Uri("https://viacep.com.br/ws/14412444/json/");
    client.DefaultRequestHeaders.Add("Accept", "application/json");
    // Add more configurations
});

builder.Services.AddHttpClient("EndpointExampleTwo", client =>
{
    client.BaseAddress = new Uri("https://api.endpointexampletwo.com/");
    client.DefaultRequestHeaders.Add("Accept", "application/json");
    // Add more configurations
});

builder.Services.AddScoped<IHttpClientServiceFactory, HttpClientServiceFactory>();
builder.Services.AddScoped<IInvestimentGeneralApiService, InvestimentGeneralApiService>();
builder.Services.AddScoped<IInvestimentGeneralService, InvestimentGeneralService>();
//builder.Services.AddScoped<IHttpClientServiceTest, IInvestimentGeneralApiService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
