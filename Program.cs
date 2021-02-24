using System;

namespace P6exCaneta
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variaveis
            string cr;
            double pt;
            //Variaveis

            //Chamando o obj Caneta
            Caneta obj = new Caneta();
            //Chamando o obj Caneta


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
            Console.WriteLine($"Nivel da tinta: {obj.TintaQtde}");
            //Apresentação

            //Chamando os métodos
            obj.tamparEdestampar();

            //Menu
            bool menu = true;

            while(menu)
            {
                Console.Clear();
                int escolha;
                Console.WriteLine($"(1) Rabiscar gasta 10% da tinta ({obj.TintaQtde})");
                Console.WriteLine($"(2) Deixar a caneta");
                Console.Write($"Escolha: ");
                escolha = Convert.ToInt32(Console.ReadLine());

                //Escolha 1 rabiscar
                if(escolha == 1)
                {
                    obj.rabiscar();
                }
                //__________________________

                //Escolha 2 sair do programa
                if(escolha == 2)
                {
                    Console.WriteLine("Caneta jogada na mesa");
                    Console.WriteLine("...");
                    menu = false;
                }
                //___________________________

                //se usar um comando diferente
                if(escolha != 1 && escolha != 2 )
                {
                    Console.WriteLine("Não conheço esse comando!");
                    Console.ReadLine();
                }
                //____________________________

            }
            //Menu___________________
            
            //Chamando os métodos


        }
    }
}
