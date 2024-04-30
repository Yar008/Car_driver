using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Truck:Vehicle
{
    public int Capacity
    { get; set; }
    protected Truck() { }
    protected Truck(int capacity, int speed, int horses, int wh_amm, string name): base(speed, horses, wh_amm, name) { Capacity = capacity; }
    public  virtual void To_Str() { }
    public  bool Move(int chance)
    {
        if (chance <= 50)
        {
            return true;
        }
        else { return false; }
    }
}

