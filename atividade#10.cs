using System;
class program{
    static void Main(){
Console.Write("Me diga qual é a largura e a altura da parede que deseja pintar: ");
        double Largura = double.Parse(Console.ReadLine());
        double Altura = double.Parse(Console.ReadLine());
        Console.WriteLine("A área da parede a ser pintada é " + Largura * Altura + " metros quadrados, e você precisará de " + Largura * Altura / 2 + " litros de tinta para isso.");
    }
}