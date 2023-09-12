using System;
class Cálculo{
    static void Main(){
        float núm1 = 0f, núm2 = 0f, núm3 = 0f, res = 0f;
        Console.WriteLine("Digite dois números para serem somados, e digite um terceiro número para ser multiplicado pelo resultado dos dois primeiros.");
        núm1 = float.Parse(Console.ReadLine());
        núm2 = float.Parse(Console.ReadLine());
        núm3 = float.Parse(Console.ReadLine());
        res = cálculo(núm1,núm2,núm3);
        Console.WriteLine("O resultado da soma dos dois primeiros números multiplicado com o terceiro número é {0}",res);
    }
    static float cálculo(float n1, float n2, float n3){
        return (n1 + n2) * n3;
    }
}