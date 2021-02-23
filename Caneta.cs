using System;

//Estrutura do objeto//
class Caneta
{

    //Atributos//
    private double ponta;
    private string cor;
    private bool tampa = true;
    private int tintaQtde = 100;
    //Atributos//

    

    //Get e Set

    //Atributo ponta
    public double Ponta
    {
        get{return ponta;}
        set{ponta = value;}
    }

    //Atibuto Cor
    public string Cor
    {
        get{return cor;}
        set{cor = value;}
    }
   
   //Atibuto quantidade de tinta
    public int TintaQtde
    {
        get{return tintaQtde;}
        set{tintaQtde = value;}
    }
    //Get e set



    //Métodos//


    //Método rabiscar
    public void rabiscar()
    {
        
        //Se a tampa estiver fora da caneta
        if(tampa == false)
        {
            //Confere se a tinta está ok
            if(tintaQtde >= 10)
            {
                Console.WriteLine("A caneta está liberada para rabiscar");
                Console.ReadLine();

                //Calculo para gastar tinta
                int calc;
                calc = tintaQtde - 10;
                tintaQtde = calc;
                //_________________________

                Console.WriteLine("Rabiscando...");
                Console.WriteLine("Saindo tinta");
                Console.ReadLine();
            }
            //____________________________

            //Tinta não está ok    
            if(tintaQtde <= 0)
            {
                Console.WriteLine("Rabiscando...");
                Console.WriteLine("Não está saindo tinta");
                Console.WriteLine($"{tintaQtde}%");
                Console.ReadLine();
            }
            //____________________________

        }
        //________________________________

        //Se a tampa estiver na caneta
        else
        {
            Console.WriteLine("A caneta está tampada");
            Console.WriteLine("Não é possivel rabiscar");
        }
        //Se a tampa estiver na caneta

    }
    //Método rabiscar


    //Método tampar e destampar
    public void tamparEdestampar()
    {
        //escolhe se quer a caneta tampada ou destampada
        int escolha;
        Console.WriteLine("Tampa da caneta: ");
        Console.WriteLine("(1) Tampado");
        Console.WriteLine("(2) Destampada");
        escolha = Convert.ToInt32(Console.ReadLine());
        //__________________________________

        //Escolha 1 Caneta tampada
        if(escolha == 1)
        {
            tampa = true;
            Console.WriteLine("Caneta tampada");
        }
        //__________________________________
        //Escolha 2 Caneta destampada
        if(escolha ==2)
        {
            tampa = false;
            Console.WriteLine("Destampada");
        }
        //__________________________________

        //Não conheço o comando
        else
        {
            Console.WriteLine("Não conheço esse comando!");
        }
        //__________________________________
    }
    //Método tampar e destampar


    //Métodos//

}
//Estrutura do objeto//