using System;

class Caneta
{
    public double ponta;
    public string cor;
    public string tampa;
    protected int tinta;

    public void rabiscar(int tinta, string cor)
    {
        this.tinta = tinta;
        this.cor = cor;
        if(tinta >= 1)
        {
            Console.WriteLine($"A tinta está {tinta}%");
            Console.WriteLine($"Rabiscando, cor {cor}");
            Console.ReadLine();
        }
        
        else
        {
            Console.WriteLine("Tinta insuficiente!");
            Console.WriteLine($"Nivel da tinta: {tinta}");
            Console.ReadLine();
        }

    }

    public void tamparEdestampar()
    {

    }



}