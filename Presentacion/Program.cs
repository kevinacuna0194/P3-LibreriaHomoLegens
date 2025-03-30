using CasosUso.InterfacesCasosUso;
using LogicaAccesoDatos.Repositorios;
using LogicaAplicacion.CasosUsoConcretos;
using LogicaNegocio.InterfacesRepositorios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IAltaTema, AltaTema>();
builder.Services.AddScoped<IListadoTemas, ListadoTemas>();
builder.Services.AddScoped<IRepositorioTemas, RepositorioTemasMemoria>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Temas}/{action=Index}/{id?}");

app.Run();
