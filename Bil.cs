using System;
using System.Collections.Generic;

class Bil : Fordon{
    private string modell;

    public Bil(int year, string color, string producer, string modell) : base(year, color, producer){
        this.modell = modell;
    }

    public override int GetYear()
    {
        return year;
    }

    public override string GetColor()
    {
        return color;
    }

    public override string GetProducer()
    {
        return producer;
    }

    public string GetModell(){
        return modell; 
    }
}