using System;

namespace Queue
{
    class QueueTestProgram
    {
        //Marco Picchillo - HND Software Dev. - 2018/2019 - West Lothian College
        static void Main(string[] args)
        {         
            Queue myQueue = new Queue();
            //string menuChoice;
            ConsoleKeyInfo menuChoice;

            Console.Title = "MARCO PICCHILLO - HND SOFTWARE DEV. - WEST LOTHIAN COLLEGE"; //Sets Console Title Property.
            Console.WriteLine("Welcome to the Queue Test Program.\nThe Queue is empty.\nWhat do you want to do?");
            do
            {
                displayMenu(); //Displays the Menu.
                Console.Write("\t Enter your choice: ");
                menuChoice = Console.ReadKey();
                //menuChoice.ToUpper();
                switch (menuChoice.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        {
                            //Displaying the Queue
                            Console.WriteLine("\n\n\t\tThe Queue Contains:\n");
                            myQueue.displayQueue(myQueue.firstNode);                            
                            break;
                        }
                    case ConsoleKey.NumPad2:
                    case ConsoleKey.D2:
                        {
                            //Adding Element to the Queue
                            Console.Write("\n\t Please insert an integer number: ");
                            try
                            {
                                int newElement = int.Parse(Console.ReadLine());
                                myQueue.enQueue(newElement);
                            }
                            catch
                            {
                                Console.WriteLine("\n\n\t You have inserted an invalid value!");                                
                            }
                            break;
                        }
                    case ConsoleKey.NumPad3:
                    case ConsoleKey.D3:
                        {
                            //Removing an element fron the Queue
                            Node removedNode = myQueue.deQueue();
                            if (removedNode != null)
                                Console.WriteLine("\n\n\t\t The removed element is: {0}", removedNode.Value);                            
                            break;
                        }                    
                    case ConsoleKey.NumPad5:
                    case ConsoleKey.D5:
                        {
                            //Close the program
                            Console.WriteLine("\n\n\t The program will be terminated.\n\t Press any key to continue..");                            
                            break;
                        }
                    default:
                        {                            
                            Console.WriteLine("\n\n\t You have entered an invalid option! Press any key to reload the menu..");                            
                            break;
                        }
                }
                Console.Write("\n\n\t Press any key to continue..");
                Console.ReadKey();
                Console.Clear();
            } while (menuChoice.Key != ConsoleKey.NumPad5 && menuChoice.Key != ConsoleKey.D5);

        }

        static public void displayMenu() //Display Menu
        {
            Console.WriteLine("\n\t \\* MARCO PICCHILLO - HND SOFTWARE DEV. - WEST LOTHIAN COLLEGE */\n");
            System.Console.WriteLine("\t MENU:\n");
            System.Console.WriteLine("\t 1. Display Queue\n" +
                                     "\t 2. Add Element\n" +
                                     "\t 3. Remove Element\n\n" +                                     
                                     "\t 5. Terminate Program\n\t ");
        }

    }
    
}