using System;
class program{
    static void Main(){
        Console.WriteLine("Digite dois números:");
        float número1 = float.Parse(Console.ReadLine());
        float número2 = float.Parse(Console.ReadLine());
        Console.Write("A soma entre {0} e {1} é {2}.",número1,número2,número1 + número2);
    }
}