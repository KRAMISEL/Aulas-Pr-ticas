using System;
class vetor{
    static void Main(){
        int A = 5;
        float[] núm = new float[A * 2];
        Console.WriteLine("Preencha o vetor com números.");
        for(int i = 0; i < núm.Length >> 1; i++){
            núm[i] = int.Parse(Console.ReadLine());
            núm[i + A] = núm[i];
        }
        Console.Write("\nOrdem inserida.:\n=========");
        for(int i = 0; i < núm.Length >> 1; i++){
            Console.WriteLine("\n{0}",núm[i]);
        }
        Console.WriteLine("=========");
        for(int i = 0; i < núm.Length >> 1; i++){
            núm[(A - 1) - i] = núm[i + A];
        }
        Console.Write("\nOrdem invertida.:\n=========");
        for(int i = 0; i < núm.Length >> 1; i++){
            Console.WriteLine("\n{0}",núm[i]);
        }
        Console.WriteLine("=========");
    }
}