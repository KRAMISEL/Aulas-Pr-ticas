using System;
class vetor{
    static void Main(){
        int A = 5,B;
        int[] núm = new int[A];
        Console.WriteLine("Preencha o vetor com números.");
        for(int i = 0; i < núm.Length; i++){
            núm[i] = int.Parse(Console.ReadLine());
        }
        for(int i = 0; i < núm.Length / 2; i++){
            B = núm[i];
            núm[i] = núm[(A - 1) - i];
            núm[(A - 1) - i] = B;
        }
        Console.Write("\n=========");
        foreach(int i in núm){
            Console.WriteLine("\n{0}",i);
        }
        Console.WriteLine("=========");
    }
}