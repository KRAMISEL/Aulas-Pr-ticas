using System;
class program{
    static void Main(){
        Console.Write("Qual é o nome do fucionário? ");
        string nome = Console.ReadLine();
        Console.Write("Qual é o seu salário? ");
        double salário = double.Parse(Console.ReadLine());
        Console.WriteLine("O fucionário " + nome + " tem um salário de R$" + salário + " em março.");
        Console.WriteLine("O fucionário {0} tem um salário de R${1} em março.",nome,salário);
    }
}