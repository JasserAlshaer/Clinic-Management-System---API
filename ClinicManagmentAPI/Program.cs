using ClinicManagementAPI.Interface;
using ClinicManagmentAPI.Implementations;
using ClinicManagmentAPI.Interface;
using Microsoft.OpenApi.Models;
using Serilog;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//Dependancy Injection For Implementation Classes
builder.Services.AddScoped<IApointmentService, ApointmentService>();
builder.Services.AddScoped<IInvoiceService, InvoiceService>();
builder.Services.AddScoped<IMedicalProcedureService, MedicalProcedureService>();
builder.Services.AddScoped<IMedicalReportAttachmentService, MedicalReportAttachmentService>();
builder.Services.AddScoped<IMedicalReportLaborityTestService, MedicalReportLaborityTestService>();
builder.Services.AddScoped<IMedicalReportService, MedicalReportService>();
builder.Services.AddScoped<IMedicienListService, MedicienListService>();
builder.Services.AddScoped<IMedicienService, MedicienService>();
builder.Services.AddScoped<IProudureTitleService, ProudureTitleService>();
builder.Services.AddScoped<ISickLeaveService,SickLeaveService>();
builder.Services.AddScoped<IUserService,UserService>();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Clinic Management System",
    });

    // using System.Reflection;
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});
var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
string loggerPath = configuration.GetSection("Logger").Value;
//use the above line to store file path in appsetings

Serilog.Log.Logger = new LoggerConfiguration().ReadFrom.Configuration(configuration).
                WriteTo.File(loggerPath, rollingInterval: RollingInterval.Day).
                CreateLogger();

var app = builder.Build();

try
{
    Log.Information("Clinic Management System API Has been Launched Successfully");
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();


}
catch (Exception ex)
{
    Log.Error("Something Went Wrong On Starting Application");
    Log.Error($"Error: {ex}");
}

