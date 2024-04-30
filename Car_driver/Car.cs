using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
public abstract class Car: Vehicle
{
    public  int Sit_ammo
    { get; set; }
    protected Car() : base() {}
    protected Car(int sit_ammo,int speed, int horses, int wh_amm, string name) : base(speed, horses, wh_amm, name) {Sit_ammo = sit_ammo; }
    public override void To_Str() { }
    public override bool Move(int chance)
    {
        if (chance <= 50)
        {
            return true;
        }
        else { return false; }
    }

}

