using System;
using System.Collections.Generic;

class Cykel : Fordon{
    private string material;

    public Cykel(int year, string color, string producer, string material) : base(year, color, producer){
        this.material = material;
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

    public string GetMaterial(){
        return material; 
    }
}