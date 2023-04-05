using System;
class program{
    static void Main(){
        Console.WriteLine("Me diga quantos Reais você tem. ");
        double Dinheiro = double.Parse(Console.ReadLine());
        Console.WriteLine("Você pode comprar D$" + Dinheiro * 0.29);
    }
}