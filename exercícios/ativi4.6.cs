using System;
class vetor{
    static void Main(){
        int A = 3,B;
        int[,] núm = new int[A,A];
        Console.WriteLine("Preencha o vetor com números.");
        for(int i = 0; i < A; i++){
            for(int ia = 0; ia < A; ia++){
                núm[i,ia] = int.Parse(Console.ReadLine());
            }
        }
        for(int i = 0; i < 2; i++){
            for(int ia = 0; ia < A; ia++){
                B = núm[i,ia];
                núm[i,ia] = núm[(A - 1) - i,(A - 1) - ia];
                núm[(A - 1) - i,(A - 1) - ia] = B;
            }
        }
        if(A % 2 != 0){
            B = núm[1,0];
            núm[1,0] = núm[1,2];
            núm[1,2] = B;
        }
        Console.Write("\n=========\n");
        for(int i = 0; i < A; i++){
            for(int ia = 0; ia < A; ia++){
                Console.Write("{0}",núm[i,ia]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("=========");
    }
}