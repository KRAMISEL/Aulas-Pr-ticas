using System;
class programa{
    static void Main(){
        int A = 5;
        float[] núm = new float[A];
        float[] núm1 = new float[núm.Length];
        Console.WriteLine("Preencha o vetor com números.");
        for(int i = 0; i < núm.Length; i++){
            núm[i] = float.Parse(Console.ReadLine());
        }
        Array.Copy(núm,núm1,núm.Length);
        for(int i = 0; i < núm.Length; i++){
            núm[i] = núm1[0 + (A -= 1)];
        }
        Console.WriteLine("\n=========");
        foreach(int i in núm){
            Console.WriteLine("{0}",i);
        }
        Console.WriteLine("=========");
    }
}