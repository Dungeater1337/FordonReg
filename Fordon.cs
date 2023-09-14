using System;
using System.Collections.Generic;

class Fordon
{
    protected int year;
    protected string color;
    protected string producer;

    public Fordon(int year, string color, string producer){
        this.year = year;
        this.color = color;
        this.producer = producer;
    }

    public virtual int GetYear(){
        return 0;
    }

    public virtual string GetColor(){
        return "";
    }

    public virtual string GetProducer(){
        return "";
    }
}