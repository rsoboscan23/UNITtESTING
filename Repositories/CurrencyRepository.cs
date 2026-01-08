using Entities.Exchange;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class CurrencyRepository : Repository<Currency>
    {
        public Currency GetByCode(string code)
        {
            return items.FirstOrDefault(c => c.Code.ToLower() == code.ToLower());
        }

        public Currency GetByCountry(string country)
        {
            return items.FirstOrDefault(c => c.Country.ToLower() == country.ToLower());
        }

        protected override void InitializeItems()
        {
            base.InitializeItems();
            items = new List<Currency>()
            {
                new Currency("AUD", "Australija"),
                new Currency("CAD", "Kanada"),
                new Currency("CHF", "Švicarska"),
                new Currency("GBP", "V. Britanija"),
                new Currency("USD", "SAD"),
                new Currency("BAM", "BiH"),
                new Currency("EUR", "EMU"),
                new Currency("HRK", "Hrvatska")
            };
        }
    }
}
