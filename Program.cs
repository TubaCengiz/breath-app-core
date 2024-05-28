using breath_app_core.Model.DbContext;
using breath_app_core.Services;
using BreathApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Configuration;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<BreathContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("ReservationDbConnection")));
builder.Services.AddControllers();

builder.Services.AddTransient<IGenericEntityService<Profile>, ProfileService>();
builder.Services.AddTransient<IGenericEntityService<ReservationInfo>, ReservationService>();
builder.Services.AddTransient<IGenericEntityService<LoginInformation>, LoginService>();
builder.Services.AddTransient<IGenericEntityService<Assessment>, AssestmentService>();
builder.Services.AddTransient<IGenericEntityService<Contact>, ContactService>();
builder.Services.AddTransient<IGenericEntityService<AssessmentSet>, AssestmentSetService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var localOrigin = "_localhost";

builder.Services.AddCors(options => {
    options.AddPolicy(name: localOrigin,
                      policy => {
                          policy.AllowAnyOrigin();
                          policy.AllowAnyHeader();
                          policy.AllowAnyMethod();
                      });
});
var app = builder.Build();

if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(localOrigin);

app.UseAuthorization();

app.MapControllers();

app.Run();
