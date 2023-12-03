using ProySuministros.Presentation.Layer;


var builder = WebApplication.CreateBuilder(args);


var configBuilder = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production"}.json", optional: true)
    .AddJsonFile("Config/appProperties.json", optional: false, reloadOnChange: true)
    .AddEnvironmentVariables()
    .Build();
builder.WebHost.UseConfiguration(configBuilder);


// Add services to the container.
builder.Services.AddSingleton(_ => builder.Configuration);
builder.Services.AddModule(builder.Configuration);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();



app.UseModule();
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

