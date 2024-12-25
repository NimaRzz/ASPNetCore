using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Project.Domain.Entities.Users;
using Project.Infra.Data.Contexts;
using Project.Infra.IoC;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DataBaseContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("DataBaseContext"))
);

builder.Services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<DataBaseContext>();

builder.Services.AddRazorPages();

RegisterServices(builder.Services);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

app.MapRazorPages();

app.Run();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
          name:"areas",
          pattern:"{area=exists}/{controller=Home}/{action=Index}/{id?}"
    );
});

static void RegisterServices(IServiceCollection services)
{
    DependencyContainer.RegisterServices(services);
}