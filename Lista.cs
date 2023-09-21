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
                Console.WriteLine($"År: {bil.GetYear()}");
                Console.WriteLine($"Färg: {bil.GetColor()}");
                Console.WriteLine($"Tillverkare: {bil.GetProducer()}");
                Console.WriteLine($"Modell: {bil.GetModell()}");
                Console.WriteLine("---------------------------------------");
            }

            else if(fordon is Cykel cykel)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($"År: {cykel.GetYear()}");
                Console.WriteLine($"Färg: {cykel.GetColor()}");
                Console.WriteLine($"Tillverkare: {cykel.GetProducer()}");
                Console.WriteLine($"Cykel: {cykel.GetMaterial()}");
                Console.WriteLine("---------------------------------------");
            }

            else if(fordon is Flygplan flygplan)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($"År: {flygplan.GetYear()}");
                Console.WriteLine($"Färg: {flygplan.GetColor()}");
                Console.WriteLine($"Tillverkare: {flygplan.GetProducer()}");
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

    public void Edit()
    {
        Console.WriteLine("Välj vilket Objekt vill du redigera");
        int selectedIndex = int.Parse(Console.ReadLine()); 
        if(create[selectedIndex] is Bil)
        {
            Bil bil = (Bil)create[selectedIndex];
            Console.WriteLine($"Nuvarande modell: {bil.GetModell()}");
            Console.WriteLine("Ange ny modell:");
            string newModell = Console.ReadLine();
            bil.SetModell(newModell);

            Console.WriteLine($"Nuvarande år: {bil.GetYear()}");
            Console.WriteLine("Ange ett nytt år:");
            int newYear = int.Parse(Console.ReadLine());
            bil.SetYear(newYear);

            Console.WriteLine($"Nuvarande färg: {bil.GetColor()}");
            Console.WriteLine("Ange ny färg:");
            string newColor = Console.ReadLine();
            bil.SetColor(newColor);

            Console.WriteLine($"Nuvarande tillverkare: {bil.GetProducer()}");
            Console.WriteLine("Ange nu tillverkare:");
            string newProducer = Console.ReadLine();
            bil.SetProducer(newProducer);
            
        }

        if(create[selectedIndex] is Cykel)
        {
             Cykel cykel = (Cykel)create[selectedIndex];
            Console.WriteLine($"Nuvarande modell: {cykel.GetMaterial()}");
            Console.WriteLine("Ange ny modell:");
            string newMaterial = Console.ReadLine();
            cykel.SetMaterial(newMaterial);

            Console.WriteLine($"Nuvarande år: {cykel.GetYear()}");
            Console.WriteLine("Ange ett nytt år:");
            int newYear = int.Parse(Console.ReadLine());
            cykel.SetYear(newYear);

            Console.WriteLine($"Nuvarande färg: {cykel.GetColor()}");
            Console.WriteLine("Ange ny färg:");
            string newColor = Console.ReadLine();
            cykel.SetColor(newColor);

            Console.WriteLine($"Nuvarande tillverkare: {cykel.GetProducer()}");
            Console.WriteLine("Ange nu tillverkare:");
            string newProducer = Console.ReadLine();
            cykel.SetProducer(newProducer);
        }

        if(create[selectedIndex] is Flygplan)
        {
             Flygplan flygplan = (Flygplan)create[selectedIndex];
            Console.WriteLine($"Nuvarande modell: {flygplan.GetType()}");
            Console.WriteLine("Ange ny modell:");
            string newType = Console.ReadLine();
            flygplan.SetType(newType);

            Console.WriteLine($"Nuvarande år: {flygplan.GetYear()}");
            Console.WriteLine("Ange ett nytt år:");
            int newYear = int.Parse(Console.ReadLine());
            flygplan.SetYear(newYear);

            Console.WriteLine($"Nuvarande färg: {flygplan.GetColor()}");
            Console.WriteLine("Ange ny färg:");
            string newColor = Console.ReadLine();
            flygplan.SetColor(newColor);

            Console.WriteLine($"Nuvarande tillverkare: {flygplan.GetProducer()}");
            Console.WriteLine("Ange nu tillverkare:");
            string newProducer = Console.ReadLine();
            flygplan.SetProducer(newProducer);
        }
    }
}


