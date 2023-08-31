
var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddScoped<>();
builder.Services.AddControllers();
var app = builder.Build();

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

public partial class Program { };

