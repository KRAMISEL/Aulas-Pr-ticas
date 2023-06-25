using System;
class program{
    static int quantidadeDeCadastro;
    static int[] quantidadeDeCadastro1 = new int[0];
    static int excluirCadastro;
    static int[] excluirCadastro1;
    static string[] nome = new string[0];
    static int[] idade = new int[0];
    static float[] peso = new float[0];
    static float[] altura = new float[0];
    static char[] sexo = new char[0];
    static int N_deCadastros = 0;
    static int SA = 0;
    static void Main(){
        if(SA > 0){
            goto avançar;
        }
        Console.WriteLine("<========================================>\n<=| Atendimento de cadastro ao cliente |=>\n<========================================>\n O que deseja fazer:");
        Menu();
        avançar:
        Console.Write(" ");
    }
    static void Menu(){
        Console.WriteLine("\n Cadastrar________________________:(1)\n Alteração de cadastro____________:(2)\n Impreção de cadastros____________:(3)\n Excluir cadastro_________________:(4)\n Limpar a tela____________________:(5)\n Sair_____________________________:(6)");
        string execução = Console.ReadLine();
        Console.WriteLine();
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
        Console.WriteLine("<===============>\n<=| Cadastrar |=>\n<===============>\n");
        string[] armazenamentoDeNomes = new string[nome.Length];
        int[] armazenamentoDeIdades = new int[idade.Length];
        float[] armazenamentoDePesos = new float[peso.Length];
        float[] armazenamentoDeAlturas = new float[altura.Length];
        char[] armazenamentoDeSexos = new char[sexo.Length];
        Array.Copy(nome,armazenamentoDeNomes,nome.Length);
        Array.Copy(idade,armazenamentoDeIdades,idade.Length);
        Array.Copy(peso,armazenamentoDePesos,peso.Length);
        Array.Copy(altura,armazenamentoDeAlturas,altura.Length);
        Array.Copy(sexo,armazenamentoDeSexos,sexo.Length);
        if(quantidadeDeCadastro1.Length > 0){
            Console.WriteLine(" Quantidade de cadastros <( {0} )>\n",quantidadeDeCadastro1.Length);
        }
        Console.Write(" Quantos cadastros deseja fazer: ");
        quantidadeDeCadastro = int.Parse(Console.ReadLine());
        quantidadeDeCadastro1 = new int[quantidadeDeCadastro1.Length + quantidadeDeCadastro];
        nome = new string[nome.Length + quantidadeDeCadastro];
        idade = new int[idade.Length + quantidadeDeCadastro];
        peso = new float[peso.Length + quantidadeDeCadastro];
        altura = new float[altura.Length + quantidadeDeCadastro];
        sexo = new char[sexo.Length + quantidadeDeCadastro];
        if(quantidadeDeCadastro == 0){
            goto avançar;
        }
        else if(N_deCadastros > 0){
        Array.Copy(armazenamentoDeNomes,nome,nome.Length - quantidadeDeCadastro);
        Array.Copy(armazenamentoDeIdades,idade,idade.Length - quantidadeDeCadastro);
        Array.Copy(armazenamentoDePesos,peso,peso.Length - quantidadeDeCadastro);
        Array.Copy(armazenamentoDeAlturas,altura,altura.Length - quantidadeDeCadastro);
        Array.Copy(armazenamentoDeSexos,sexo,sexo.Length - quantidadeDeCadastro);
        }
        for(int i = 0; i < quantidadeDeCadastro; i++){
            N_deCadastros++;
            Console.WriteLine("\n Cadastro de número <( {0} )>",N_deCadastros);
            Console.Write(" Digite o seu nome: ");
            nome[i + nome.Length - quantidadeDeCadastro] = Console.ReadLine();
            Console.Write(" Digite a sua idade: ");
            idade[i + idade.Length - quantidadeDeCadastro] = int.Parse(Console.ReadLine());
            Console.Write(" Digite o seu peso: ");
            peso[i + peso.Length - quantidadeDeCadastro] = float.Parse(Console.ReadLine());
            Console.Write(" Digite a sua altura: ");
            altura[i + altura.Length - quantidadeDeCadastro] = float.Parse(Console.ReadLine());
            Console.Write(" Digite o seu sexo: ");
            sexo[i + sexo.Length - quantidadeDeCadastro] = char.Parse(Console.ReadLine());
            Console.WriteLine(" ==================================>");
        }
        avançar:
        Main();
    }
    static void Alteraçãodecadastro(){
        Console.WriteLine("<===========================>\n<=| Alteração de cadastro |=>\n<===========================>\n");
        if(quantidadeDeCadastro1.Length == 0){
            Console.WriteLine(" Não existem cadastros a serem alterados.");
            Console.ReadLine();
            goto avançar;
        }
        else if(quantidadeDeCadastro1.Length == 1){
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
            Console.WriteLine(" Cadastro alterado.\n ====================>\n");
            goto avançar1;
        }
        retorno:
        Console.WriteLine(" Quantidade de cadastros <( {0} )>\n",quantidadeDeCadastro1.Length);
        Console.Write(" Quantos cadastros deseja alterar: ");
        int alterarCadastro = int.Parse(Console.ReadLine());
        int[] alterarCadastro1 = new int[alterarCadastro];
        int[] altCadastro = new int[alterarCadastro];
        if(alterarCadastro > quantidadeDeCadastro1.Length){
            Console.WriteLine("\n A quantidade de cadastros a serem alterados não corresponde a quantidade de cadastros existentes.");
            goto retorno;
        }
        else if(alterarCadastro == 0){
            goto avançar2;
        }
        else if(alterarCadastro1.Length == quantidadeDeCadastro1.Length){
            for(int i = 0; i < alterarCadastro1.Length; i++){
                Console.Write(" Digite o seu nome: ");
                nome[i] = Console.ReadLine();
                Console.Write(" Digite a sua idade: ");
                idade[i] = int.Parse(Console.ReadLine());
                Console.Write(" Digite o seu peso: ");
                peso[i] = float.Parse(Console.ReadLine());
                Console.Write(" Digite a sua altura: ");
                altura[i] = float.Parse(Console.ReadLine());
                Console.Write(" Digite o seu sexo: ");
                sexo[i] = char.Parse(Console.ReadLine());
                Console.WriteLine(" Cadastro de número <( {0} )> alterado.\n ========================================>\n",N_deCadastros = i);
            }
        goto avançar3;
        }
        voltar:
        voltar1:
        Console.WriteLine("\n Quais cadastros deseja alterar: ");
        for(int i = 0; i < alterarCadastro1.Length; i++){
            altCadastro[i] = int.Parse(Console.ReadLine());
            if(altCadastro[i] - 1 >= quantidadeDeCadastro1.Length){
                Console.WriteLine("\n (Erro do programa)");
                goto voltar;
            }
            else if(altCadastro[i] == 0){
                Console.WriteLine("\n (Erro do programa)");
                goto voltar1;
            }
        }
        for(int i = 0; i < alterarCadastro; i++){
            Console.Write("\n Digite o seu nome: ");
            nome[altCadastro[i] - 1] = Console.ReadLine();
            Console.Write(" Digite a sua idade: ");
            idade[altCadastro[i] - 1] = int.Parse(Console.ReadLine());
            Console.Write(" Digite o seu peso: ");
            peso[altCadastro[i] - 1] = float.Parse(Console.ReadLine());
            Console.Write(" Digite a sua altura: ");
            altura[altCadastro[i] - 1] = float.Parse(Console.ReadLine());
            Console.Write(" Digite o seu sexo: ");
            sexo[altCadastro[i] - 1] = char.Parse(Console.ReadLine());
            Console.WriteLine(" Cadastro de número <( {0} )> alterado.\n ========================================>\n",N_deCadastros = altCadastro[i]);
        }
        avançar:
        avançar1:
        avançar2:
        avançar3:
        Main();
    }
    static void Impreçãodecadastro(){
        Console.WriteLine("<===========================>\n<=| Impreção de cadastros |=>\n<===========================>\n");
        N_deCadastros = 0;
        if(quantidadeDeCadastro1.Length == 0){
            Console.WriteLine(" Não existem cadastros a serem imprimidos.");
            goto avançar;
        }
        else if(quantidadeDeCadastro1.Length == 1){
            Console.WriteLine(" Cadastro de número <( {0} )>:\n Nome: {1}\n Idade: {2}\n Peso: {3}\n Altura: {4}\n Sexo: {5}\n ===============================>",N_deCadastros = 1,nome[0],idade[0],peso[0],altura[0],sexo[0]);
            goto avançar1;
        }
        retorno:
        Console.WriteLine(" Quantidade de cadastros <( {0} )>\n",quantidadeDeCadastro1.Length);
        Console.Write(" Quantos cadastros deseja imprimir: ");
        int imprimirCadastro = int.Parse(Console.ReadLine());
        int[] imprimirCadastro1 = new int[imprimirCadastro];
        int[] impCadastro = new int[imprimirCadastro];
        if(imprimirCadastro > quantidadeDeCadastro1.Length){
            Console.WriteLine("\n A quantidade de cadastros a serem imprimidos não corresponde a quantidade de cadastros existentes.");
            goto retorno;
        }
        else if(imprimirCadastro == 0){
            goto avançar2;
        }
        else if(imprimirCadastro == quantidadeDeCadastro1.Length){
            for(int i = 0; i < quantidadeDeCadastro1.Length; i++){
                N_deCadastros++;
                Console.WriteLine(" Cadastro de número <( {0} )>:\n Nome: {1}\n Idade: {2}\n Peso: {3}\n Altura: {4}\n Sexo: {5}\n ===============================>",N_deCadastros,nome[i],idade[i],peso[i],altura[i],sexo[i]);
            }
            goto avançar3;
        }
        voltar:
        voltar1:
        Console.WriteLine("\n Quais cadastros deseja imprimir: ");
        for(int i = 0; i < imprimirCadastro; i++){
        impCadastro[i] = int.Parse(Console.ReadLine());
            if(impCadastro[i] - 1 >= quantidadeDeCadastro1.Length){
                Console.WriteLine("\n (Erro do programa)");
                Console.ReadLine();
                goto voltar;
            }
            else if(impCadastro[i] == 0){
                Console.WriteLine("\n (Erro do programa)");
                Console.ReadLine();
                goto voltar1;
            }
        }
        for(int i = 0; i < imprimirCadastro; i++){
            Console.WriteLine(" Cadastro de número <( {0} )>:\n Nome: {1}\n Idade: {2}\n Peso: {3}\n Altura: {4}\n Sexo: {5}\n ===============================>",N_deCadastros = impCadastro[i],nome[impCadastro[i] - 1],idade[impCadastro[i] - 1],peso[impCadastro[i] - 1],altura[impCadastro[i] - 1],sexo[impCadastro[i] - 1]);
        }
        avançar:
        avançar1:
        avançar2:
        avançar3:
        Console.ReadLine();
        Main();
    }
    static void Excluircadastro(){
        Console.WriteLine("<======================>\n<=| Excluir cadastro |=>\n<======================>\n");
        if(quantidadeDeCadastro1.Length == 0){
            Console.WriteLine(" Não existem cadastros a serem excluidos.");
            Console.ReadLine();
            goto avançar;
        }
        else if(quantidadeDeCadastro1.Length == 1){
            quantidadeDeCadastro1 = new int[quantidadeDeCadastro1.Length - 1];
            nome = new string[nome.Length - 1];
            idade = new int[idade.Length - 1];
            peso = new float[peso.Length - 1];
            altura = new float[altura.Length - 1];
            sexo = new char[sexo.Length - 1];
            N_deCadastros = 0;
            Console.WriteLine(" Cadastro excluido.\n");
            goto avançar1;
        }
        retorno:
        Console.WriteLine(" Quantidade de cadastros <( {0} )>\n",quantidadeDeCadastro1.Length);
        Console.Write(" Quantos cadastros deseja excluir: ");
        excluirCadastro = int.Parse(Console.ReadLine());
        excluirCadastro1 = new int[excluirCadastro];
        int[] excCadastro = new int[excluirCadastro];
        if(excluirCadastro > quantidadeDeCadastro1.Length){
            Console.WriteLine(" A quantidade de cadastros a serem excluidos não corresponde a quantidade de cadastros existentes.");
            goto retorno;
        }
        else if(excluirCadastro == 0){
            goto avançar2;
        }
        else if(excluirCadastro == quantidadeDeCadastro1.Length){
            quantidadeDeCadastro1 = new int[quantidadeDeCadastro1.Length - excluirCadastro];
            nome = new string[nome.Length - excluirCadastro];
            idade = new int[idade.Length - excluirCadastro];
            peso = new float[peso.Length - excluirCadastro];
            altura = new float[altura.Length - excluirCadastro];
            sexo = new char[sexo.Length - excluirCadastro];
            N_deCadastros = 0;
            Console.WriteLine(" Todos os cadastros foram excluidos.\n");
            goto avançar3;
        }
        voltar:
        voltar1:
        Console.WriteLine("\n Quais cadastros deseja excluir:");
        for(int i = 0; i < excluirCadastro; i++){
            excCadastro[i] = int.Parse(Console.ReadLine());
            if(excCadastro[i] - 1 >= quantidadeDeCadastro1.Length){
                Console.WriteLine("\n (Erro do programa)");
                Console.ReadLine();
                goto voltar;
            }
            else if(excCadastro[i] == 0){
                Console.WriteLine("\n (Erro do programa)");
                Console.ReadLine();
                goto voltar1;
            }
        }
        Console.WriteLine();
        Array.Sort(excCadastro);
        Array.Reverse(excCadastro);
        for(int i = 0; i < excluirCadastro; i++){
            for(int ia = excCadastro[i] - 1; ia < quantidadeDeCadastro1.Length - 1; ia++){
                nome[ia] = nome[ia + 1];
                idade[ia] = idade[ia + 1];
                peso[ia] = peso[ia + 1];
                altura[ia] = altura[ia + 1];
                sexo[ia] = sexo[ia + 1];
            }
        }
        string[] armazenamentoDeNomes = new string[nome.Length - excluirCadastro];
        int[] armazenamentoDeIdades = new int[idade.Length - excluirCadastro];
        float[] armazenamentoDePesos = new float[peso.Length - excluirCadastro];
        float[] armazenamentoDeAlturas = new float[altura.Length - excluirCadastro];
        char[] armazenamentoDeSexos = new char[sexo.Length - excluirCadastro];
        Array.Copy(nome,armazenamentoDeNomes,nome.Length - excluirCadastro);
        Array.Copy(idade,armazenamentoDeIdades,idade.Length - excluirCadastro);
        Array.Copy(peso,armazenamentoDePesos,peso.Length - excluirCadastro);
        Array.Copy(altura,armazenamentoDeAlturas,altura.Length - excluirCadastro);
        Array.Copy(sexo,armazenamentoDeSexos,sexo.Length - excluirCadastro);
        quantidadeDeCadastro1 = new int[quantidadeDeCadastro1.Length - excluirCadastro];
        nome = new string[nome.Length - excluirCadastro];
        idade = new int[idade.Length - excluirCadastro];
        peso = new float[peso.Length - excluirCadastro];
        altura = new float[altura.Length - excluirCadastro];
        sexo = new char[sexo.Length - excluirCadastro];
        Array.Copy(armazenamentoDeNomes,nome,nome.Length);
        Array.Copy(armazenamentoDeIdades,idade,idade.Length);
        Array.Copy(armazenamentoDePesos,peso,peso.Length);
        Array.Copy(armazenamentoDeAlturas,altura,altura.Length);
        Array.Copy(armazenamentoDeSexos,sexo,sexo.Length);
        Array.Sort(excCadastro);
        for(int i = 0; i < excluirCadastro; i++){
            Console.WriteLine(" Cadastro de número <( {0} )> excluido.\n",N_deCadastros = excCadastro[i]);
        }
        avançar:
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
        Console.WriteLine(" Volte sempre. ;)");
        SA = 1;
    }   
}