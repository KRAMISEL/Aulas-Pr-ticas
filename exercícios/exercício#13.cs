using System;
class program{
    static void Main(){
        Console.Write("Qual é o seu salário? ");
        float salário = float.Parse(Console.ReadLine());
        Console.WriteLine("O seu salário de {0:c} receberá um aumento de 15% e passará a valer {1:c}",salário,salário * 1.15f);
    }
}