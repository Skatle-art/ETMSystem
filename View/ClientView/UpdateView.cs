using ETMSystem.Models;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Text;
using ETMSystem.Controller;

namespace ETMSystem.View.ClientView
{
    internal class UpdateView
    {

        public static Client SelectClientToUpdate(List<Client> clients)
        {

            Client selectedClient = AnsiConsole.Prompt(
                new SelectionPrompt<Client>()
                    .Title("Select a client to update")
                    .UseConverter(client =>
                        $"{client.Name} {client.Surname} {client.Email}")
                    .AddChoices(clients));
            AnsiConsole.MarkupLine($"[green]You have selected:[/] {selectedClient.Name} {selectedClient.Surname} {selectedClient.Email}");
            return selectedClient;
        }

        public static Client UpdateClient(Client client)
        {
            client.Name = AnsiConsole.Ask<string>($"Enter new name (current: {client.Name}):", client.Name);
            client.Surname = AnsiConsole.Ask<string>($"Enter new surname (current: {client.Surname}):", client.Surname);
            client.Email = AnsiConsole.Ask<string>($"Enter new email (current: {client.Email}):", client.Email);
            client.PhoneNo = AnsiConsole.Ask<string>($"Enter new phone number (current: {client.PhoneNo}):", client.PhoneNo);
            client.Address = AnsiConsole.Ask<string>($"Enter new address (current: {client.Address}):", client.Address);
            client.JobTitle = AnsiConsole.Ask<string>($"Enter new job title (current: {client.JobTitle}):", client.JobTitle);
            client.EmergencyContact = AnsiConsole.Ask<string>($"Enter new emergency contact (current: {client.EmergencyContact}):", client.EmergencyContact);
            client.ClientStatus = AnsiConsole.Ask<string>($"Enter new client status (current: {client.ClientStatus}:", client.ClientStatus);
            return client;
        }

    }
}