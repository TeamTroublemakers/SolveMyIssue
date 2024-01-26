using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using MongoDB.Driver;
using SolveMyIssue.Data;
using SolveMyIssue.DataAccess.Services;
using SolveMyIssue.DataAccess.Services.Interfaces;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

var client = new MongoClient(Environment.GetEnvironmentVariable("CONNECTION_STRING"));
builder.Services.AddSingleton<MongoClient>(client);
builder.Services.AddSingleton<IUserRepository, UserRepository>();
builder.Services.AddSingleton<IIssueRepository, IssueRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
