using System;
class program{
    static void Main(){
        Console.Write("Digite um número: ");
        float Núm = float.Parse(Console.ReadLine());
        Console.WriteLine("O dobro de {0} é {1}.",Núm,Núm * 2f);
        Console.WriteLine("A terça parte de {0} é {1}.",Núm,Núm / 3f);
    }
}