using Microsoft.EntityFrameworkCore;
using MiniApi.Model;
using System.Reflection.Metadata.Ecma335;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("AppDb");
builder.Services.AddDbContext<EmployeeDbContext>(x => x.UseSqlServer(connectionString));
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Map("/employee", (Func<Employee>)(() =>
{

    return new Employee()
    {
        EmployeeName = "TesteName",
        Citizenship = "Brazil",
        EmproyeeId = "1"
    };
}
));

//app.MapGet("/employees", (Func<List<Employee>>)(() =>
//{
//    return new EmployeeCollection().GetEmployees();
//}));

//app.MapGet("/employee/{id}", async (http) =>
//{
//    if (!http.Request.RouteValues.TryGetValue("id", out var id))
//    {
//        http.Response.StatusCode = 400;
//        return;
//    }
//    else
//    {
//        await http.Response.WriteAsJsonAsync(new EmployeeCollection().GetEmployees().FirstOrDefault(x => x.EmproyeeId == (string)id));
//    }
//});

app.Run();
