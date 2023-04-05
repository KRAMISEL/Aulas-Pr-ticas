using System;
class program{
    static void Main(){
        Console.Write("Quantos Km o seu carro pecorreu? ");
        double KmPecorridos = double.Parse(Console.ReadLine());
        Console.Write("Por quantos dias você alugou o carro? ");
        double DiasAlugados = double.Parse(Console.ReadLine());
        Console.WriteLine("Pela quantidade de Km pecorridos, e pela quantidades de dias alugados, você deverá pagar R$" + KmPecorridos * 0.20 + DiasAlugados * 90 + ",00");
    }
}