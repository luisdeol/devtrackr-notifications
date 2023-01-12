using DevTrackR.Notifications.API.Infrastructure;
using DevTrackR.Notifications.API.Subscribers;
using SendGrid.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var configuration = builder.Configuration;

builder.Services.AddScoped<INotificationService, EmailService>();
builder.Services.AddSendGrid(options =>
{
    options.ApiKey = configuration.GetSection("SendGrid:ApiKey").Value;
});

builder.Services.AddHostedService<ShippingOrderUpdatedSubscriber>();

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

app.Run();
