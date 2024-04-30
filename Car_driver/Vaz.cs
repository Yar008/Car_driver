using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Vaz : Truck
{
    public void To_Str()
    {
        Console.WriteLine($"{this.Name} едет.");
    }
    public bool Move(int chance)
    {
        if (chance <= 50)
        {
            return true;
        }
        else { return false; }
    }
}
