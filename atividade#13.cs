using System;
class program{
    static void Main(){
        Console.Write("Qual é o seu salário? ");
        double salário = double.Parse(Console.ReadLine());
        Console.WriteLine("O seu salário de R$" + salário + " receberá um aumento de 15% e passará a valer R$" + salário * 1.15);
    }
}