namespace polymorphism
{
    public class Program
    {
        static void Main(string[] args)
        {
            Printer Printer = new Printer();
            Console.WriteLine("Pilih printer: ");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Cannon");
            Console.WriteLine("3. LaserJett");
            Console.WriteLine();
            Console.WriteLine("Nomor printer [1/2/3]: ");

            Printer Epson = new Epson();
            Printer Cannon = new Cannon();
            Printer LaserJett = new LaserJett();

            int nomorprinter = Convert.ToInt32(Console.ReadLine());

            if (nomorprinter == 1)
            {
                Epson.Merek();
            }
            else if (nomorprinter == 2)
            {
                Cannon.Merek();
            }
            else if (nomorprinter == 3)
            {
                LaserJett.Merek();
            }
            else
                Console.WriteLine("Nomor printer tidak valid!");

            Console.ReadKey();
        }
    }
}