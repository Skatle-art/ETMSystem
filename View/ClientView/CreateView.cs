using ETMSystem.Models;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Text;


namespace ETMSystem.View.ClientView
{
    internal class CreateView
    {   

        public static Client GetClientDetails()
        { 
            Client client = new Client();
            client.Name = AnsiConsole.Ask<string>("Enter Name: ");
            client.Surname = AnsiConsole.Ask<string>("Enter Surname: ");
            client.PhoneNo = AnsiConsole.Ask<string>("Enter Phone Number: ");
            client.Email = AnsiConsole.Ask<string>("Enter Email: ");
            client.Address = AnsiConsole.Ask<string>("Enter Address: ");
            client.JobTitle = AnsiConsole.Ask<string>("Enter Job Title: ");
            client.EmergencyContact = AnsiConsole.Ask<string>("Enter Emergency Contact: ");
            client.ClientStatus = AnsiConsole.Ask<string>("Enter Client Status: ");
            Console.WriteLine("Thank you for providing the client details.");
            Console.ReadKey();
            Console.Clear();
            return client;

        }
        public static void DisplayClientDetails(Client client)
        {
            
            Console.WriteLine("YOU HAVE SUCCESSFULLY CREATED A CLIENT.");
            AnsiConsole.MarkupLine($"[green]Name:[/] {client.Name}");
            AnsiConsole.MarkupLine($"[green]Surname:[/] {client.Surname}");
            AnsiConsole.MarkupLine($"[green]Phone No:[/] {client.PhoneNo}");
            AnsiConsole.MarkupLine($"[green]Email:[/] {client.Email}");
            AnsiConsole.MarkupLine($"[green]Address:[/] {client.Address}");
            AnsiConsole.MarkupLine($"[green]Job Title:[/] {client.JobTitle}");
            AnsiConsole.MarkupLine($"[green]Emergency Contact:[/] {client.EmergencyContact}");
            AnsiConsole.MarkupLine($"[green]Client Status:[/] {client.ClientStatus}");
               
         }
        
        
   }
}
