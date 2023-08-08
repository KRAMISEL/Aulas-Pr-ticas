using System;
using System.Collections.Generic;
class matemática{
    static void Main(){
        voltar:
        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine("\n1-Somar\n2-Subtrair\n3-Mutlipicar\n4-Dividir\n");
        int escolha = int.Parse(Console.ReadLine());
        switch(escolha){
            case 1:
                Soma();
            break;
            case 2:
                Subtrair();
            break;
            case 3:
                Multiplicar();
            break;
            case 4:
                Dividir();
            break;
            default:
                Console.Clear();
                goto voltar;
        }
    }
    static void Soma(){
        List<float> Núm = new List<float>();
        float núm = 0;
        Console.WriteLine("Quantos números deseja somar:");
        int números = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite os números que deseja somar:");
        for(int i = 0; i < números; i++){
            Núm.Add(int.Parse(Console.ReadLine()));
            núm += Núm[i];
        }
        Console.WriteLine("A soma dos números é igual a {0}.",núm);
        Console.ReadLine();
        Main();
    }
    static void Subtrair(){
        List<float> Núm = new List<float>();
        float núm = 0;
        Console.WriteLine("Quantos números deseja subtrair:");
        int números = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite os números que deseja subtrair:");
        for(int i = 0; i < números; i++){
            Núm.Add(int.Parse(Console.ReadLine()));
        }
        núm = Núm[0];
        for(int i = 1; i < Núm.Count; i++){
            núm -= Núm[i];
        }
        Console.WriteLine("A subtração dos números é igual a {0}.",núm);
        Console.ReadLine();
        Main();
    }
    static void Multiplicar(){
        List<float> Núm = new List<float>();
        float núm = 1;
        Console.WriteLine("Quantos números deseja multiplicar:");
        int números = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite os números que deseja multiplicar:");
        for(int i = 0; i < números; i++){
            Núm.Add(int.Parse(Console.ReadLine()));
            núm *= Núm[i];
        }
        Console.WriteLine("A mutlipicação dos números é igual a {0}.",núm);
        Console.ReadLine();
        Main();
    }
    static void Dividir(){
        List<float> Núm = new List<float>();
        float núm = 0;
        Console.WriteLine("Quantos números deseja dividir:");
        int números = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite os números que deseja dividir:");
        for(int i = 0; i < números; i++){
            Núm.Add(int.Parse(Console.ReadLine()));
        }
        núm = Núm[0];
        for(int i = 1; i < Núm.Count; i++){
            núm /= Núm[i];
        }
        Console.WriteLine("A divisão dos números é igual a {0}.",núm);
        Console.ReadLine();
        Main();
    }
}