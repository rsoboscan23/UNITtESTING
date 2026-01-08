using BusinessLayer;
using BusinessLayer.Exceptions;
using Entities.Exchange;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class NewExchangeRateForm : Form
    {
        public NewExchangeRateForm()
        {
            InitializeComponent();
        }

        private void txtCurrency_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NewExchangeRateForm_Load(object sender, EventArgs e)
        {
            var currencyService = new CurrencyService();
            var referenceCurrency = currencyService.GetReferenceCurrency();
            var currencies = currencyService.GetCurrencies();

            txtReferenceCurrency.Text = referenceCurrency.ToString();
            cmbCurrency.DataSource = currencies;
            txtRate.Text = "0";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            double rate = double.Parse(txtRate.Text);
            var currency = cmbCurrency.SelectedItem as Currency;

            var exchangeService = new ExchangeService();

            try
            {
                exchangeService.CreateExchangeRate(currency.Code, rate);
            }
            catch(ExchangeRateException ex)
            {
                MessageBox.Show(ex.Message);
            }

            Close();
        }
    }
}
