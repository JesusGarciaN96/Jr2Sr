using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC_.TODOApp
{
    public class TODO
    {
        public static void showMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("Hello!");
            Console.WriteLine("[S]ee all TODOs");
            Console.WriteLine("[A]dd a TODO");
            Console.WriteLine("[R]emove a TODO");
            Console.WriteLine("[E]xit TODO");

            string option = Console.ReadLine();
            
            if(option != null)
            {
                char[] optionItem = option.ToUpper().ToCharArray();
                if(optionItem.Length > 0)
                    optionSelected(optionItem[0]);
                else
                    optionSelected('#');
            }
            else
                optionSelected('#');
        }

        private static void optionSelected(char option)
        {
            if (option.Equals((char)Options.SEE))
            {
                Console.WriteLine("See all TODOs");
                showMenu();
            }
            else if (option.Equals((char)Options.ADD))
            {
                Console.WriteLine("Add item to TODO");
                showMenu();
            }
            else if (option.Equals((char)Options.REMOVE))
            {
                Console.WriteLine("Remove item from TODO");
                showMenu();
            }
            else if (option.Equals((char)Options.EXIT))
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("The option is not exist!");
                showMenu();
            }
        }
    }
}
