using System;
class program{
    static void Main(){
        Console.Write("O que deseja fazer:");
        Menu();
    }
    static void Menu(){
        Console.WriteLine("Cadastro: 1");
        Console.WriteLine("Alterar cadastro: 2");
        Console.WriteLine("Imprimir todos os cadastros: 3");
        Console.WriteLine("Imprimir um cadastro: 4");
        Console.WriteLine("Excleuir cadastro: 5");
        Console.WriteLine("Limpar tela: 6");
        Console.WriteLine("Sair: 7");
        int execução = Console.Read();
        switch(execução){
            case 1:
            Cadastro();
            break;
            case 2:
            Alterarcadastro();
            break;
        }
    }
    static void Cadastro(){
        Console.WriteLine("Digite o seu nome.");
    }
    static void Alterarcadastro(){
        Console.WriteLine("Quais cadastro deseja alterar:");
    }
}