using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    public class Printer
    {
        public string namaprinter { get; set; }
        public virtual void Merek()
        {
            Console.WriteLine("Merek Printer: ");
        }
    }

    public class Epson : Printer
    {
        public override void Merek()
        {
            Console.WriteLine();
            Console.WriteLine("Epson display dimension : 10 * 11");
            Console.WriteLine("Epson Printer Printing....");
        }
    }

    public class Cannon : Printer
    {
        public override void Merek()
        {
            Console.WriteLine();
            Console.WriteLine("Cannon display dimension : 9.5 * 12");
            Console.WriteLine("Cannon Printer Printing....");
        }
    }

    public class LaserJett : Printer
    {
        public override void Merek()
        {
            Console.WriteLine();
            Console.WriteLine("LaserJett display dimension 12 * 12");
            Console.WriteLine("LaserJett Printer Printing....");
        }
    }
}

    

