using BattleGameAPI.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<BattleGameDbContext>(options =>
    options.UseSqlite("Data Source=battlegame.db"));

var app = builder.Build();
app.UseRouting();
app.UseAuthorization();
app.MapControllers(); // Ánh xạ tất cả API Controllers

app.Run();