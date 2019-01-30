using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_TT1_Matches
{
    class Matches
    {
        public string S { get; set; }

        public int checkn(int n)
        {
            try
            {
                if (n >= 1 && n <= Math.Pow(10, 9))
                {
                    S = "You enter number = " + n.ToString() + " is correct ";
                }
                else
                {
                   S = "Input number is not correct";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return n;
        }

        public int minmatches(int n)
        {
            return (int)((2 * n + 2 * Math.Round(Math.Sqrt(n))));
        }

    }
}