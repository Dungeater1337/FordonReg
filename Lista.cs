using System;
using System.Collections.Generic;

class Lista
{
    List<Fordon> create = new List<Fordon>();

    public void Create()
    {
        Console.WriteLine("|==Vilket typ av fordon?==|");
        Console.WriteLine("1. Bil");
        Console.WriteLine("2. Cykel");
        Console.WriteLine("3. Flygplan");
        int anw = int.Parse(Console.ReadLine());   

        switch(anw)
        {
            case 1: 
             Console.WriteLine("\n");
             Console.WriteLine("Vilket år: ");
             int year = int.Parse(Console.ReadLine());
             Console.WriteLine("Vilken färg: ");
             string color = Console.ReadLine();
             Console.WriteLine("Vilken tillverkare: ");
             string producer = Console.ReadLine();
             Console.WriteLine("Vilken modell: ");
             string modell = Console.ReadLine();
             Console.WriteLine("\n");

             Bil NewCar = new Bil(year, color, producer, modell);
             create.Add(NewCar);
            break;

            case 2: 
             Console.WriteLine("\n");
             Console.WriteLine("Vilket år: ");
             int y = int.Parse(Console.ReadLine());
             Console.WriteLine("Vilken färg: ");
             string c = Console.ReadLine();
             Console.WriteLine("Vilken tillverkare: ");
             string p = Console.ReadLine();
             Console.WriteLine("Vilket material har cykelen: ");
             string material = Console.ReadLine();
             Console.WriteLine("\n");

             Cykel NewBike = new Cykel(y, c, p, material);
             create.Add(NewBike);
            break;

            case 3: 
             Console.WriteLine("\n");
             Console.WriteLine("Vilket år: ");
             int ye = int.Parse(Console.ReadLine());
             Console.WriteLine("Vilken färg: ");
             string co = Console.ReadLine();
             Console.WriteLine("Vilken tillverkare: ");
             string pr = Console.ReadLine();
             Console.WriteLine("Vilket typ av flygplan: ");
             string type = Console.ReadLine();
             Console.WriteLine("\n");

             Flygplan NewAirplane = new Flygplan(ye, co, pr, type);
             create.Add(NewAirplane);
            break;

            default:
            Console.WriteLine("Ange ett giltigt val!");
            break;
        }     
    }

    public void WriteOut()
    {
        foreach(var fordon in create)
        {
            if(fordon is Bil bil)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($"År: {fordon.GetYear()}");
                Console.WriteLine($"Färg: {fordon.GetColor()}");
                Console.WriteLine($"Tillverkare: {fordon.GetProducer()}");
                Console.WriteLine($"Modell: {bil.GetModell()}");
                Console.WriteLine("---------------------------------------");
            }

            else if(fordon is Cykel cykel)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($"År: {fordon.GetYear()}");
                Console.WriteLine($"Färg: {fordon.GetColor()}");
                Console.WriteLine($"Tillverkare: {fordon.GetProducer()}");
                Console.WriteLine($"Cykel: {cykel.GetMaterial()}");
                Console.WriteLine("---------------------------------------");
            }

            else if(fordon is Flygplan flygplan)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($"År: {fordon.GetYear()}");
                Console.WriteLine($"Färg: {fordon.GetColor()}");
                Console.WriteLine($"Tillverkare: {fordon.GetProducer()}");
                Console.WriteLine($"Flyplan: {flygplan.GetType()}");
                Console.WriteLine("---------------------------------------");
            }

            else{
                Console.WriteLine("-------------");
                Console.WriteLine("Okänt fordon.");
                Console.WriteLine("-------------");
            }
        }
    }
}


