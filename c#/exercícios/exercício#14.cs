using System;
class program{
    static void Main(){
        Console.Write("Quantos Km o seu carro pecorreu? ");
        float KmPecorridos = float.Parse(Console.ReadLine());
        Console.Write("Por quantos dias você alugou o carro? ");
        float DiasAlugados = float.Parse(Console.ReadLine());
        Console.WriteLine("Pela quantidade de Km pecorridos, e pela quantidades de dias alugados, você deverá pagar {0:c}.",KmPecorridos * 0.20f + DiasAlugados * 90f);
    }
}