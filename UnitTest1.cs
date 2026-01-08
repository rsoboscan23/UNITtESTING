using BusinessLayer;
using BusinessLayer.Exceptions;
using Entities.Accounts;
using Entities.Clients;
using Entities.Exchange;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testovi
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Konstruktor_InicijalizacijaCurrency_VrijednostJeCZKiSvojstvoCeska()
        {
            //Arange
            var currency = new Currency("CZK", "Česka");
            //Act

            //Assert
            Assert.AreEqual("CZK", currency.Code);
            Assert.AreEqual("Česka", currency.Country);
        }

        [TestMethod]
        public void Konstruktor_InicijalizacijaForeginAccount_Balanceje1000SUplatom250DepositJe1250()
        {
            var currency = new Currency("CZK", "Česka");
            IClient owner = new BasicClient("HRK111", "Lovro", "Lovrić");
            var faccount = new ForeignAccount("HRK112", 1000, currency, owner);

            faccount.Deposit(250);

            Assert.AreEqual(1250, faccount.Balance);

        }

        [TestMethod]
        public void ClientService_UpsatePremiumClient_SProslijeđenomNullVrijednoscuDogadaSeClientExceptionKojiSadržiPoruku()
        {
            var service = new ClientService();

            try
            {
                service.UpdatePremiumClient(null, "12345678901", "Test Company", "Ime", "Prezime");
         
            }
            catch (ClientException ex)
            {
                Assert.AreEqual("Client is not provided!", ex.Message);
            }
        }

        /*[TestMethod]
        [ExpectedException(typeof(ClientException))]
        public void UpdatePremiumClient_NullClient_ThrowsClientException()
        {
            var service = new ClientService();

            service.UpdatePremiumClient(
                null,
                "11111111111",
                "Firma",
                "Pero",
                "Perić"
            );
        }*/

        [TestMethod]
        public void UpdateBasicClient() 
        {


        }
}
