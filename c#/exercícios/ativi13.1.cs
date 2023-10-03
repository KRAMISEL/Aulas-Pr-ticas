using System;
class Senha{
    static decimal[] numeros = new decimal[0];
    static int ID = 0;
    static void Main(){
        voltar:
        Console.WriteLine("Cadastro numerico");
        Console.WriteLine("O que deseja fazer?\n1-Cadastro:\n2-Impressão:\n3-Exclusão:\n#-Sair");
        int esc = int.Parse(Console.ReadLine());
        switch(esc){
            case 1:
                Cadastro();
                Console.Clear();
                goto voltar;
            case 2:
                Impressão();
                Console.Clear();
                goto voltar;
            case 3:
                Exclusão();
                Console.Clear();
                goto voltar;
        }
    }
    static void Cadastro(){
        decimal[] num = new decimal[numeros.Length];
        for(int i = 0; i < numeros.Length; i++){
            num[i] = numeros[i];
        }
        Console.WriteLine("Quantos cadastros deseja realizar?");
        int dec = int.Parse(Console.ReadLine());
        numeros = new decimal[numeros.Length + dec];
        if(num.Length > 0){
            for(int i = 0; i < numeros.Length; i++){
                numeros[i] = num[i];
            }
        }
        Console.WriteLine("<= Cadastros =>");
        for(int i = ID; i < dec; i++){
            i = ID++;
            numeros[i] = decimal.Parse(Console.ReadLine());
        }
    }
    static void Impressão(){
        Console.WriteLine("Quantos cadastros deseja imprimir?");
        int dec = int.Parse(Console.ReadLine());
        Console.WriteLine("<= Cadastros =>");
        foreach(decimal i in numeros){
            Console.Write(i + " | ");
        }
        Console.WriteLine("\n<<");
        Console.ReadLine();
    }
    static void Exclusão(){
        int[] exc = new int[numeros.Length];
        Console.WriteLine("Quantos cadastros deseja excluir?");
        int dec = int.Parse(Console.ReadLine());
        decimal[] num = new decimal[numeros.Length - dec];
        Console.WriteLine("Quais deseja excluir?");
        foreach(decimal i in numeros){
            Console.Write(i + " | ");
        }
        for(int i = 0; i < dec; i++){
            int A = int.Parse(Console.ReadLine());
            exc[i] = A - 1;
        }
        for(int i = 0; i < dec; i++){
            for(int ia = exc[i]; ia < numeros.Length - 1; ia++){
                numeros[ia] = numeros[ia + 1];
            }
        }
        for(int i = 0; i < num.Length; i++){
            num[i] = numeros[i];
        }
        numeros = new decimal[num.Length];
        Console.WriteLine();
        for(int i = 0; i < numeros.Length; i++){
            numeros[i] = num[i];
        }
    }
}