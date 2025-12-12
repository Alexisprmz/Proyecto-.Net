using Distribuidos.Api.Services.Pipedream;
var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddSingleton<IPipedreamService, PipedreamService>();

var app = builder.Build();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


app.Run();


