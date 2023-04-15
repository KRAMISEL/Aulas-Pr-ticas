using System;
class program{
    static void Main(){
        Console.WriteLine("Digite as duas notas do aluno:");
        double nota1 = double.Parse(Console.ReadLine());
        double nota2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Nota 1: {0}",nota1);
        Console.WriteLine("Nota 2: {0}",nota2);
        Console.WriteLine("A média entre {0} e {1} é igual a {2}",nota1,nota2,(nota1+nota2)/2);
    }
}