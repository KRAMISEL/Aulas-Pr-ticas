using System;
class program{
    static void Main(){
        Console.WriteLine("Digite dois números:");
        double número1 = double.Parse(Console.ReadLine());
        double número2 = double.Parse(Console.ReadLine());
        Console.Write("A soma entre " + número1 + " e " + número2 + " é " + (número1 + número2) + ".");
        Console.Write("A soma entre {0} e {1} é {2}.",número1,número2,número1+número2);
    }
}