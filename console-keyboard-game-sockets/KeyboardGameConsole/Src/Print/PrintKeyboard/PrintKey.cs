using System;

using System.Collections.Generic;

namespace KeyboardGameConsole.Src.Print.PrintKeyboard
{
    internal class PrintKey
    {
        private static PrintKeyboardNormalKey printNormal = new PrintKeyboardNormalKey();
        private static PrintKeyboardSpecialKey printSpecial = new PrintKeyboardSpecialKey();
        private static PrintKeyboardFunctionalKey printFunctional = new PrintKeyboardFunctionalKey();
        internal static List<IPrint> printKeysList = new List<IPrint>() { printNormal, printSpecial, printFunctional };

        private PrintKey()
        {
        }

        internal static void PrintKeyboard()
        {
            foreach (var printKey in printKeysList)
            {
                printKey.Print();
            }
        }
    }
}
