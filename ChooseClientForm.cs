
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
    public partial class ChooseClientForm : Form
    {
        public IClient ChosenClient { get; set; }

        public ChooseClientForm()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            ChosenClient = null;
            Close();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            ChosenClient = GetSelectedClient();
            Close();
        }

        private IClient GetSelectedClient()
        {
            if (dgvClients.CurrentRow != null)
            {
                return dgvClients.CurrentRow.DataBoundItem as IClient;
            }
            return null;
        }

        private void ChooseClientForm_Load(object sender, EventArgs e)
        {
            var clientService = new ClientService();
            var clients = clientService.GetClients();
            dgvClients.DataSource = clients;
        }
    }
}
