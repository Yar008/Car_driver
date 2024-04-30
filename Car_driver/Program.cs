using Microsoft.VisualBasic.FileIO;
using System;
class Program
{ 
    static void Main(string[] args)
    {
       Vaz vaz = new Vaz();
       vaz.Name = "ВАЗ2107";
       Kamaz kamaz = new Kamaz();
        kamaz.Name = "КАМАЗ-2";
        Rio rio = new Rio();
        rio.Name = "Kia rio";
        Solaris solaris = new Solaris();
        solaris.Name = "Hyindai solaris";
        Random rnd = new Random();
        if (vaz.Move(rnd.Next(0,101)))
        {
            solaris.To_Str();
        }
        else
        {
            Console.WriteLine("Поломка");
            
        }
      
    }
}
