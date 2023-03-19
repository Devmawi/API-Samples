using Microsoft.AspNetCore.OData;
using Microsoft.OData.ModelBuilder;
using Microsoft.OpenApi.Models;
using ODataWebApi;
using ODataWebApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var modelBuilder = new ODataConventionModelBuilder();
modelBuilder.EntityType<Order>();
modelBuilder.EntitySet<Article>("Articles");
modelBuilder.EntityType<Article>()      
        .Action("rate").Returns<int>();
modelBuilder.Function("ExecuteSomeFunction").Returns<string>();

builder.Services.AddControllers().AddOData(
    options => {
        options.Select().Filter().OrderBy().Expand().Count().SetMaxTop(null).AddRouteComponents(
        "odata",
        modelBuilder.GetEdmModel());
    options.RouteOptions.EnableNonParenthesisForEmptyParameterFunction = true;
    });

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen(c =>
//{
//    c.SwaggerDoc("v2", new OpenApiInfo { Title = "API", Version = "v2" });
//    // Add support for OData-like REST endpoint with [EnableQuery]
//    c.OperationFilter<ODataOperationFilter>();
    
//});

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

app.UseAuthorization();

app.MapControllers();

app.Run();
