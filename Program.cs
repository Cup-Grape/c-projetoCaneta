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
            obj.rabiscar();
            //Chamando os métodos

            //usando a caneta
            if(obj.Qdc == true)
            {
                //Variaveis
                int tintalc;
                bool menu = true;
                int escolha;
                //Variaveis

                //Menu
                while(menu == true)
                {
                    Console.WriteLine($"(1) Rabiscar (- 10 da tinta) Quantidade da tinta : {obj.TintaQtde}%");
                    Console.WriteLine("(2) Fechar caneta");
                    Console.Write("Escolha: ");
                    escolha = Convert.ToInt32(Console.ReadLine());

                    //escolha 1 rabiscar
                    if(escolha == 1)
                    {
                        //Calculo da tinta
                        tintalc = obj.TintaQtde - 10;
                        obj.TintaQtde = tintalc;
                        //____________________________

                        //opção se tiver tinta
                        if(obj.TintaQtde >= 1)
                        {
                            Console.WriteLine($"Rabiscando {obj.TintaQtde}" );
                        }
                        //_____________________________

                        //se não tiver tinta
                        if(obj.TintaQtde <= 0)
                        {
                            Console.WriteLine("A tinta acabou!!");
                            Console.ReadLine();
                            escolha = 2;
                        }
                        //_____________________________


                    }
                    //Escolha 1 rabiscar

                    //Escolha 2 sair do programa
                    if(escolha == 2)
                    {
                        Console.WriteLine("Caneta fechada");
                        menu = false;
                        Console.ReadLine();
                    }
                    //Escolha 2 sair do programa

                    //Comando não identificado
                    else
                    {
                        Console.WriteLine("Não conheço esse comando!");
                        Console.ReadLine();
                    }
                    //Comando não identificado

                }

            }
            //usando a caneta

            //caneta não liberada
            if(obj.Qdc == false)
            {
                Console.WriteLine("Saindo");
                Console.ReadLine();
            }
            //caneta não liberada

        }
    }
}
