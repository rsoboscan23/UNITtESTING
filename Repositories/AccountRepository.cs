using Entities.Accounts;
using Entities.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class AccountRepository : Repository<IAccount>
    {
        public List<IAccount> GetByClient(IClient client)
        {
            return items.FindAll(items => items.Owner == client);
        }

        public IAccount GetByIBAN(string iban)
        {
            return items.FirstOrDefault(item => item.IBAN == iban);
        }

        protected override void InitializeItems()
        {
            base.InitializeItems();

            var currencyRepo = UnitOfWork.CurrencyRepository;
            var clientRepo = UnitOfWork.ClientRepository;

            items = new List<IAccount>
            {
                new CheckingAccount("HR11", 12000, 0, currencyRepo.GetByCode("HRK"), clientRepo.GetByOIB("11111111111")),
                new ForeignAccount("HR51", 1000, currencyRepo.GetByCode("EUR"), clientRepo.GetByOIB("11111111111")),
                new ForeignAccount("HR52", 500, currencyRepo.GetByCode("USD"), clientRepo.GetByOIB("11111111111")),
                new CheckingAccount("HR12", 8000, 0, currencyRepo.GetByCode("HRK"), clientRepo.GetByOIB("22222222222")),
                new ForeignAccount("HR53", 800, currencyRepo.GetByCode("CHF"), clientRepo.GetByOIB("22222222222")),
                new ForeignAccount("HR54", 700, currencyRepo.GetByCode("BAM"), clientRepo.GetByOIB("22222222222")),
                new CheckingAccount("HR13", 9000, 5000, currencyRepo.GetByCode("HRK"), clientRepo.GetByOIB("33333333333")),
                new ForeignAccount("HR55", 800, currencyRepo.GetByCode("EUR"), clientRepo.GetByOIB("33333333333")),
                new CheckingAccount("HR14", 3200, 3000, currencyRepo.GetByCode("HRK"), clientRepo.GetByOIB("44444444444")),
                new ForeignAccount("HR56", 700, currencyRepo.GetByCode("EUR"), clientRepo.GetByOIB("44444444444")),
                new CheckingAccount("HR15", 6500, 2000, currencyRepo.GetByCode("HRK"), clientRepo.GetByOIB("55555555555")),
                new ForeignAccount("HR57", 4000, currencyRepo.GetByCode("EUR"), clientRepo.GetByOIB("55555555555")),
                new CheckingAccount("HR16", 100000, 0, currencyRepo.GetByCode("HRK"), clientRepo.GetByOIB("66666666666")),
                new ForeignAccount("HR58", 500, currencyRepo.GetByCode("USD"), clientRepo.GetByOIB("66666666666")),
                new CheckingAccount("HR17", 111500, 0, currencyRepo.GetByCode("HRK"), clientRepo.GetByOIB("77777777777")),
                new ForeignAccount("HR59", 800, currencyRepo.GetByCode("CHF"), clientRepo.GetByOIB("77777777777")),
                new CheckingAccount("HR18", 80000, 0, currencyRepo.GetByCode("HRK"), clientRepo.GetByOIB("88888888888")),
                new ForeignAccount("HR60", 700, currencyRepo.GetByCode("BAM"), clientRepo.GetByOIB("88888888888")),
                new CheckingAccount("HR19", 60000, 0, currencyRepo.GetByCode("HRK"), clientRepo.GetByOIB("99999999999")),
                new ForeignAccount("HR61", 800, currencyRepo.GetByCode("EUR"), clientRepo.GetByOIB("99999999999")),
                new CheckingAccount("HR20", 6500, 0, currencyRepo.GetByCode("HRK"), clientRepo.GetByOIB("10000000000")),
                new ForeignAccount("HR62", 700, currencyRepo.GetByCode("EUR"), clientRepo.GetByOIB("10000000000"))
            };
        }
    }
}
