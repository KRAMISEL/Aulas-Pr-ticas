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
        string[] nome = new string[quantidadeDeCadastro];
        int[] idade = new int[quantidadeDeCadastro];
        double[] peso = new double[quantidadeDeCadastro];
        double[] altura = new double[quantidadeDeCadastro];
        char[] sexo = new char[quantidadeDeCadastro];
        int C = 0;
        int B = 0;
        for(B = 0; B < A.Length; B++){
            if(C != B){
                C++;
            }
            Console.Write("Digite o seu nome: ");
            nome[B] = Console.ReadLine();
            Console.Write("Digite a sua idade: ");
            idade[B] = int.Parse(Console.ReadLine());
            Console.Write("Digite o seu peso: ");
            peso[B] = double.Parse(Console.ReadLine());
            Console.Write("Digite a sua altura: ");
            altura[B] = double.Parse(Console.ReadLine());
            Console.Write("Digite o seu sexo: ");
            sexo[B] = char.Parse(Console.ReadLine());
            Console.WriteLine("Cadastro de número ({0}) resgitrado.",C + 1);
            Console.WriteLine();
        }
        C-=B;
        for(B = 0; B < A.Length; B++){
        if(C != B){
            C++;
        }
        Console.WriteLine("Cadastro de número ({0}):",C+1);
        Console.WriteLine("Nome:{0}",nome[B]);
        Console.WriteLine("Idade:{0}",idade[B]);
        Console.WriteLine("Peso:{0}",peso[B]);
        Console.WriteLine("Altura:{0}",altura[B]);
        Console.WriteLine("Sexo:{0}",sexo[B]);
        Console.WriteLine();
        }
        //Alterarcadastro(ref nome,ref idade,ref peso,ref altura,ref sexo);
    }
    static void Alterarcadastro(){
        Console.WriteLine("Quais cadastros deseja alterar:");
        //(ref string[] nomeAl,ref int[] idadeAl,ref double[] pesoAl,ref double[] alturaAl,ref char[] sexoAl)
        /*Console.WriteLine(nomeAl[1]);
        Console.WriteLine(idadeAl[2]);
        Console.WriteLine(pesoAl[1]);
        Console.WriteLine(alturaAl[2]);
        Console.WriteLine(sexoAl[0]);*/
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