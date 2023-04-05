using System;
class program{
    static void Main(){
        Console.WriteLine("Digite as duas notas do aluno:");
        double nota1 = double.Parse(Console.ReadLine());
        double nota2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Nota 1: " + nota1);
        Console.WriteLine("Nota 2: " + nota2);
        Console.WriteLine("A média entre " + nota1 + " e " + nota2 + " é igual a " + (nota1 + nota2) / 2);
    }
}