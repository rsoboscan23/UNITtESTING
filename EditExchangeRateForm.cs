using BusinessLayer;
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
    public partial class EditExchangeRateForm : Form
    {
        public ExchangeRate exchangeRate { get; set; }
        public EditExchangeRateForm(ExchangeRate rate)
        {
            InitializeComponent();
            exchangeRate = rate;
        }

        private void txtCurrency_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditExchangeRateForm_Load(object sender, EventArgs e)
        {
            var currencyService = new CurrencyService();
            var referenceCurrency = currencyService.GetReferenceCurrency();

            txtReferenceCurrency.Text = referenceCurrency.ToString();
            txtCurrency.Text = exchangeRate.Currency.ToString();
            txtValue.Text = exchangeRate.Rate.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            double newValue = double.Parse(txtValue.Text);
            exchangeRate.Rate = newValue;
            Close();
        }
    }
}
