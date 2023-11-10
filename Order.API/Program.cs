 using Order.API.BusinessService.OrderService.OrderServices;
using Order.API.BusinessService.ProductService;
using Order.API.Data;
using Order.API.DataService;
using Order.API.DataService.OrderService;
using Order.API.DataService.ProductService;
using Order.API.DataService.UserService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<SeedDataService>();
builder.Services.AddSingleton<OrderData>();
builder.Services.AddScoped<IOrderDataService,OrderDataService>();
builder.Services.AddScoped<IUserDataService, UserDataService>();
builder.Services.AddScoped<IProductDataService, ProductDataService>();
builder.Services.AddTransient<IOrderService, OrderService>();
builder.Services.AddTransient<IProductService, ProductService>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
