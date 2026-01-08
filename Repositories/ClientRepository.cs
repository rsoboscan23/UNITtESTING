using Entities.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ClientRepository : Repository<IClient>
    {
        protected override void InitializeItems()
        {
            base.InitializeItems();

            items = new List<IClient>()
            {
                new BasicClient("11111111111", "Pero", "Perić"),
                new BasicClient("22222222222", "Ivana", "Lukić"),
                new BasicClient("33333333333", "Luka", "Novak"),
                new BasicClient("44444444444", "Marko", "Horvat"),
                new BasicClient("55555555555", "Marija", "Perić"),
                new PremiumClient("66666666666", "Alfa d.o.o.", "Davor", "Majić"),
                new PremiumClient("77777777777", "Beta d.o.o.", "Ivan", "Ivić"),
                new PremiumClient("88888888888", "Gama d.o.o.", "Petar", "Petrić"),
                new PremiumClient("99999999999", "Delta d.o.o.", "Ana", "Anić"),
                new PremiumClient("10000000000", "Omega d.o.o.", "Igor", "Lukić")
            };


        }

        public IClient GetByOIB(string oib)
        {
            return items.FirstOrDefault(k => k.OIB == oib);
        }
    }
}
