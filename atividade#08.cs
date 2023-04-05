using System;
class program{
    static void Main(){
        Console.WriteLine("Digite uma medida em metros: ");
        double Metros = double.Parse(Console.ReadLine());
        Console.WriteLine("A distância de " + Metros + " corresponde a: ");
        Console.WriteLine(Metros /1000 + "Km");
        Console.WriteLine(Metros /100 + "Hm");
        Console.WriteLine(Metros /10 + "Dam");
        Console.WriteLine(Metros *10 + "dm");
        Console.WriteLine(Metros *100 + "cm");
        Console.WriteLine(Metros *1000 + "mm");
    }
}