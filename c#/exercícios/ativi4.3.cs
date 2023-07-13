using System;
class vetor{
    static void Main(){
        float A = 5f,B;
        float[] núm = new float[(int)A];
        Console.WriteLine("Preencha o vetor com números.");
        for(int i = 0; i < núm.Length; i++){
            núm[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("\nOrdem inserida.:\n=========");
        foreach(int i in núm){
            Console.WriteLine("\n{0}",i);
        }
        Console.WriteLine("=========");
        for(int i = 0; i < núm.Length; i++){
            if(núm[i] * 2 > A){
                break;
            }
            B = núm[i];
            núm[i] = núm[((int)A - 1) - i];
            núm[((int)A - 1) - i] = B;
        }
        Console.Write("\nOrdem invertida.:\n=========");
        foreach(int i in núm){
            Console.WriteLine("\n{0}",i);
        }
        Console.WriteLine("=========");
    }
}