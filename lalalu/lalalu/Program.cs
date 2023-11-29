using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lalalu
{
     class Program
    {
        static void Main(string[] args)
        {
            List<string> tärningsLista = new List<string>();
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("Var god skriv in en siffra mellan 1-6");
                Console.WriteLine("Skriv delete för att ta bort den första siffran i listan");
                Console.WriteLine("Skriv ingenting för att avsluta");
                string input = Console.ReadLine();
                if (input == "")
                {
                    isRunning = false;
                }
                else if (input == "delete")
                {
                    if(tärningsLista.Count > 0)
                    {
                        Console.WriteLine("Nu tar vi bort tärningsslaget " + tärningsLista[0] + " från listan");
                        tärningsLista.RemoveAt(0);

                    }
                    else
                    {
                        Console.WriteLine("Du måste spara något för att kunna ta bort det...");
                    }
                }
                else
                {
                    tärningsLista.Add(input);
                    Console.WriteLine("\nDu har sparat följande tärningar:");
                    foreach(string tärning in tärningsLista)
                    {
                        Console.WriteLine(tärning);
                    }

                 /*   for(int i = 0; i < tärningsLista.Count; i++)
                    {
                        Console.WriteLine(tärningsLista[i]);
                    }*/
                }
                Console.ReadLine();
            }
            Console.WriteLine("Tack för den här gången!");
        }   
    }
}
