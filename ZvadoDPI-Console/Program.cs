using ZvadoDPI;
using ZvadoDPI.DPI;
using ZvadoDPI_Console;

DependencyContainer container = new();
container.AddTransient<SqlAdminService>();
container.AddSingleton<SqlCartService>();
container.AddSingleton<SqlProductService>();

DependecyResolver resolver = new(container);

SqlAdminService adminService1 = resolver.GetService<SqlAdminService>();
adminService1.CreateProduct();

SqlAdminService adminService2 = resolver.GetService<SqlAdminService>();
adminService2.CreateProduct();

SqlAdminService adminService3 = resolver.GetService<SqlAdminService>();
adminService3.CreateProduct();

Class1 Class1 = new(resolver);

Class1.Test();