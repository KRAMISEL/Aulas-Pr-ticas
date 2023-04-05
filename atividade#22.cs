using System;
class program{
    static void Main(){
        Console.Write("Digite o seu ano de nascimento: ");
        int anoDeNascimento = int.Parse(Console.ReadLine());
        int ano1 = 2023;
        if(ano1 - anoDeNascimento  < 18){
            Console.WriteLine("Faltam " + (anoDeNascimento - ano1 + 18) + " anos para o seu alistamento.");
        }
        else{
            Console.WriteLine("Já se passaram " + (ano1 - anoDeNascimento - 18) + " anos do seu alistamento.");
        }
    }
}