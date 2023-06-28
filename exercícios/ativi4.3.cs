using System;
class programa{
    static void Main(){
        int A = 10,B = A / 2;
        float[] núm = new float[A];
        float[] núm1 = new float[núm.Length];
        Console.WriteLine("Preencha o vetor com números.");
        for(int i = 0; i < núm.Length / 2; i++){
            núm[i] = int.Parse(Console.ReadLine());
        }
        for(int i = 0; i < núm.Length / 2; i++){
            núm[i + núm.Length / 2] = núm[i];
        }
        for(int i = 0; i < núm.Length / 2; i++){
            núm[B -= 1] = núm[i + núm.Length / 2];
        }
        Array.Copy(núm,núm1,núm.Length);
        núm = new float[núm.Length / 2];
        Array.Copy(núm1,núm,núm1.Length / 2);
        Console.Write("\n=========");
        for(int i = 0; i < núm.Length; i++){
            Console.WriteLine("\n{0}",núm[i]);
        }
        Console.WriteLine("=========");
    }
}