using System;
class program{
    static void Main(){
        Console.WriteLine("Me diga quantos Reais você tem. ");
        float Dinheiro = float.Parse(Console.ReadLine());
        Console.WriteLine("Você pode comprar {0} dólares com {1:c}.",Dinheiro / 3.45f,Dinheiro);
    }
}