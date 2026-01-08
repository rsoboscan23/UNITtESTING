
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
    public partial class ShowExchangeRatesForm : Form
    {
        public ShowExchangeRatesForm()
        {
            InitializeComponent();
        }

        private void ShowExchangeRatesForm_Load(object sender, EventArgs e)
        {
            ShowExchangeRates();
        }

        private void ShowExchangeRates()
        {
            var exchangeService = new ExchangeService();
            var exchangeRates = exchangeService.GetExchangeRates();

            dgvExchangeRates.DataSource = exchangeRates;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new NewExchangeRateForm();
            form.ShowDialog();
            ShowExchangeRates();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var rate = GetSelectedRate();
            if (rate == null)
            {
                MessageBox.Show("You have to select exchange rate!");
            }

            var form = new EditExchangeRateForm(rate);
            form.ShowDialog();
            ShowExchangeRates();
        }

        private ExchangeRate GetSelectedRate()
        {
            if (dgvExchangeRates.CurrentRow != null)
            {
                return dgvExchangeRates.CurrentRow.DataBoundItem as ExchangeRate;
            }
            return null;
        }
    }
}
