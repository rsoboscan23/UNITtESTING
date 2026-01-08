using BusinessLayer.Exceptions;
using DAL;
using Entities.Accounts;
using Entities.Clients;
using Entities.Exchange;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class AccountService
    {
        public void CreateCheckingAccount(string iban, double balance, double overdraft, IClient client)
        {
            var currencyService = new CurrencyService();
            var currency = currencyService.GetReferenceCurrency();

            var checkingAccount = new CheckingAccount(iban, balance, overdraft, currency, client);
            UnitOfWork.AccountRepository.Add(checkingAccount);
        }

        public void CreateForeignCurrencyAccount(string iban, double balance, Currency chosenCurrency, IClient client)
        {
            if (chosenCurrency == null)
            {
                throw new AccountException("Account currency must be chosen!");
            }

            var currencyService = new CurrencyService();
            var currency = currencyService.GetCurrency(chosenCurrency.Code);

            var foreignCurrencyAccount = new ForeignAccount(iban, balance, currency, client);
            UnitOfWork.AccountRepository.Add(foreignCurrencyAccount);
        }

        public string GenerateIBAN()
        {
            return IbanGenerator.GenerateIBAN();
        }

        public List<IAccount> GetClientAccounts(IClient client)
        {
            return UnitOfWork.AccountRepository.GetByClient(client);
        }

        public IAccount GetAccount(string iban)
        {
            return UnitOfWork.AccountRepository.GetByIBAN(iban);
        }
    }
}
