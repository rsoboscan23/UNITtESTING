using BusinessLayer;
using BusinessLayer.Exceptions;
using Entities.Accounts;
using Entities.Clients;
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
    public partial class NewTransactionForm : Form
    {
        private IClient _payerClient;
        private IAccount _payerAccount;

        private IClient _receiverClient;
        private IAccount _receiverAccount;

        public NewTransactionForm()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnChoosePayerAccount_Click(object sender, EventArgs e)
        {
            if (_payerClient != null)
            {
                ChooseAccountForm form = new ChooseAccountForm(_payerClient);
                form.ShowDialog();

                _payerAccount = form.chosenAccount;
                ShowPayerAccount();
            }
            else
            {
                MessageBox.Show("You first have to choose payer client!");
            }
        }

        private void ShowPayerAccount()
        {
            if (_payerAccount != null)
            {
                txtPayerAccount.Text = _payerAccount.ToString();
            }
            else
            {
                txtPayerAccount.Text = "";
            }
        }

        private void BtnChooseReceiverAccount_Click(object sender, EventArgs e)
        {
            if (_receiverClient != null)
            {
                ChooseAccountForm form = new ChooseAccountForm(_receiverClient);
                form.ShowDialog();

                _receiverAccount = form.chosenAccount;
                ShowReceiverAccount();
            }
            else
            {
                MessageBox.Show("You first have to choose receiver client!");
            }
        }

        private void ShowReceiverAccount()
        {
            if (_receiverAccount != null)
            {
                txtReceiverAccount.Text = _receiverAccount.ToString();
            }
            else
            {
                txtReceiverAccount.Text = "";
            }
        }

        private void btnChoosePayerCient_Click(object sender, EventArgs e)
        {
            ChooseClientForm form = new ChooseClientForm();
            form.ShowDialog();

            _payerClient = form.ChosenClient;
            ShowPayerClient();
        }

        private void ShowPayerClient()
        {
            if (_payerClient != null)
            {
                txtPayerClient.Text = _payerClient.Description;
            }
            else
            {
                txtPayerClient.Text = "";
            }
        }

        private void btnChooseReceiverClient_Click(object sender, EventArgs e)
        {
            ChooseClientForm form = new ChooseClientForm();
            form.ShowDialog();

            _receiverClient = form.ChosenClient;
            ShowReceiverClient();
        }

        private void ShowReceiverClient()
        {
            if (_receiverClient != null)
            {
                txtReceiverClient.Text = _receiverClient.Description;
            }
            else
            {
                txtReceiverClient.Text = "";
            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            var transactionService = new TransactionService();

            double amount = double.Parse(txtAmount.Text);
            if (_payerAccount != null && _receiverAccount != null && amount > 0)
            {
                try
                {
                    transactionService.MakePayment(_payerAccount, _receiverAccount, amount);
                    Close();
                }
                catch (TransactionException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter required data!");
            }
            
        }
    }
}
