using System;
class program{
    static void Main(){
        Console.Write("Qual é o nome do fucionário? ");
        string nome = Console.ReadLine();
        Console.Write("Qual é o seu salário? ");
        float salário = float.Parse(Console.ReadLine());
        Console.WriteLine("O fucionário {0} tem um salário de {1:C} em março.",nome,salário);
    }
}