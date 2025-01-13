using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using TouchGatewayApi.Handlers;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Configurar CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

// Agregar configuración de Ocelot
builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);

// Configurar Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Touch Gateway API",
        Version = "v1",
        Description = "Gateway API para Touch Consulting",
        Contact = new OpenApiContact
        {
            Name = "Touch Consulting",
            Email = "support@touchconsulting.com"
        },
        License = new OpenApiLicense
        {
            Name = "Uso Privado",
            Url = new Uri("https://touchconsulting.com/license")
        }
    });

    // Configurar el esquema de seguridad JWT
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            Array.Empty<string>()
        }
    });

    // Incluir comentarios XML
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    if (File.Exists(xmlPath))
    {
        c.IncludeXmlComments(xmlPath);
    }
});

// Configurar Ocelot
builder.Services.AddOcelot()
    .AddDelegatingHandler<TokenHandler>();

var app = builder.Build();

// Configurar el pipeline HTTP
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseCors("AllowAll");

app.UseHttpsRedirection();

// Configurar Swagger UI
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Touch Gateway API V1");
    c.RoutePrefix = "swagger";
    
    // Personalizar la UI
    c.DocExpansion(Swashbuckle.AspNetCore.SwaggerUI.DocExpansion.List);
    c.DefaultModelsExpandDepth(-1);
    c.DisplayRequestDuration();
    c.EnableDeepLinking();
    c.EnableFilter();
    c.ShowExtensions();
    
    // Personalizar el tema
    c.InjectStylesheet("/swagger-ui/custom.css");
    c.DocumentTitle = "Touch Gateway API - Documentation";
    
    // Configurar OAuth
    c.OAuthClientId("swagger");
    c.OAuthAppName("Touch Gateway API - Swagger");
});

// Usar Ocelot middleware
await app.UseOcelot();

app.Run();
