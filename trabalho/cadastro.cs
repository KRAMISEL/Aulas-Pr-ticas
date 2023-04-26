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
        int[] quantidadeDeCadastro1 = new int[quantidadeDeCadastro];
        string[] nome = new string[quantidadeDeCadastro];
        int[] idade = new int[quantidadeDeCadastro];
        double[] peso = new double[quantidadeDeCadastro];
        double[] altura = new double[quantidadeDeCadastro];
        char[] sexo = new char[quantidadeDeCadastro];
        int N_deCadastros = 0;
        int A = 0;
        for(A = 0; A < quantidadeDeCadastro1.Length; A++){
            if(N_deCadastros != A){
                N_deCadastros++;
            }
            Console.Write("Digite o seu nome: ");
            nome[A] = Console.ReadLine();
            Console.Write("Digite a sua idade: ");
            idade[A] = int.Parse(Console.ReadLine());
            Console.Write("Digite o seu peso: ");
            peso[A] = double.Parse(Console.ReadLine());
            Console.Write("Digite a sua altura: ");
            altura[A] = double.Parse(Console.ReadLine());
            Console.Write("Digite o seu sexo: ");
            sexo[A] = char.Parse(Console.ReadLine());
            Console.WriteLine("Cadastro de número ({0}) resgitrado.",N_deCadastros + 1);
            Console.WriteLine();
        }
        N_deCadastros-=A;
        for(A = 0; A < quantidadeDeCadastro1.Length; A++){
        if(N_deCadastros != A){
            N_deCadastros++;
        }
        Console.WriteLine("Cadastro de número ({0}):",N_deCadastros+1);
        Console.WriteLine("Nome:{0}",nome[A]);
        Console.WriteLine("Idade:{0}",idade[A]);
        Console.WriteLine("Peso:{0}",peso[A]);
        Console.WriteLine("Altura:{0}",altura[A]);
        Console.WriteLine("Sexo:{0}",sexo[A]);
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