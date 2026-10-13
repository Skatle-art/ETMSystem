using ETMSystem.Models;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETMSystem.View.ClientView
{
    internal class DeleteView
    {
        public static Client SelectDeleteClient(List<Client> clients)
        {
            Client selectedClient = AnsiConsole.Prompt(
                new SelectionPrompt<Client>()
                    .Title("Select a client to delete")
                    .UseConverter(client =>
                        $"{client.Name} {client.Surname} {client.Email}")
                    .AddChoices(clients));
            AnsiConsole.MarkupLine($"[green]You have selected:[/] {selectedClient.Name} {selectedClient.Surname} {selectedClient.Email}");
            return selectedClient;

        }
        public static void ShowDeletedClient(Client clients)
        {

        }
    }
}
