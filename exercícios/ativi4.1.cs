using System;
class vetor{
    static void Main(){
        int A = 5;
        float[] núm = new float[A],núm1 = new float[núm.Length];
        Console.WriteLine("Preencha o vetor com números.");
        for(int i = 0; i < núm.Length; i++){
            núm[i] = float.Parse(Console.ReadLine());
        }
        Array.Copy(núm,núm1,núm.Length);
        for(int i = 0; i < núm.Length; i++){
            núm[i] = núm1[(A - 1) - i];
        }
        Console.Write("\n=========");
        foreach(int i in núm){
            Console.WriteLine("\n{0}",i);
        }
        Console.WriteLine("=========");
    }
}