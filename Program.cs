using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args) 
    {
        int anw = 1;
        Lista fordon = new Lista();
        while(anw != 4){
            
            Console.WriteLine("\n");
            Console.WriteLine("|=====FordonRegister=====|");
            Console.WriteLine("1. Skriv in ett fordon.");
            Console.WriteLine("2. Visa registret.");
            Console.WriteLine("3. Redigera objekt.");
            Console.WriteLine("4. Avsluta Programmet.");
            Console.WriteLine("\n");
            
            anw = int.Parse(Console.ReadLine());
            if(anw == 1){
                Console.WriteLine("\n");
                fordon.Create();
            }

            else if(anw == 2){
                Console.WriteLine("\n");
                fordon.WriteOut();
            }

            else if(anw == 3){
                Console.WriteLine("\n");
                fordon.Edit();
            }

            else{
                Console.WriteLine("Välj ett giltigt alternativ!"); 
            }
        }
    }
}