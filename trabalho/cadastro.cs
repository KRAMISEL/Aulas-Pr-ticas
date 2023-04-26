using System;
class program{
    static void Main(){
        Console.WriteLine("O que deseja fazer:");
        Menu();
    }
    static void Menu(){
        Console.WriteLine("(1) Cadastro;\n(2) Alterar cadastro;\n(3) Imprimir todos os cadastros;\n(4) Imprimir um cadastro;\n(5) Excluir cadastro;\n(6) Limpar tela;\n(7) Sair;");
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
            Main();
            break;
        }
    }
    static void Cadastro(){
        Console.Write("Quantos cadastros deseja fazer: ");
        int quantidadeDeCadastro = int.Parse(Console.ReadLine());
        int[] A = new int[quantidadeDeCadastro];
        int C = (-1);
        for(int B = 0; B < A.Length; B++){
            if(C < B){
                C++;
            }
            Console.Write("Digite o seu nome: ");
            string[] nome = new string[quantidadeDeCadastro];
            nome[0] = Console.ReadLine();
            Console.Write("Digite a sua idade: ");
            int[] idade = new int[quantidadeDeCadastro];
            idade[0] = int.Parse(Console.ReadLine());
            Console.Write("Digite o seu peso: ");
            double[] peso = new double[quantidadeDeCadastro];
            peso[0] = double.Parse(Console.ReadLine());
            Console.Write("Digite a sua altura: ");
            double[] altura = new double[quantidadeDeCadastro];
            altura[0] = double.Parse(Console.ReadLine());
            Console.Write("Digite o seu sexo: ");
            char[] sexo = new char[quantidadeDeCadastro];
            sexo[0] = char.Parse(Console.ReadLine());
            Console.WriteLine("Cadastro de número ({0}) resgitrado.",C + 1);
            Console.WriteLine();
        }
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