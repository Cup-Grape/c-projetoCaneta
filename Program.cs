using System;

namespace P6exCaneta
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variaveis
            int nv;
            string cr;
            double pt;
            //Variaveis

            //Chamando o obj Caneta
            Caneta obj = new Caneta();
            //Chamando o obj Caneta


            Console.Write("Nivel da tinta:");
            nv = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cor da tinta:");
            cr = Console.ReadLine();
            Console.Write("Espessura da ponta da caneta: ");
            pt = Convert.ToDouble(Console.ReadLine());

            //Chamando os atributos privados
            obj.Cor = cr;
            obj.Ponta = pt;
            //Chamando os atributos privados


            //Limpa o console
            Console.Clear();

            //Apresentação
            Console.WriteLine($"Cor: {obj.Cor}");
            Console.WriteLine($"Ponta: {obj.Ponta}");
            Console.WriteLine($"Nivel da tinta: {nv}");
            //Apresentação

            //Chamando os métodos
            obj.tamparEdestampar();
            obj.rabiscar(nv);
            //Chamando os métodos

        }
    }
}
