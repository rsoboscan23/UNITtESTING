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
    public class CurrencyService
    {
        private readonly string _referenceCurrencyCode = "HRK";

        public List<Currency> GetCurrencies()
        {
            return UnitOfWork.CurrencyRepository.GetAll();
        }

        public Currency GetCurrency(string code)
        {
            return UnitOfWork.CurrencyRepository.GetByCode(code);
        }

        public void AddCurrency(string code, string country)
        {
            bool alreadyExists = UnitOfWork.CurrencyRepository.GetByCode(code) != null || UnitOfWork.CurrencyRepository.GetByCountry(country) != null;
            if(alreadyExists == false)
            {
                var currency = new Currency(code, country);
                UnitOfWork.CurrencyRepository.Add(currency);
            }
            else
            {
                throw new CurrencyException("Currency with that code or country already exists!");
            }
        }

        public Currency GetReferenceCurrency()
        {
            return UnitOfWork.CurrencyRepository.GetByCode(_referenceCurrencyCode);
        }
    }
}
