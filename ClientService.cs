using BusinessLayer.Exceptions;
using DAL;
using Entities.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ClientService
    {
        public List<IClient> GetClients()
        {
            return UnitOfWork.ClientRepository.GetAll();
        }

        public void CreatePremiumClient(string oib, string company, string firstName, string lastName)
        {
            ValidatePremiumClientData(oib, firstName, lastName, company);

            var client = new PremiumClient(oib, company, firstName, lastName);
            UnitOfWork.ClientRepository.Add(client);
        }

        public void CreateBasicClient(string oib, string firstName, string lastName)
        {
            ValidateBasicClientData(oib, firstName, lastName);

            var client = new BasicClient(oib, firstName, lastName);
            UnitOfWork.ClientRepository.Add(client);
        }

        public void UpdatePremiumClient(PremiumClient client, string oib, string company, string firstName, string lastName)
        {
            if(client == null)
            {
                throw new ClientException("Client is not provided!");
            }

            ValidatePremiumClientData(oib, firstName, lastName, company);

            client.OIB = oib;
            client.FirstName = firstName;
            client.LastName = lastName;
            client.CompanyName = company;
        }

        public void UpdateBasicClient(BasicClient client, string oib, string firstName, string lastName)
        {
            if (client == null)
            {
                throw new ClientException("Client is not provided!");
            }

            ValidateBasicClientData(oib, firstName, lastName);

            client.OIB = oib;
            client.FirstName = firstName;
            client.LastName = lastName;
        }

        private void ValidateBasicClientData(string oib, string firstName, string lastName)
        {
            if (oib.Length != 11)
            {
                throw new ClientException("OIB needs to have 11 characters!");
            }
            else if (firstName.Length == 0)
            {
                throw new ClientException("Please enter first name!");
            }
            else if (lastName.Length == 0)
            {
                throw new ClientException("Please enter last name!");
            }
        }

        private void ValidatePremiumClientData(string oib, string firstName, string lastName, string company)
        {
            if (oib.Length != 11)
            {
                throw new ClientException("OIB needs to have 11 characters!");
            }
            else if (company.Length == 0)
            {
                throw new ClientException("Please enter company name!");
            }
            else if (firstName.Length == 0)
            {
                throw new ClientException("Please enter first name!");
            }
            else if (lastName.Length == 0)
            {
                throw new ClientException("Please enter last name!");
            }
        }
    }
}
