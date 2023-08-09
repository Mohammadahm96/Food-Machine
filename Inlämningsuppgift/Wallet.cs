using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift
{
    class Wallet
    {
        public void Payment(String option)
        {
            Console.WriteLine("You have bought the product!");
            Console.WriteLine("Do you want to go back to menu or exit?");
            Console.WriteLine("Press E to exit, or M to go back to menu");
            String customerChoice = Console.ReadLine();
            try
            {
                //Om användaren matat in e eller E kommer programmet avslutas
                if (customerChoice == "e" || customerChoice == "E")
                {
                    Environment.Exit(1);
                }
                //Annars om användaren matat in E eller e, kommer användaren tar tillbaka till menuvalet
                else if (customerChoice == "E" || customerChoice == "e")
                {
                    Program.MainMenu();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

    }
  
}
