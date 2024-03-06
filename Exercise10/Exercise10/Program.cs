using System.Runtime.CompilerServices;

namespace Exercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("___________");
            Console.WriteLine("   Menu:");
            Console.WriteLine("1 - New Game");
            Console.WriteLine("2 - Load Game");
            Console.WriteLine("3 - Options");
            Console.WriteLine("4 - quit");
            Console.WriteLine("___________");

            int answer = int.Parse(Console.ReadLine());
            while (answer <= 0 || answer >= 5)
            {

                Console.WriteLine("wrong number pookie.");

                Console.WriteLine("___________");
                Console.WriteLine("   Menu:");
                Console.WriteLine("1 - New Game");
                Console.WriteLine("2 - Load Game");
                Console.WriteLine("3 - Options");
                Console.WriteLine("4 - quit");
                Console.WriteLine("___________");
                answer = int.Parse(Console.ReadLine());
                if (answer == 1)
                {

                Console.WriteLine("Starting New Game.....");


            }

                if (answer == 2)
                {

                    Console.WriteLine("Loading Game...");

                }
                if (answer == 3)
                {


                    Console.WriteLine("Opening Options..");

                }
                            if (answer == 4)
                        {

                            Console.WriteLine("Closing application...");

                           
                        }
                    
                
            
           

                

            }

            

        }

    }
}
  