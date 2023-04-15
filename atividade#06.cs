using System;
class program{
    static void Main(){
        Console.Write("Digite um número: ");
        int número = int.Parse(Console.ReadLine());
        Console.WriteLine("O sucessor de " + número + " é " + (número + 1) + " e o antecessor de " + número + " é " + (número - 1));
        Console.WriteLine("O sucessor de {0} é {1} e o antecessor de {2} é {3}",número,número+1,número,número-1);
    }
}