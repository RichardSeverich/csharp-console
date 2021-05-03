using System;

using keyboard_game_core.src.main.org.jalafoundation.devint32.container;

namespace keyboard_game_console.src.main.org.jalafoundation.devint32.print
{
    internal class PrintKeyDetails
    {
        private static ContainerList container = ContainerList.GetInstance();

        private PrintKeyDetails()
        {
        }

        internal static void ShowDetails()
        {
            Console.Clear();
            Console.WriteLine("Name\t\tTotal Keyed\t\tTotal Combined");
            for (int i = 0; i < container.keyboardlist.Count; i++)
            {
                if (
                       container.normalKeys.Contains(container.keyboardlist[i]) &&
                       container.keyedCombined.ContainsKey(container.keyboardlist[i])
                   )
                {
                    Console.WriteLine(
                                        $"{container.keyboardlist[i]}\t\t"+
                                        $"{container.keyedCombined[container.keyboardlist[i]][0]}\t\t\t"+
                                        $"{container.keyedCombined[container.keyboardlist[i]][1]}"
                                     );
                }
                else if (container.specialKeys.Contains(container.keyboardlist[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(container.keyboardlist[i]);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"\t\t{0}\t\t\t{0}");
                }
                else if (container.functionalKeys.Contains(container.keyboardlist[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(container.keyboardlist[i]);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(
                                         $"\t\t{container.keyedCombined[container.keyboardlist[i]][0]}" +
                                         $"\t\t\t{container.keyedCombined[container.keyboardlist[i]][1]}"
                                     );
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n(Press any key to return to Main Menu)");
            Console.ReadKey(true);
        }
    }
}
