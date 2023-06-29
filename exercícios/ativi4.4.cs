using System;
class vetor{
    static void Main(){
        int A = 5;
        float [,] núm = new float[2,A];
        Console.WriteLine("Preencha a matriz com números.");
        for(int i = 0; i < A; i++){
            núm[0,i] = float.Parse(Console.ReadLine());
            núm[1,(A - 1) - i] = núm[0,i];
        }
        for(int i = 0; i < A; i++){
            núm[0,i] = núm[1,i];
        }
        Console.Write("\n=========");
        for(int i = 0; i < A; i++){
            Console.WriteLine("\n{0}",núm[0,i]);
        }
        Console.WriteLine("=========");
    }
}