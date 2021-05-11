using System;
using System.Collections.Generic;

namespace KeyboardGameConsole.Src.Print.PrintKeyDetails
{
    internal class PrintDetail
    {
        private static PrintKeyDetailNormalKey printNormal = new PrintKeyDetailNormalKey();
        private static PrintKeyDetailSpecialKey printSpecial = new PrintKeyDetailSpecialKey();
        private static PrintKeyDetailFunctionalKey printFunctional = new PrintKeyDetailFunctionalKey();
        internal static List<IPrint> printKeyDetailList = new List<IPrint>() { printNormal, printSpecial, printFunctional };

        private PrintDetail()
        {
        }

        internal static void Details()
        {
            Console.Clear();
            Console.WriteLine("Name\t\tTotal Keyed\tTotal Combined");
            foreach (var printKey in printKeyDetailList)
            {
                printKey.Print();
            }
            Console.WriteLine("\n(Press any key to return to Main Menu)");
            Console.ReadKey(true);
        }
    }
}
