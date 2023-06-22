using System;
class Números{
    static void Main(){
        int A,B = 0,C = 0,D = 0;
        voltar:
        Console.WriteLine("Digite o tamanho da coleção de números que deseja digitar:");
        A = int.Parse(Console.ReadLine());
        if(A < 3){
            Console.WriteLine("A quantidade de números não pode ser inferior a três.");
            Console.ReadLine();
            goto voltar;
        }
        float[] númaleatório = new float[A];
        Console.WriteLine("Agora digite quais os números que deseja mostrar:");
        for(int i = 0; i < númaleatório.Length; i++){
            númaleatório[i] = float.Parse(Console.ReadLine());
        }
        Console.WriteLine("\nO primeiro número da coleção é {0}.\nO ultimo número da coleção é {1}.",númaleatório[0],númaleatório[0 + númaleatório.Length - 1]);
        for(int i = 0; i < númaleatório.Length - 1; i++){
            B = i;
        }
        Console.WriteLine("\nEntre esses dois números existem {0} números.\nQue são:",B);
        for(int i = 0; i < númaleatório.Length - 2; i++){
            Console.WriteLine("{0}",númaleatório[i + 1]);
        }
        for(int i = 0; i < númaleatório.Length; i++){
            if(númaleatório[i] % 2 == 0){
                C++;
            }
            else{
                D++;
            }
        }
        Console.WriteLine("\nSendo que a coleção possui {0} números pares e {1} números ímpares.",C,D);
        Array.Sort(númaleatório);
        Console.WriteLine("\nO menor número sendo {0}.\nO maior número sendo {1}.\n",númaleatório[0],númaleatório[0 + númaleatório.Length - 1]);
        Console.WriteLine("A coleção ordenada do menor para o maior:");
        foreach(int i in númaleatório){
            Console.WriteLine(i);
        }
        Console.WriteLine("\nA coleção ordenada do maior para o menor:");
        Array.Reverse(númaleatório);
        foreach(int i in númaleatório){
            Console.WriteLine(i);
        }
    }
}