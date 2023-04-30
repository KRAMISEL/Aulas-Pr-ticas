using System;
class program{
    static void Main(){
        Console.Write("Digite o seu ano de nascimento: ");
        int anoDeNascimento = int.Parse(Console.ReadLine());
        if(2023 - anoDeNascimento  < 18){
            Console.WriteLine("Faltam {0} anos para o seu alistamento.",(anoDeNascimento - 2023 + 18));
        }
        else{
            Console.WriteLine("Já se passaram {0} anos do seu alistamento.",(2023 - anoDeNascimento - 18));
        }
    }
}