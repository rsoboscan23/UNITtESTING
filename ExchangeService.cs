using BusinessLayer.Exceptions;
using DAL;
using Entities.Exchange;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ExchangeService
    {
        public double ChangeMoney(double amount, string from, string to)
        {
            var fromCurrency = UnitOfWork.CurrencyRepository.GetByCode(from);
            var toCurrency = UnitOfWork.CurrencyRepository.GetByCode(to);

            return ChangeMoney(amount, fromCurrency, toCurrency);
        }

        public double ChangeMoney(double amount, Currency from, Currency to)
        {
            var fromExchangeRate = UnitOfWork.ExchangeRateRepository.GetByCurrency(from);
            var toExchangeRate = UnitOfWork.ExchangeRateRepository.GetByCurrency(to);

            return amount * fromExchangeRate.Rate / toExchangeRate.Rate;
        }

        public List<ExchangeRate> GetExchangeRates()
        {
            return UnitOfWork.ExchangeRateRepository.GetAll();
        }

        public void CreateExchangeRate(string currencyName, double value)
        {
            var currency = UnitOfWork.CurrencyRepository.GetByCode(currencyName);

            var exchangeRate = new ExchangeRate(currency, value);

            if (UnitOfWork.ExchangeRateRepository.GetByCurrency(currency) != null)
            {
                throw new ExchangeRateException("Exchange rate already exists for this currency!") ;
            }

            UnitOfWork.ExchangeRateRepository.Add(exchangeRate);
        }
    }
}
