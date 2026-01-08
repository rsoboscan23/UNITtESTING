namespace PresentationLayer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.izbornik = new System.Windows.Forms.MenuStrip();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MoneyExchangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showExchangeRatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCurrenciesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izbornik.SuspendLayout();
            this.SuspendLayout();
            // 
            // izbornik
            // 
            this.izbornik.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.izbornik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsToolStripMenuItem,
            this.transactionsToolStripMenuItem,
            this.MoneyExchangeToolStripMenuItem});
            this.izbornik.Location = new System.Drawing.Point(0, 0);
            this.izbornik.Name = "izbornik";
            this.izbornik.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.izbornik.Size = new System.Drawing.Size(600, 24);
            this.izbornik.TabIndex = 1;
            this.izbornik.Text = "menuStrip1";
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showClientsToolStripMenuItem,
            this.newClientToolStripMenuItem});
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.clientsToolStripMenuItem.Text = "Clients";
            // 
            // showClientsToolStripMenuItem
            // 
            this.showClientsToolStripMenuItem.Name = "showClientsToolStripMenuItem";
            this.showClientsToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.showClientsToolStripMenuItem.Text = "Show clients";
            this.showClientsToolStripMenuItem.Click += new System.EventHandler(this.ShowClientsToolStripMenuItem_Click);
            // 
            // newClientToolStripMenuItem
            // 
            this.newClientToolStripMenuItem.Name = "newClientToolStripMenuItem";
            this.newClientToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.newClientToolStripMenuItem.Text = "New client";
            this.newClientToolStripMenuItem.Click += new System.EventHandler(this.NewClientToolStripMenuItem_Click);
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showTransactionsToolStripMenuItem});
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            // 
            // showTransactionsToolStripMenuItem
            // 
            this.showTransactionsToolStripMenuItem.Name = "showTransactionsToolStripMenuItem";
            this.showTransactionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showTransactionsToolStripMenuItem.Text = "Show transactions";
            this.showTransactionsToolStripMenuItem.Click += new System.EventHandler(this.ShowTransactionsToolStripMenuItem_Click);
            // 
            // MoneyExchangeToolStripMenuItem
            // 
            this.MoneyExchangeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showExchangeRatesToolStripMenuItem,
            this.showCurrenciesToolStripMenuItem});
            this.MoneyExchangeToolStripMenuItem.Name = "MoneyExchangeToolStripMenuItem";
            this.MoneyExchangeToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.MoneyExchangeToolStripMenuItem.Text = "Money exchange";
            // 
            // showExchangeRatesToolStripMenuItem
            // 
            this.showExchangeRatesToolStripMenuItem.Name = "showExchangeRatesToolStripMenuItem";
            this.showExchangeRatesToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.showExchangeRatesToolStripMenuItem.Text = "Show exchange rates";
            this.showExchangeRatesToolStripMenuItem.Click += new System.EventHandler(this.ShowExchangeRatesToolStripMenuItem_Click);
            // 
            // showCurrenciesToolStripMenuItem
            // 
            this.showCurrenciesToolStripMenuItem.Name = "showCurrenciesToolStripMenuItem";
            this.showCurrenciesToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.showCurrenciesToolStripMenuItem.Text = "Show currencies";
            this.showCurrenciesToolStripMenuItem.Click += new System.EventHandler(this.ShowCurrenciesToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.izbornik);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.izbornik;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Main form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.izbornik.ResumeLayout(false);
            this.izbornik.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip izbornik;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MoneyExchangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showExchangeRatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showCurrenciesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newClientToolStripMenuItem;
    }
}

