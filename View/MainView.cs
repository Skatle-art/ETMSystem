using Spectre.Console;
using ETMSystem.Controller;
using System;
using ETMSystem.View.ClientView;


namespace ETMSystem.View
{
    internal class MainView
    {

        public static bool ContinueMenu()
        {
            Console.Clear();
            Console.WriteLine("\nStill wanna continue?");

            var continueChoice = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .AddChoices("Yes", "No"));

            if (continueChoice == "Yes")
            {
                Console.WriteLine("Nice! Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
                return false;
            }

            else
            {
                Console.WriteLine("Exiting the application...");
                return true;
            }

            }
        public static void Mainview(ClientController controller)
        {
                      
            
            AnsiConsole.Console.WriteLine("Welcome to ETM System"); Console.ReadKey();
            bool option = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Hello, Welcome to the ETM System!");
                Console.WriteLine("Please select an option:");
                var choice = AnsiConsole.Prompt(new SelectionPrompt<string>().AddChoices("Display Clients", "Add Client", "Update Client", "Exit"));
                if (choice == "Display Clients")
                {         
                        controller.DisplayClients();
                    
                }
                else if (choice == "Add Client")
                {
                    // Add Client Logic
                        controller.AddNewClient();
                    
                }
                else if (choice == "Update Client")
                {
                    // Update Client Logic
                   var closeTonewClient = UpdateView.SelectClientToUpdate(controller.GetAllClients());
                   var newClient = UpdateView.UpdateClient(closeTonewClient);
                   controller.UpdateClient(newClient);

                }
                else if (choice == "Exit")
                {
                    AnsiConsole.MarkupLine("[green] Thank You!! [/]");
                    option = true;
                    break;
                }
                Console.WriteLine("Press any key to continue..."); 
                Console.ReadKey();
                option = ContinueMenu();

            } while (option == false);
           
        }

 


    }
}