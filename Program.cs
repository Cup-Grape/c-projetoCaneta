using System;

namespace P6exCaneta
{
    class Program
    {
        static void Main(string[] args)
        {
            int nv;
            string cr;
            Caneta obj = new Caneta();
            Console.Write("Nivel da tinta:");
            nv = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cor da tinta:");
            cr = Console.ReadLine();
            obj.rabiscar(nv, cr);

        }
    }
}
