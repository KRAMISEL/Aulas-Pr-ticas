using System;
class program{
    static void Main(){
        Console.WriteLine("O que deseja fazer:");
        Menu();
    }
    static void Menu(){
        Console.WriteLine("(1) Cadastro;");
        Console.WriteLine("(2) Alterar cadastro;");
        Console.WriteLine("(3) Imprimir todos os cadastros;");
        Console.WriteLine("(4) Imprimir um cadastro;");
        Console.WriteLine("(5) Excluir cadastro;");
        Console.WriteLine("(6) Limpar tela;");
        Console.WriteLine("(7) Sair;");
        string execução = Console.ReadLine();
        switch(execução){
            case  "1":
            Cadastro();
            break;
            case  "2":
            Alterarcadastro();
            break;
            case  "3":
            Imprimirtodososcadastros();
            break;
            case  "4":
            Imprimirumcadastro();
            break;
            case  "5":
            Excluircadastro();
            break;
            case  "6":
            Limpartela();
            break;
            case  "7":
            Sair();
            break;
            default:
            Console.Clear();
            Console.Write("Deseja retornar ao menu?");
            Console.Write(" [S/N] ");
            char voltar = char.Parse(Console.ReadLine());
            if(voltar == 'S' || voltar == 's'){
                Main();
            }
            else if(voltar == 'N' || voltar == 'n'){
                Console.WriteLine("Poderá retornar ao menu assim que desejar.");
                voltar = char.Parse(Console.ReadLine());
                Main();
            }
            break;
        }
    }
    static void Cadastro(){
        string[] nome = new string[100];
        int[] idade = new int[100];
        double[] peso = new double[100];
        double[] altura = new double[100];
        char[] sexo = new char[100];

        int[] quantidadeCadastro = new int[100];

        Console.Write("Quantos cadastros deseja fazer: ");
    }
    static void Alterarcadastro(){
        Console.WriteLine("Quais cadastros deseja alterar:");
    }
    static void Imprimirtodososcadastros(){
    }
    static void Imprimirumcadastro(){
    }
    static void Excluircadastro(){
    }
    static void Limpartela(){
    }
    static void Sair(){
    }   
}