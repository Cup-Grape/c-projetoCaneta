using System;

//Estrutura do objeto//
class Caneta
{

    //Atributos//
    public double ponta;
    public string cor;
    public bool tampa = true;
    protected int tintaQtde;
    //Atributos//


    //Métodos//
    public void rabiscar(int tintaQtde)
    {
        this.tintaQtde = tintaQtde;
        
        if(tampa == false)
        {
            if(tintaQtde >= 1)
            {
                Console.WriteLine($"A tinta está {tintaQtde}%");
                Console.WriteLine("A caneta está rabiscando..");
                Console.ReadLine();
            }
                
            else
            {
                Console.WriteLine("Tinta insuficiente!");
                Console.WriteLine($"Nivel da tinta: {tintaQtde}");
                Console.ReadLine();
            }

        }
        else
        {
            Console.WriteLine("A caneta está tampada");
            Console.WriteLine("Não é possivel rabiscar");
        }
    }


    public void tamparEdestampar()
    {
        int escolha;
        Console.WriteLine("Tampa da caneta: ");
        Console.WriteLine("(1) Tampado");
        Console.WriteLine("(2) Destampada");
        escolha = Convert.ToInt32(Console.ReadLine());

        if(escolha == 1)
        {
            tampa = true;
            Console.WriteLine("Caneta tampada");
        }

        if(escolha ==2)
        {
            tampa = false;
            Console.WriteLine("Destampada");
        }

        else
        {
            Console.WriteLine("Não conheço esse comando!");
        }
    }
    //Métodos//

}
//Estrutura do objeto//