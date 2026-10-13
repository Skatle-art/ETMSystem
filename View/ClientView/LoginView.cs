using ETMSystem.Models;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Text;
using ETMSystem.Models;
using ETMSystem.Controller;
using BCrypt.Net;

namespace ETMSystem.View.ClientView
{
    internal class LoginView
    {
        public static void LoginUser(ClientController controller)
        {
            string userName;
            bool Exist= true;
            bool DoesNotExist =false;
            string password;
            do {
                Exist = true;
                AnsiConsole.MarkupLine("Well Come To Employee Transport Management System");
                var choice = AnsiConsole.Prompt(new SelectionPrompt<string>().AddChoices("LOGIN TO ACCOUNT", "REGISTER ACCOUNT"));
                if (choice == "LOGIN TO ACCOUNT")
                {
                    userName = AnsiConsole.Ask<string>($"Enter username:");
                    password = AnsiConsole.Ask<string>($"Enter password:");
                    if (controller.CheckUser(userName, password) == Exist)
                    {
                        Console.Clear();
                        AnsiConsole.MarkupLine($"[green]Successfully LoggedIn!![/]");
                   
                    }
                    else
                    {
                        AnsiConsole.MarkupLine("[red]Invalid Login Details!!!![/]");
                        AnsiConsole.WriteLine("Please Register Account");
                        Console.ReadKey();
                        Exist = DoesNotExist;
                        Console.Clear();
                    }
                }
     
                if(choice == "REGISTER ACCOUNT")
                {
                    Console.WriteLine("Please Fill In the Following!!");
                    User user = new User();
                    user.Username = AnsiConsole.Ask<string>($"Enter username here:");
                    user.PasswordHash = AnsiConsole.Ask<string>($"Enter password here:");
                    controller.RegisterUser(user);
                    AnsiConsole.MarkupLine($"[green] Registered Successfully!![/]");
                    Console.ReadKey();
                    Console.Clear();
                    AnsiConsole.WriteLine("Now Please Login!!");
                    Exist = DoesNotExist;

                }

            }
            while (!Exist);
            
         
        }
     
    }
}
