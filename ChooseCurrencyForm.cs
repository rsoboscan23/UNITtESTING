
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
    public partial class ChooseCurrencyForm : Form
    {
        public Currency ChosenCurrency { get; set; }
        public ChooseCurrencyForm()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            ChosenCurrency = null;
            Close();
        }

        private void ChooseCurrencyForm_Load(object sender, EventArgs e)
        {
            var currencyService = new CurrencyService();
            var currencies = currencyService.GetCurrencies();

            dgvCurrencies.DataSource = currencies;
        }

        private void BtnChoose_Click(object sender, EventArgs e)
        {
            ChosenCurrency = GetSelectedCurrency();
            Close();
        }

        private Currency GetSelectedCurrency()
        {
            if (dgvCurrencies.CurrentRow != null)
            {
                return dgvCurrencies.CurrentRow.DataBoundItem as Currency;
            }
            return null;
        }
    }
}
