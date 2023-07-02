using System;
class program{
    static void Main(){
        Console.WriteLine("Digite uma medida em metros: ");
        float Metros = float.Parse(Console.ReadLine());
        Console.WriteLine("A distância de {0} corresponde a: ",Metros);
        Console.Write(Metros / 1000 + "Km, ");
        Console.Write(Metros / 100 + "Hm, ");
        Console.Write(Metros / 10 + "Dam.\n");
        Console.Write(Metros * 10 + "dm, ");
        Console.Write(Metros * 100 + "cm, ");
        Console.WriteLine(Metros * 1000 + "mm.");
    }
}