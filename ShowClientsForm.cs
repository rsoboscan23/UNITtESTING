using BusinessLayer;
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
    public partial class ShowClientsForm : Form
    {
        public ShowClientsForm()
        {
            InitializeComponent();
        }

        private void ShowClientsForm_Load(object sender, EventArgs e)
        {
            ShowAllClients();
        }

        private void ShowAllClients()
        {
            var clientService = new ClientService();
            var clients = clientService.GetClients();

            dgvClients.DataSource = clients;
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            var client = GetSelectedClient();
            DisplayEditForm(client);

            ShowAllClients();
        }

        private static void DisplayEditForm(IClient client)
        {
            var form = new EditClientForm(client);
            form.ShowDialog();
        }

        private IClient GetSelectedClient()
        {
            IClient client = null;
            if (dgvClients.SelectedRows.Count > 0)
            {
                client = dgvClients.SelectedRows[0].DataBoundItem as IClient;
            }
            return client;
        }

        private void btnShowAccounts_Click(object sender, EventArgs e)
        {
            var chosenClient = GetSelectedClient();
            var form = new ShowClientAccountsForm(chosenClient);
            form.ShowDialog();
        }
    }
}
