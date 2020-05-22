﻿using System;
 using System.Linq;
 using System.Text;

 namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print each of the statistical output using Text Table with padding 3:
            // - FindHighestBalanceEver
            // - FindPersonWithBiggestLoss
            // - FindRichestPerson
            // - FindMostPoorPerson

            var balance = PeoplesBalances.Balances;
            foreach (var i in balance)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
