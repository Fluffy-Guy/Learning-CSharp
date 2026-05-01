using System;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace Game
{
    internal class Program
    {
        static void Main()
        {
           // hi, this is an unfinsed+scrapped project
          
            // player stats
            float playerHealth = 0; // avrg is 30
            float playerMana = 0; //avrg is 15
            float playerSpeed = 0; //avrg is 5
            float playerMeleeDamage = 0; //  avrg is 5
            float playerRangedDamage = 0; // avrg is 4
            float playerMagicDamage = 0; // avrg is 6

            byte playerClass = 0; // 1, 2, and 3
            float playerDamageMultipler = 0; // avrg is 1
            float playerLuckMultipler = 0; // avrg is 1

            if (playerClass == 1)
            {

            }
            else if (playerClass == 2)
            {

            }
            else if (playerClass == 3)
            {

            }



            // character setup
            // choosing username yo

            bool nameChosen = false;
            bool playerChosen = false;
            while (playerChosen == false)
                if (playerChosen == false)
                {
                    while (nameChosen == false)
                        if (nameChosen == false)
                        {
                            Console.Clear();
                            Console.WriteLine("Enter your name: \n");
                            string name = Console.ReadLine();
                            Console.WriteLine("are you sure you want '" + name + "' as your name? type 'yes' or 'no'.");
                            string proceedName = Console.ReadLine();
                            if (proceedName.ToLower() == "yes")
                            {
                                nameChosen = true;
                            }
                        }

                    // abbilites
                    bool classChosen = false;
                    while (classChosen == false)
                        if (classChosen == false)
                        {
                            Console.Clear();
                            string proceedClass;
                            Console.WriteLine("Now choose a player class, '1' for barbarian, '2' for archer, and '3' for wizard.\n\nBarbarian - x0.5% melee DMG & x0.5% HP\nArcher - x0.5% ranged DMG & x0.5% speed\nWizard - x0.5% magic DMG & x0.5% mana\n");
                            string @playerInput = Console.ReadLine();
                            if (@playerInput == "1")
                            {
                                playerClass = 1;
                                Console.WriteLine("are you sure you want to be a barbarian your class? type 'yes' or 'no'.");
                                proceedClass = Console.ReadLine();
                                if (proceedClass.ToLower() == "yes")
                                {
                                    classChosen = true;
                                }
                            }
                            else if (@playerInput == "2")
                            {
                                playerClass = 2;
                                Console.WriteLine("are you sure you want to be a archer your class? type 'yes' or 'no'.");
                                proceedClass = Console.ReadLine();
                                if (proceedClass.ToLower() == "yes")
                                {
                                    classChosen = true;
                                }
                            }
                            else if (@playerInput == "3")
                            {
                                playerClass = 3;
                                Console.WriteLine("are you sure you want to be a wizard your class? type 'yes' or 'no'.");
                                proceedClass = Console.ReadLine();
                                if (proceedClass.ToLower() == "yes")
                                {
                                    classChosen = true;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Error, try again");
                            }
                        }
                    Console.WriteLine(playerClass);
                    if (playerClass == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("You have selected barbarian, and the name '" + name + "', are you sure you want to continue? [type 'yes' or 'no')\n");
                        string proceedName = Console.ReadLine();
                        if (proceedName.ToLower() == "yes")
                        {
                            playerChosen = true;
                        }
                    }
                    else if (playerClass == 2)
                    {

                    }
                    else if (playerClass == 3)
                    {

                    }
                    else
                    {
                        Console.WriteLine("Error: player class broken?");
                    }
                    Console.WriteLine("You have selected barbarian, are you sure you want to continue ")

        }       }
    }
}
