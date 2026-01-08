using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public static class IbanGenerator
    {
        public static string GenerateIBAN()
        {
            string iban = "HR";
            Random r = new Random();
            for (int i = 0; i < 14; i++)
            {
                iban += r.Next(0, 9);
            }

            return iban;
        }
    }
}
