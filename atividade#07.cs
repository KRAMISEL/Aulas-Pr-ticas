using System;
class program{
    static void Main(){
        Console.Write("Digite um número: ");
        double Núm = double.Parse(Console.ReadLine());
        Console.WriteLine("O dobro de {0} é {1}.",Núm,Núm * 2);
        Console.WriteLine("A terça parte de {0} é {1}.",Núm,Núm / 3);
    }
}