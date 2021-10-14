
using System;

namespace Week7Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab kasutasjale hommikusööki menüüd
            //programm palub kasjutajal teha valikut
            //programm kuvab kasutaja valikut konsoolis

            string[] menu = {"Omlett", "Pancakes", "Boiled Eggs", "4-vilja Porege", "Sandwitch"};
            Console.WriteLine($"Our menu has {menu.Length} choises.");
           // menu[3] = "Kaera Porege";
           // menu[4] = "Cheese Sandwitch";
            Console.WriteLine("In todays menu:");
            for(int i = 0; i < menu.Length; i++)
            {
                if (menu[i] == "4-villja porege")
                {
                    menu[i] = "kaera porege";
                }
                else if (menu[i] == "Sandwich")
                {
                    menu[i] = "Cheese Sandwich";
                }
                Console.WriteLine(menu[i]);
                
            }
            Console.WriteLine("Please make your choise (Enter numbers 1 to 5)");
            int userChoice = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine($"You have chosen {menu[userChoice]}");
            // foreach(string menuElement in menu)
             //{
                
              //Console.WriteLine(menuElement);

            // }
        }

    }
}
