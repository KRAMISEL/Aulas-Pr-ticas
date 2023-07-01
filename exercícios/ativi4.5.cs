using System;
class vetor{
    static void Main(){
        int A = 3,B = 2;
        float[,] núm = new float[A * 2,B * 2];
        Console.WriteLine("Preencha a matriz com números.");
        for(int i = 0; i < A; i++){
            for(int ia = 0; ia < B; ia++){
                núm[i,ia] = float.Parse(Console.ReadLine());
                núm[(A + (A - 1)) - i,(B + (B - 1)) - ia] = núm[i,ia];
            }
        }
        Console.Write("\nOrdem inserida.:\n=========\n");
        for(int i = 0; i < A * 2; i++){
            for(int ia = 0; ia < B * 2; ia++){
                Console.Write(" {0}",núm[i,ia]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("=========");
        for(int i = 0; i < A; i++){
            for(int ia = 0; ia < B; ia++){
                núm[i,ia] = núm[i + A,ia + B];
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