using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods;
public class Car
{
    public int A { get; set; }

    public virtual void MakeMove()
    {
        Console.WriteLine("Car");
    }
}
