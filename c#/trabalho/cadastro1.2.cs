using System;
using System.Collections.Generic;
class program{
    static int N_deCadastro = 0;
    static List<int> quantiCadastro = new List<int>(), idade = new List<int>();
    static List<string> nome = new List<string>();
    static List<float> peso = new List<float>(), altura = new List<float>();
    static List<char> sexo = new List<char>();
    static void Main(){
        Console.WriteLine("<========================================>\n<=| Atendimento de cadastro ao cliente |=>\n<========================================>\n O que deseja fazer:");
        Menu();
    }
    static void Menu(){
        Console.WriteLine("\n Cadastrar________________________:(1)\n Alteração de cadastro____________:(2)\n Impreção de cadastros____________:(3)\n Excluir cadastro_________________:(4)\n Limpar a tela____________________:(5)\n Sair_____________________________:(6)");
        string execução = Console.ReadLine();
        switch(execução){
            case"1":
            Cadastrar();
            break;
            case"2":
            Alteraçãodecadastro();
            break;
            case"3":
            Impreçãodecadastro();
            break;
            case"4":
            Excluircadastro();
            break;
            case"5":
            Limparatela();
            break;
            case"6":
            Sair();
            break;
            default:
            Main();
            break;
        }
    }
    static void Cadastrar(){
        Console.WriteLine("\n<===============>\n<=| Cadastrar |=>\n<===============>\n");
        if(quantiCadastro.Count > 0){
            Console.WriteLine(" Quantidade de cadastros.: <( {0} )>\n",quantiCadastro.Count);
        }
        Console.Write(" Quantos cadastros deseja fazer: ");
        int quantidadeDeCadastro = int.Parse(Console.ReadLine());
        if(quantidadeDeCadastro == 0){
            goto avançar;
        }
        for(int i = 0; i < quantidadeDeCadastro; i++){
            quantiCadastro.Add(N_deCadastro += 1);
            Console.WriteLine("\n Cadastro de número__.: |{0}| :.",N_deCadastro);
            Console.Write(" Digite o seu nome___.: ");
            nome.Add(Console.ReadLine());
            Console.Write(" Digite a sua idade__.: ");
            idade.Add(int.Parse(Console.ReadLine()));
            Console.Write(" Digite o seu peso___.: ");
            peso.Add(float.Parse(Console.ReadLine()));
            Console.Write(" Digite a sua altura_.: ");
            altura.Add(float.Parse(Console.ReadLine()));
            Console.Write(" Digite o seu sexo___.: ");
            sexo.Add(char.Parse(Console.ReadLine()));
            Console.WriteLine(" ==================================>");
        }
        avançar:
        Console.WriteLine();
        Main();
    }
    static void Alteraçãodecadastro(){
        Console.WriteLine("\n<===========================>\n<=| Alteração de cadastro |=>\n<===========================>\n");
        if(quantiCadastro.Count == 0){
            Console.WriteLine(" Não existem cadastros a serem alterados.");
            Console.ReadLine();
            goto avançar0;
        }else if(quantiCadastro.Count == 1){
            Console.Write(" Digite o seu nome: ");
            nome[0] = Console.ReadLine();
            Console.Write(" Digite a sua idade: ");
            idade[0] = int.Parse(Console.ReadLine());
            Console.Write(" Digite o seu peso: ");
            peso[0] = float.Parse(Console.ReadLine());
            Console.Write(" Digite a sua altura: ");
            altura[0] = float.Parse(Console.ReadLine());
            Console.Write(" Digite o seu sexo: ");
            sexo[0] = char.Parse(Console.ReadLine());
            Console.WriteLine(" Cadastro alterado.\n ====================>");
            Console.ReadLine();
            goto avançar1;
        }
        retorno:
        Console.WriteLine(" Quantidade de cadastros.: <( {0} )>\n",quantiCadastro.Count);
        Console.Write(" Quantos cadastros deseja alterar: ");
        int alterarCadastro = int.Parse(Console.ReadLine());
        List<int> altCadastro = new List<int>();
        if(alterarCadastro > quantiCadastro.Count){
            Console.WriteLine("\n A quantidade de cadastros a serem alterados não corresponde a quantidade de cadastros existentes.");
            goto retorno;
        }else if(alterarCadastro == 0){
            goto avançar2;
        }else if(alterarCadastro == quantiCadastro.Count){
            for(int i = 0; i < alterarCadastro; i++){
                Console.Write("\n Digite o seu nome: ");
                nome[i] = Console.ReadLine();
                Console.Write(" Digite a sua idade: ");
                idade[i] = int.Parse(Console.ReadLine());
                Console.Write(" Digite o seu peso: ");
                peso[i] = float.Parse(Console.ReadLine());
                Console.Write(" Digite a sua altura: ");
                altura[i] = float.Parse(Console.ReadLine());
                Console.Write(" Digite o seu sexo: ");
                sexo[i] = char.Parse(Console.ReadLine());
                Console.WriteLine(" Cadastro de número {0} alterado.\n ========================================>",quantiCadastro[i]);
            }
        goto avançar3;
        }
        voltar:
        if(alterarCadastro == 1){
            Console.WriteLine("\n Qual cadastro deseja alterar: ");
        }else{
            Console.WriteLine("\n Quais cadastros deseja alterar: ");
        }
        for(int i = 0; i < alterarCadastro; i++){
            int A = int.Parse(Console.ReadLine());
            altCadastro.Add(A - 1);
            if(altCadastro[i] >= quantiCadastro.Count || altCadastro[i] == -1){
                Console.WriteLine("\n ERRO:/0000001.0\n Falha na indentificação do cadastro.");
                Console.ReadLine();
                altCadastro.Remove(altCadastro[i]);
                goto voltar;
            }
        }
        for(int i = 0; i < altCadastro.Count; i++){
            Console.Write("\n Digite o seu nome: ");
            nome[altCadastro[i]] = Console.ReadLine();
            Console.Write(" Digite a sua idade: ");
            idade[altCadastro[i]] = int.Parse(Console.ReadLine());
            Console.Write(" Digite o seu peso: ");
            peso[altCadastro[i]] = float.Parse(Console.ReadLine());
            Console.Write(" Digite a sua altura: ");
            altura[altCadastro[i]] = float.Parse(Console.ReadLine());
            Console.Write(" Digite o seu sexo: ");
            sexo[altCadastro[i]] = char.Parse(Console.ReadLine());
            Console.WriteLine(" Cadastro de número {0} alterado.\n ========================================>",altCadastro[i] + 1);
        }
        altCadastro.Clear();
        Console.WriteLine();
        avançar0:
        avançar1:
        avançar2:
        avançar3:
        Main();
    }
    static void Impreçãodecadastro(){
        Console.WriteLine("\n<===========================>\n<=| Impreção de cadastros |=>\n<===========================>\n");
        if(quantiCadastro.Count == 0){
            Console.WriteLine(" Não existem cadastros a serem imprimidos.");
            goto avançar0;
        }else if(quantiCadastro.Count == 1){
            Console.WriteLine(" Cadastro..: |{0}| :.\n Nome...: {1}\n Idade..: {2}\n Peso...: {3}\n Altura.: {4}\n Sexo...: {5}\n ===============================>",quantiCadastro[0],nome[0],idade[0],peso[0],altura[0],sexo[0]);
            Console.ReadLine();
            goto avançar1;
        }
        retorno:
        Console.WriteLine(" Quantidade de cadastros.: <( {0} )>\n",quantiCadastro.Count);
        Console.Write(" Quantos cadastros deseja imprimir: ");
        int imprimirCadastro = int.Parse(Console.ReadLine());
        List<int> impCadastro = new List<int>();
        if(imprimirCadastro > quantiCadastro.Count){
            Console.WriteLine("\n A quantidade de cadastros a serem imprimidos não corresponde a quantidade de cadastros existentes.");
            goto retorno;
        }else if(imprimirCadastro == 0){
            goto avançar2;
        }else if(imprimirCadastro == quantiCadastro.Count){
            for(int i = 0; i < quantiCadastro.Count; i++){
                Console.Write("\n Cadastro..: |{0}| :.\n Nome...: {1}\n Idade..: {2}\n Peso...: {3}\n Altura.: {4}\n Sexo...: {5}\n ===============================>\n",quantiCadastro[i],nome[i],idade[i],peso[i],altura[i],sexo[i]);
            }
            Console.ReadLine();
            goto avançar3;
        }
        voltar:
        if(imprimirCadastro == 1){
            Console.WriteLine("\n Qual cadastro deseja imprimir: ");
        }else{
            Console.WriteLine("\n Quais cadastros deseja imprimir: ");
        }
        for(int i = 0; i < imprimirCadastro; i++){
            int A = int.Parse(Console.ReadLine());
            impCadastro.Add(A - 1);
            if(impCadastro[i] >= quantiCadastro.Count || impCadastro[i] == -1){
                Console.WriteLine("\n ERRO:/0000002.0\n Falha na indentificação do cadastro.");
                Console.ReadLine();
                impCadastro.Remove(impCadastro[i]);
                goto voltar;
            }
        }
        for(int i = 0; i < impCadastro.Count; i++){
            Console.Write("\n Cadastro..: |{0}| :.\n Nome...: {1}\n Idade..: {2}\n Peso...: {3}\n Altura.: {4}\n Sexo...: {5}\n =============================>\n",impCadastro[i] + 1,nome[impCadastro[i]],idade[impCadastro[i]],peso[impCadastro[i]],altura[impCadastro[i]],sexo[impCadastro[i]]);
        }
        impCadastro.Clear();
        Console.ReadLine();
        avançar0:
        avançar1:
        avançar2:
        avançar3:
        Main();
    }
    static void Excluircadastro(){
        Console.WriteLine("\n<======================>\n<=| Excluir cadastro |=>\n<======================>\n");
        if(quantiCadastro.Count == 0){
            Console.WriteLine(" Não existem cadastros a serem excluidos.");
            Console.ReadLine();
            goto avançar0;
        }else if(quantiCadastro.Count == 1){
            quantiCadastro.Clear();
            nome.Clear();
            idade.Clear();
            peso.Clear();
            altura.Clear();
            sexo.Clear();
            N_deCadastro -= 1;
            Console.WriteLine(" Cadastro excluido.");
            Console.ReadLine();
            goto avançar1;
        }
        retorno:
        Console.WriteLine(" Quantidade de cadastros.: <( {0} )>\n",quantiCadastro.Count);
        Console.Write(" Quantos cadastros deseja excluir: ");
        int excluirCadastro = int.Parse(Console.ReadLine());
        List<int> excCadastro = new List<int>();
        if(excluirCadastro > quantiCadastro.Count){
            Console.WriteLine(" A quantidade de cadastros a serem excluidos não corresponde a quantidade de cadastros existentes.");
            goto retorno;
        }else if(excluirCadastro == 0){
            goto avançar2;
        }else if(excluirCadastro == quantiCadastro.Count){
            quantiCadastro.Clear();
            nome.Clear();
            idade.Clear();
            peso.Clear();
            altura.Clear();
            sexo.Clear();
            N_deCadastro -= excluirCadastro;
            Console.Write("\n Todos os cadastros foram excluidos.");
            Console.ReadLine();
            goto avançar3;
        }
        voltar:
        if(excluirCadastro == 1){
            Console.WriteLine("\n Qual cadastro deseja excluir:");
        }else{
            Console.WriteLine("\n Quais cadastros deseja excluir:");
        }
        for(int i = 0; i < excluirCadastro; i++){
            int A = int.Parse(Console.ReadLine());
            excCadastro.Add(A - 1);
            if(excCadastro[i] >= quantiCadastro.Count || excCadastro[i] == -1){
                Console.WriteLine("\n ERRO:/0000003.0\n Falha na indentificação do cadastro.");
                Console.ReadLine();
                excCadastro.Remove(excCadastro[i]);
                goto voltar;
            }
        }
        for(int i = 0; i < excCadastro.Count; i++){
            for(int ia = excCadastro[i]; ia < quantiCadastro.Count - 1; ia++){
                nome[ia] = nome[ia + 1];
                idade[ia] = idade[ia + 1];
                peso[ia] = peso[ia + 1];
                altura[ia] = altura[ia + 1];
                sexo[ia] = sexo[ia + 1];
            }
           quantiCadastro.Remove(quantiCadastro[quantiCadastro.Count - 1]);
           nome.Remove(nome[nome.Count - 1]);
           idade.Remove(idade[idade.Count - 1]);
           peso.Remove(peso[peso.Count - 1]);
           altura.Remove(altura[altura.Count - 1]);
           sexo.Remove(sexo[sexo.Count - 1]);
        }
        for(int i = 0; i < excCadastro.Count; i++){
            Console.WriteLine("\n Cadastro de número |{0}| excluido.",excCadastro[i] + 1);
        }
        excCadastro.Clear();
        N_deCadastro -= excCadastro.Count;
        Console.ReadLine();
        avançar0:
        avançar1:
        avançar2:
        avançar3:
        Main();
    }
    static void Limparatela(){
        Console.Clear();
        Main();
    }
    static void Sair(){
        Console.WriteLine("\n Volte sempre.");
    }   
}