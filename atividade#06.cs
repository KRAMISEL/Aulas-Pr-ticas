using System;
class program{
    static void Main(){
        Console.Write("Digite um número: ");
        int número = int.Parse(Console.ReadLine());
        Console.WriteLine("O sucessor de " + número + " é " + (número + 1) + " e o antecessor de " + número + " é " + (número - 1));
    }
}