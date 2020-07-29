using System;

namespace plusmoins
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaration de variable
            
            int givenNbr = 0;
            int tries = 0;
            Random rand = new Random();
            int toBeFound = rand.Next(100);
                        
            // try-catch
            try
            {
                //do-while loop
                do
                {
                    Console.WriteLine("Entrez votre nombre");
                    givenNbr = int.Parse(Console.ReadLine());

                    if (givenNbr < toBeFound){
                        Console.WriteLine("Trop petit");
                    }else if(givenNbr > toBeFound){
                        Console.WriteLine("trop grand");
                    }
                    else{
                        Console.WriteLine("BRAVO");
                        Console.WriteLine("Nombre de tentatives: " + tries);
                    }

                    tries++;
                } while (givenNbr != toBeFound);
            }
            catch (Exception e)
            {
                Console.WriteLine("Le nombre choisi n'est pas un entier \n" + e);
            }
           
            Console.ReadKey();
        }
    }
}
