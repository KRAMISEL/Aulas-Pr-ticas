using System;
class program{
    static void Main(){
        Console.WriteLine("Digite as duas notas do aluno:");
        double nota1 = double.Parse(Console.ReadLine());
        double nota2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Nota 1: {0}.\nNota 2: {1}.\nA média de {2} e {3} é igual a {4}.",nota1,nota2,nota1,nota2,(nota1 + nota2) / 2);
    }
}