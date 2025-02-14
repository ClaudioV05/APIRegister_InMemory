using Crud.Presentation.Api.Extensions.ApplicationBuilder;
using Crud.Presentation.Api.Extensions.ServiceCollection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

builder.Services.ConfigureMvc();

builder.Services.ConfigureCors();

builder.Services.ConfigureSwagger();

builder.Services.ConfigureDependencies();

builder.Services.ConfigureDatabaseDependencies(builder.Configuration);

builder.Services.ConfigureDependencies(nameof(Crud));

var app = builder.Build();

// Configure the HTTP request pipeline.

if (app.Environment.IsDevelopment())
{
    // Code for Development here.
    app.UseDeveloperExceptionPage();

   app.ConfigureSwagger();
}
else if (app.Environment.IsStaging())
{
    // Code for Homologation here.
}
else if (app.Environment.IsProduction())
{
    // Code for Production here.

    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();