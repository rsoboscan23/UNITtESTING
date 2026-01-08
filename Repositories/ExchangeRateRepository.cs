using Entities.Exchange;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ExchangeRateRepository : Repository<ExchangeRate>
    {
        protected override void InitializeItems()
        {
            base.InitializeItems();

            Currency aud = UnitOfWork.CurrencyRepository.GetByCode("AUD");
            items.Add(new ExchangeRate(aud, 4.07));

            Currency cad = UnitOfWork.CurrencyRepository.GetByCode("CAD");
            items.Add(new ExchangeRate(cad, 4.9));

            Currency chf = UnitOfWork.CurrencyRepository.GetByCode("CHF");
            items.Add(new ExchangeRate(chf, 7.2));

            Currency gbp = UnitOfWork.CurrencyRepository.GetByCode("GBP");
            items.Add(new ExchangeRate(gbp, 8.2));

            Currency usd = UnitOfWork.CurrencyRepository.GetByCode("USD");
            items.Add(new ExchangeRate(usd, 7.1));

            Currency bam = UnitOfWork.CurrencyRepository.GetByCode("BAM");
            items.Add(new ExchangeRate(bam, 3.88));

            Currency eur = UnitOfWork.CurrencyRepository.GetByCode("EUR");
            items.Add(new ExchangeRate(eur, 7.6));

            Currency hrk = UnitOfWork.CurrencyRepository.GetByCode("HRK");
            items.Add(new ExchangeRate(hrk, 1));
        }

        public ExchangeRate GetByCurrency(Currency currency)
        {
            return items.FirstOrDefault(c => c.Currency == currency);
        }

        public ExchangeRate GetByCurrency(string currencyName)
        {
            return items.FirstOrDefault(c => c.Currency.Code.ToLower() == currencyName.ToLower());
        }
    }
}
