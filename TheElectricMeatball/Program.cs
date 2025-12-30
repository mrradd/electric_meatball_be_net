using BusinessLogic;
using Microsoft.EntityFrameworkCore;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddTransient<ChatBusinessLogic>();
builder.Services.AddTransient<ThreadBusinessLogic>();

builder.Services.AddDbContext<EmDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetValue<string>("DB_SOURCE"))
);
WebApplication app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();