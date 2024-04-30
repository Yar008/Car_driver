using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    public abstract class Vehicle
    {
    
    public int Speed
    { get; set; }

    public int Horses
    { get; set; }

    public int Wheel { get; set; }

    public string Name
    { get; set; }
    protected Vehicle(int speed, int horses, int wh_amm,string name)
    {
        Speed = speed;
        Horses = horses;
        Wheel = wh_amm;
        Name = name;
    }
    protected Vehicle() 
    {
        Speed = 0;
        Horses = 0;
        Wheel = 0;
    }
    public virtual void To_Str() {}
    public virtual bool Move(int chance)
    {
        if (chance <= 50)
        {
            return true;
        }
        else { return false; }
    }
}

