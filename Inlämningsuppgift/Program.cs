namespace Inlämningsuppgift


{
    class Program
    {
        public static void Main(string[] args)
        {
            MainMenu();
        }


        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to my shop" + "\n");
            Console.WriteLine("Option 1 Food Section");
            Console.WriteLine("Option 2 Drinks section");
            Console.WriteLine("Option 3 Clothes");
            Console.WriteLine("Option 4 Exit");
            Console.WriteLine("Please type 1, 2, 3 or 4 to navigate");
            string myoptions;
            myoptions = Console.ReadLine();
            try
            {
                //Beroende på användarens val kommer metod att kallas
                switch (myoptions)
                {
                    case "1":
                        Food();
                        break;

                    case "2":
                        Drink(20);
                        break;

                    case "3":
                        Cloth();
                        break;


                    case "4":
                        Exit();
                        break;
                }

                MainMenu();
                Console.ReadLine();
            }catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
        static void Food()
        {
            Console.WriteLine("Our delicous pizza made with care");
            Console.WriteLine("Food is 110kr");
            Console.WriteLine("Do you want to buy? Y for yes, N for no and you will go back to menu");
            String menuChoice= Console.ReadLine();
            try
            {
                //Om användaren matar in Y eller y, skickas det inmatade värdet till klassen Wallet -> metoden Payment
                if (menuChoice == "Y" || menuChoice == "y")
                {
                    Wallet wallet = new Wallet();
                    wallet.Payment(menuChoice);
                }

               
                //Annars om användaren matar in N eller n kommer programmet avslutas
                 else if (menuChoice == "N" || menuChoice == "n")
                {
                    MainMenu();
                }
            } catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
        static void Drink(int v)
        {


            Console.WriteLine("An ice cold Pepsi goes great with the food!");
            Console.WriteLine("Pepsi is 20kr");
            Console.WriteLine("Do you want to buy? Y for yes, N for no and you will go back to menu");
            String menuChoice = Console.ReadLine();
            try
            {
                //Om användaren matar in Y eller y, skickas det inmatade värdet till klassen Wallet -> metoden Payment
                if (menuChoice == "Y" || menuChoice == "y")
                {
                    Wallet wallet = new Wallet();
                    wallet.Payment(menuChoice);
                }
                //Annars om användaren matar in N eller n kommer programmet avslutas
                else if (menuChoice == "N" || menuChoice == "n")
                {
                    MainMenu();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }






        }

        static void Cloth()
        {
            Console.WriteLine("Our clothes are made from the highest quality material!");
            Console.WriteLine("Jacket are 200kr");
            Console.WriteLine("Do you want to buy? Y for yes, N for no and you will go back to menu");
            String menuChoice = Console.ReadLine();
            try
            {
                //Om användaren matar in Y eller y, skickas det inmatade värdet till klassen Wallet -> metoden Payment
                if (menuChoice == "Y" || menuChoice == "y")
                {
                    Wallet wallet = new Wallet();
                    wallet.Payment(menuChoice);
                }
                //Annars om användaren matar in N eller n kommer programmet avslutas
                else if (menuChoice == "N" || menuChoice == "n")
                {
                    MainMenu();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }

        static void Exit()
            // Användaren väljer att avsluta programmet
        {

            Console.WriteLine("Are you sure that you would like to leave the application?");
            Console.WriteLine("Press ENTER to confirm");
            Console.ReadLine();
            System.Environment.Exit(1);
            
        }
    }
}








