using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solaris : Car
{
    public override void To_Str() 
    {
        Console.WriteLine($"{this.Name} едет.");
    }
    public override bool Move(int chance) 
    {
        if(chance <=50)
        {
            return true;
        }
        else { return false; }
    }
}
