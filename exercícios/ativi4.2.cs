using System;
class vetor{
    static void Main(){
        int A = 5;
        float[] núm = new float[A * 2];
        Console.WriteLine("Preencha o vetor com números.");
        for(int i = 0; i < núm.Length / 2; i++){
            núm[i] = int.Parse(Console.ReadLine());
            núm[i + núm.Length / 2] = núm[i];
        }
        for(int i = 0; i < núm.Length / 2; i++){
            núm[(A - 1) - i] = núm[i + núm.Length / 2];
        }
        Console.Write("\n=========");
        for(int i = 0; i < núm.Length / 2; i++){
            Console.WriteLine("\n{0}",núm[i]);
        }
        Console.WriteLine("=========");
    }
}