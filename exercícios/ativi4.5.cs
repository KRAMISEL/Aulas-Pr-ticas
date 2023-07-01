using System;
class vetor{
    static void Main(){
        int A = 3;
        float[,] núm = new float[A * 2,A * 2];
        Console.WriteLine("Preencha a matriz com números.");
        for(int i = 0; i < A; i++){
            for(int ia = 0; ia < A; ia++){
                núm[i,ia] = float.Parse(Console.ReadLine());
                núm[i + 2,ia + 2] = núm[i,ia];
            }
        }
        Console.Write("\nOrdem inserida.:\n=========\n");
        for(int i = 0; i < A; i++){
            for(int ia = 0; ia < A; ia++){
                Console.Write(" {0}",núm[i,ia]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("=========");
        for(int i = 0; i < A; i++){
            for(int ia = 0; ia < A; ia++){
                núm[(A - 1) - i,(A - 1) - ia] = núm[i + 2,ia + 2];
            }
        }
        Console.Write("\nOrdem invertida.:\n=========\n");
        for(int i = 0; i < A; i++){
            for(int ia = 0; ia < A; ia++){
                Console.Write(" {0}",núm[i,ia]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("=========");
    }
}