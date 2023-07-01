using System;
class vetor{
    static void Main(){
        int A = 3,B = 2;
        float[,] núm = new float[A,B],núm1 = new float[A,B];
        Console.WriteLine("Preencha o vetor com números.");
        for(int i = 0; i < A; i++){
            for(int ia = 0; ia < B; ia++){
                núm[i,ia] = float.Parse(Console.ReadLine());
                núm1[(A - 1) - i,(B - 1) - ia] = núm[i,ia];
            }
        }
        Console.Write("\nOrdem inserida.:\n=========\n");
        for(int i = 0; i < A; i++){
            for(int ia = 0; ia < B; ia++){
                Console.Write(" {0}",núm[i,ia]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("=========");
        for(int i = 0; i < A; i++){
            for(int ia = 0; ia < B; ia++){
                núm[i,ia] = núm1[i,ia];
            }
        }
        Console.Write("\nOrdem invertida.:\n=========\n");
        for(int i = 0; i < A; i++){
            for(int ia = 0; ia < B; ia++){
                Console.Write(" {0}",núm[i,ia]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("=========");
    }
}