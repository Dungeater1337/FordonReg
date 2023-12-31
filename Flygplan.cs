using System;
using System.Collections.Generic;

class Flygplan : Fordon{
    private string type;

    public Flygplan(int year, string color, string producer, string type) : base(year, color, producer){
        this.type = type;
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

    public string GetType(){
        return type; 
    }

    public void SetType(string t){
        type = t;
    }
}