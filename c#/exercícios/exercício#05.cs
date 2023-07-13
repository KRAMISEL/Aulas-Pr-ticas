using System;
class program{
    static void Main(){
        Console.WriteLine("Digite as duas notas do aluno:");
        float nota1 = float.Parse(Console.ReadLine());
        float nota2 = float.Parse(Console.ReadLine());
        Console.WriteLine("Nota 1: {0}.\nNota 2: {1}.\nA média de {2} e {3} é igual a {4}.",nota1,nota2,nota1,nota2,(nota1 + nota2) / 2);
    }
}