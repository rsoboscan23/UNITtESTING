
using BusinessLayer;
using BusinessLayer.Exceptions;
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
    public partial class ShowCurrenciesForm : Form
    {
        public ShowCurrenciesForm()
        {
            InitializeComponent();
        }

        private void ShowCurrenciesForm_Load(object sender, EventArgs e)
        {
            ShowCurrencies();
        }

        private void ShowCurrencies()
        {
            var currencyService = new CurrencyService();
            var currencies = currencyService.GetCurrencies();

            dgvCurrencies.DataSource = currencies;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var currencyService = new CurrencyService();
                currencyService.AddCurrency(txtCode.Text, txtCountry.Text);
            }
            catch (CurrencyException ex)
            {
                MessageBox.Show(ex.Message);
            }

            ShowCurrencies();
        }
    }
}
