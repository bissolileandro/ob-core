using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using ob.core.api.Service;
using ob.core.application.Configurations;
using ob.core.data.Context;
using ob.core.ioc;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authentication.JwtBearer;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement()
    {
    {
        new OpenApiSecurityScheme
        {
        Reference = new OpenApiReference
            {
            Type = ReferenceType.SecurityScheme,
            Id = "Bearer"
            },
            Scheme = "oauth2",
            Name = "Bearer",
            In = ParameterLocation.Header,

        },
        new List<string>()
        }
    });
});

builder.Services.AddAutoMapper(typeof(MappingProfile));

var connectionString = builder.Configuration.GetConnectionString("OBContext");
builder.Services.AddEntityFrameworkSqlServer()
    .AddDbContext<ObCoreContext>(options =>
    {        
        options.UseSqlServer(connectionString,sqlOptions => sqlOptions.MigrationsAssembly("ob.core.data"));
        options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
    });

builder.Services.ConfigIoC();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "PoliceFront",
        policy =>
        {
            policy.WithOrigins(
                "https://localhost",
                "http://localhost:4200",
                "https://ob-apim-dev.azure-api.net", 
                "http://ob-apim-dev.azure-api.net",
                "https://onebroker-home-dev.azurewebsites.net",
                "https://onebroker-client-dev.azurewebsites.net",
                "https://onebroker-backoffice-dev.azurewebsites.net",
                "https://onebroker-home-hml.azurewebsites.net",
                "https://onebroker-client-hml.azurewebsites.net",
                "https://onebroker-backoffice-hml.azurewebsites.net")
            .AllowAnyHeader()
            .AllowAnyMethod();
        });
});

var key = Encoding.ASCII.GetBytes(Key.Secret);

builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(x =>
{
    x.RequireHttpsMetadata = false;
    x.SaveToken = true;
    x.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = false,
        ValidateAudience = false
    };
});

var app = builder.Build();

var ambienteAtual = builder.Configuration["ASPNETCORE_ENVIRONMENT"];
string ambientesPermitidos = "Local Development";
if (app.Environment.IsDevelopment() || ambientesPermitidos.Contains(ambienteAtual))
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("PoliceFront");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
