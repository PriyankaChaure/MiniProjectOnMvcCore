using Microsoft.EntityFrameworkCore;
using mvc_core_mini_project.Models;
using mvc_core_mini_project.Reposiratories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContextPool<CompanyContext>(opt => opt.UseLazyLoadingProxies().UseSqlServer(builder.Configuration.GetConnectionString("scon")));
builder.Services.AddScoped<SubjectInterface, SubjectRepo>();
builder.Services.AddScoped<AuthorInterface, AuthorRepo>();
builder.Services.AddScoped<BookInterface, BookRepo>();
builder.Services.AddScoped<CustomerInterface, CustomerRepo>();
builder.Services.AddScoped<SalesInterface, SalesRepo>();
builder.Services.AddScoped<CustsalvmInterface,CustsalRepo>();
builder.Services.AddScoped<UserLoginInterface, UserLoginRepo>();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(opt =>
{
    opt.IdleTimeout = TimeSpan.FromMinutes(20);
    opt.Cookie.IsEssential = true;
    opt.Cookie.HttpOnly = true;
});

var app = builder.Build();
app.UseSession();

app.UseStaticFiles();
//app.UseEndpoints(endpoints =>
//{
app.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
app.MapDefaultControllerRoute();
app.Run();

//    app.MapDefaultControllerRoute();
//});
