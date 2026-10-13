
using ETMSystem.Models;
using ETMSystem.Service;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Text;


namespace ETMSystem.View.ClientView
{
    internal class ClientView
    {
        private static List<Client> _clients;
        public ClientView(List<Client> clients)
        {
            _clients = clients;
        }
        public static void DisplayClients(List<Client> clients)
        {

            var table = new Table();
            table.AddColumn("Name");
            table.AddColumn("Surname");
            table.AddColumn("Phone No");
            table.AddColumn("Email");
            table.AddColumn("Address");
            table.AddColumn("Job Title");
            table.AddColumn("Emergency Contact");
            table.AddColumn("Client Status");
            foreach (var client in clients)
            {
                table.AddRow(client.Name, client.Surname, client.PhoneNo, client.Email, client.Address, client.JobTitle, client.EmergencyContact, client.ClientStatus);

            }
            AnsiConsole.Write(table);
            _clients = clients;

        }
 
        
    }
}
