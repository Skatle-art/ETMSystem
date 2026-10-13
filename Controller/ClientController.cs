using ETMSystem.Service;
using System;
using System.Collections.Generic;
using System.Text;
using ETMSystem.Models;
using ETMSystem.View.ClientView;
using System.Threading.Tasks;
using ETMSystem.Repository;

namespace ETMSystem.Controller
{
    internal class ClientController
    {
        private readonly ICreateClientService _createClientService;
        private readonly IReadClientService _readClientService;
        private readonly IUpdateClientService _updateClientService;
        private readonly IDeleteClientService _deleteClientService;
        private readonly ICheckUserLoginService _checktUserName;
        private readonly IRegisterNewUserService _regUserName;


        public ClientController(ICreateClientService createClientService, IReadClientService readClientService, IUpdateClientService updateClientService, IDeleteClientService deleteClientService, ICheckUserLoginService userNameService, IRegisterNewUserService registerNewUser)
        {
            _createClientService = createClientService;
            _readClientService = readClientService;
            _updateClientService = updateClientService;
            _deleteClientService = deleteClientService;
            _checktUserName = userNameService;
            _regUserName = registerNewUser;

        }
       public void DisplayClients()
        {
            var clients = _readClientService.GetClientsAsync().Result;
            ClientView.DisplayClients(clients);
        }
        public void AddNewClient()
        {
            var clientDetails = CreateView.GetClientDetails();
            CreateView.DisplayClientDetails(clientDetails);
            _createClientService.AddNewClient(clientDetails);
        }
        public Client GetClientById(int clientId)
        {
            return _updateClientService.GetClientById(clientId);
         
        }
        public void UpdateClient(Client client)
        {
            _updateClientService.UpdateClient(client);
        }
        public List<Client> GetAllClients()
        {
            var clients = _readClientService.GetClientsAsync().Result;
            return clients;
        }
        public void GetDeleteId(int deleteId)
        {
            _deleteClientService.GetDeleteId(deleteId);
        }
        public void DeleteClient(Client client)
        {
            _deleteClientService.DeleteClient(client);
        }
       public bool CheckUser(string Username, string password)
        {
            return _checktUserName.CheckUser(Username, password);
            
        }
        public void RegisterUser(User user)
        {
            _regUserName.RegisterUser(user);
        }
    }
}
