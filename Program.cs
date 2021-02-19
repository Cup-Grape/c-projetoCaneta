using System;

namespace P6exCaneta
{
    class Program
    {
        static void Main(string[] args)
        {
            int nv;
            string cr;
            double pt;

            Caneta obj = new Caneta();

            Console.Write("Nivel da tinta:");
            nv = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cor da tinta:");
            cr = Console.ReadLine();
            Console.Write("Espessura da ponta da caneta: ");
            pt = Convert.ToDouble(Console.ReadLine());

            obj.cor = cr;
            obj.ponta = pt;

            Console.WriteLine($"Ponta: {cr}  Ponta: {pt}");

            obj.tamparEdestampar();
            obj.rabiscar(nv);
            

        }
    }
}
