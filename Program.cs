using System;
using Microsoft.Extensions.DependencyInjection;
using ETMSystem.Data;
using ETMSystem.Repository;
using ETMSystem.Service;
using ETMSystem.Controller;
using Spectre.Console;
using ETMSystem.View.ClientView;
using ETMSystem.View;




namespace ETMSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddDbContext<ETMSystemContext>();
            services.AddScoped<ClientController>();
            services.AddScoped<IReadClientRepo, ReadClientRepo>();
            services.AddScoped<IReadClientService, ReadClientService>();
            services.AddScoped<ICreateClientRepo, CreateClientRepo>();
            services.AddScoped<IUpdateClientRepo, UpdateClientRepo>();
            services.AddScoped<IDeleteClientRepo, DeleteClientRepocs>();    
            services.AddScoped<IDeleteClientService, DeletClientService>();
            services.AddScoped<ICreateClientService, CreateClientService>();
            services.AddScoped<IUpdateClientService, UpdateClientService>();
            services.AddScoped<IRegisterNewUserRepo, RegisterNewUserRepo>();
            services.AddScoped<IRegisterNewUserService, RegisterNewUserService>();
            services.AddScoped<ICheckUserLogin, CheckUserLogin>();
            services.AddScoped<ICheckUserLoginService, CheckUserLoginService>();
            var serviceProvider = services.BuildServiceProvider();
    
            var controller = serviceProvider.GetService<ClientController>();
            LoginView.LoginUser(controller);
            MainView.Mainview(controller);




        }
     }
    }
