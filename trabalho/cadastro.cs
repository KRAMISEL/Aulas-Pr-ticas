using System;
class program{
    static int N_deCadastros = 0;
    static int[] quantidadeDeCadastro1 = new int[0],idade = new int[0];
    static string[] nome = new string[0];
    static float[] peso = new float[0],altura = new float[0];
    static char[] sexo = new char[0];
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
        string[] armazenamentoDeNomes = new string[nome.Length];
        int[] armazenamentoDeIdades = new int[idade.Length];
        float[] armazenamentoDePesos = new float[peso.Length],armazenamentoDeAlturas = new float[altura.Length];
        char[] armazenamentoDeSexos = new char[sexo.Length];
        Array.Copy(nome, armazenamentoDeNomes, nome.Length);
        Array.Copy(idade, armazenamentoDeIdades, idade.Length);
        Array.Copy(peso, armazenamentoDePesos, peso.Length);
        Array.Copy(altura, armazenamentoDeAlturas, altura.Length);
        Array.Copy(sexo, armazenamentoDeSexos, sexo.Length);
        if(quantidadeDeCadastro1.Length > 0){
            Console.WriteLine(" Quantidade de cadastros.: <( {0} )>\n",quantidadeDeCadastro1.Length);
        }
        Console.Write(" Quantos cadastros deseja fazer: ");
        int quantidadeDeCadastro = int.Parse(Console.ReadLine());
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
        Array.Copy(armazenamentoDeNomes, nome, nome.Length - quantidadeDeCadastro);
        Array.Copy(armazenamentoDeIdades, idade, idade.Length - quantidadeDeCadastro);
        Array.Copy(armazenamentoDePesos, peso, peso.Length - quantidadeDeCadastro);
        Array.Copy(armazenamentoDeAlturas, altura, altura.Length - quantidadeDeCadastro);
        Array.Copy(armazenamentoDeSexos, sexo, sexo.Length - quantidadeDeCadastro);
        }
        for(int i = 0; i < quantidadeDeCadastro; i++){
            Console.WriteLine("\n Cadastro de número.: <( {0} )>",N_deCadastros++ + 1);
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
        Console.WriteLine();
        Main();
    }
    static void Alteraçãodecadastro(){
        Console.WriteLine("\n<===========================>\n<=| Alteração de cadastro |=>\n<===========================>\n");
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
            Console.WriteLine(" Cadastro alterado.\n ====================>");
            goto avançar1;
        }
        retorno:
        Console.WriteLine(" Quantidade de cadastros.: <( {0} )>\n",quantidadeDeCadastro1.Length);
        Console.Write(" Quantos cadastros deseja alterar: ");
        int alterarCadastro = int.Parse(Console.ReadLine());
        int[] altCadastro = new int[alterarCadastro];
        if(alterarCadastro > quantidadeDeCadastro1.Length){
            Console.WriteLine("\n A quantidade de cadastros a serem alterados não corresponde a quantidade de cadastros existentes.");
            goto retorno;
        }
        else if(alterarCadastro == 0){
            goto avançar2;
        }
        else if(alterarCadastro == quantidadeDeCadastro1.Length){
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
                Console.WriteLine(" Cadastro de número {0} alterado.\n ========================================>",quantidadeDeCadastro1[i] + 1);
            }
        goto avançar3;
        }
        voltar:
        if(alterarCadastro == 1){
            Console.WriteLine("\n Qual cadastro deseja alterar: ");
        }else{
            Console.WriteLine("\n Quais cadastros deseja alterar: ");
        }
        for(int i = 0; i < altCadastro.Length; i++){
            int A = int.Parse(Console.ReadLine());
            altCadastro[i] = A - 1;
            if(altCadastro[i] >= quantidadeDeCadastro1.Length || altCadastro[i] == -1){
                Console.WriteLine("\n ERRO:/0000001.0\n Falha na indentificação do cadastro.");
                Console.ReadLine();
                goto voltar;
            }
        }
        for(int i = 0; i < altCadastro.Length; i++){
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
        avançar1:
        avançar2:
        avançar3:
        Console.WriteLine();
        avançar:
        Main();
    }
    static void Impreçãodecadastro(){
        Console.WriteLine("\n<===========================>\n<=| Impreção de cadastros |=>\n<===========================>\n");
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
        Console.WriteLine(" Quantidade de cadastros.: <( {0} )>\n",quantidadeDeCadastro1.Length);
        Console.Write(" Quantos cadastros deseja imprimir: ");
        int imprimirCadastro = int.Parse(Console.ReadLine());
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
                Console.Write("\n Cadastro de número {0}:\n Nome: {1}\n Idade: {2}\n Peso: {3}\n Altura: {4}\n Sexo: {5}\n ===============================>\n",quantidadeDeCadastro1[i] + 1,nome[i],idade[i],peso[i],altura[i],sexo[i]);
            }
            goto avançar3;
        }
        voltar:
        Console.WriteLine("\n <| Área de Impreção de Cadastro |>");
        if(imprimirCadastro == 1){
            Console.WriteLine("\n Qual cadastro deseja imprimir: ");
        }else{
            Console.WriteLine("\n Quais cadastros deseja imprimir: ");
        }
        for(int i = 0; i < impCadastro.Length; i++){
            int A = int.Parse(Console.ReadLine());
            impCadastro[i] = A - 1;
            if(impCadastro[i] >= quantidadeDeCadastro1.Length || impCadastro[i] == -1){
                Console.WriteLine("\n ERRO:/0000002.0\n Falha na indentificação do cadastro.");
                Console.ReadLine();
                goto voltar;
            }
        }
        for(int i = 0; i < impCadastro.Length; i++){
            Console.Write("\n Cadastro de número {0}:\n Nome: {1}\n Idade: {2}\n Peso: {3}\n Altura: {4}\n Sexo: {5}\n ===============================>\n",impCadastro[i] + 1,nome[impCadastro[i]],idade[impCadastro[i]],peso[impCadastro[i]],altura[impCadastro[i]],sexo[impCadastro[i]]);
        }
        avançar:
        avançar1:
        avançar2:
        avançar3:
        Console.ReadLine();
        Main();
    }
    static void Excluircadastro(){
        Console.WriteLine("\n<======================>\n<=| Excluir cadastro |=>\n<======================>\n");
        if(quantidadeDeCadastro1.Length == 0){
            Console.WriteLine(" Não existem cadastros a serem excluidos.");
            Console.ReadLine();
            goto avançar0;
        }
        else if(quantidadeDeCadastro1.Length == 1){
            quantidadeDeCadastro1 = new int[quantidadeDeCadastro1.Length - 1];
            nome = new string[nome.Length - 1];
            idade = new int[idade.Length - 1];
            peso = new float[peso.Length - 1];
            altura = new float[altura.Length - 1];
            sexo = new char[sexo.Length - 1];
            N_deCadastros = 0;
            Console.WriteLine(" Cadastro excluido.");
            goto avançar1;
        }
        retorno:
        Console.WriteLine(" Quantidade de cadastros.: <( {0} )>\n",quantidadeDeCadastro1.Length);
        Console.Write(" Quantos cadastros deseja excluir: ");
        int excluirCadastro = int.Parse(Console.ReadLine());
        int [] excCadastro = new int[excluirCadastro],armazenamentoDeIdades = new int[idade.Length - excluirCadastro];
        string[] armazenamentoDeNomes = new string[nome.Length - excluirCadastro];
        float[] armazenamentoDePesos = new float[peso.Length - excluirCadastro],armazenamentoDeAlturas = new float[altura.Length - excluirCadastro];
        char[] armazenamentoDeSexos = new char[sexo.Length - excluirCadastro];
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
            Console.Write("\n Todos os cadastros foram excluidos.");
            goto avançar3;
        }
        voltar:
        Console.WriteLine("\n <| Área para Excluir Cadastro |>");
        if(excluirCadastro == 1){
            Console.WriteLine("\n Qual cadastro deseja excluir:");
        }else{
            Console.WriteLine("\n Quais cadastros deseja excluir:");
        }
        for(int i = 0; i < excCadastro.Length; i++){
            int A = int.Parse(Console.ReadLine());
            excCadastro[i] = A - 1;
            if(excCadastro[i] >= quantidadeDeCadastro1.Length || excCadastro[i] == -1){
                Console.WriteLine("\n ERRO:/0000003.0\n Falha na indentificação do cadastro.");
                Console.ReadLine();
                goto voltar;
            }
        }
        Array.Sort(excCadastro);
        Array.Reverse(excCadastro);
        for(int i = 0; i < excCadastro.Length; i++){
            for(int ia = excCadastro[i]; ia < quantidadeDeCadastro1.Length - 1; ia++){
                nome[ia] = nome[ia + 1];
                idade[ia] = idade[ia + 1];
                peso[ia] = peso[ia + 1];
                altura[ia] = altura[ia + 1];
                sexo[ia] = sexo[ia + 1];
            }
        }
        Array.Copy(nome, armazenamentoDeNomes, nome.Length - excluirCadastro);
        Array.Copy(idade, armazenamentoDeIdades, idade.Length - excluirCadastro);
        Array.Copy(peso, armazenamentoDePesos, peso.Length - excluirCadastro);
        Array.Copy(altura, armazenamentoDeAlturas, altura.Length - excluirCadastro);
        Array.Copy(sexo, armazenamentoDeSexos, sexo.Length - excluirCadastro);
        quantidadeDeCadastro1 = new int[quantidadeDeCadastro1.Length - excluirCadastro];
        nome = new string[nome.Length - excluirCadastro];
        idade = new int[idade.Length - excluirCadastro];
        peso = new float[peso.Length - excluirCadastro];
        altura = new float[altura.Length - excluirCadastro];
        sexo = new char[sexo.Length - excluirCadastro];
        Array.Copy(armazenamentoDeNomes, nome, nome.Length);
        Array.Copy(armazenamentoDeIdades, idade, idade.Length);
        Array.Copy(armazenamentoDePesos, peso, peso.Length);
        Array.Copy(armazenamentoDeAlturas, altura, altura.Length);
        Array.Copy(armazenamentoDeSexos, sexo, sexo.Length);
        Array.Sort(excCadastro);
        N_deCadastros = quantidadeDeCadastro1.Length;
        for(int i = 0; i < excCadastro.Length; i++){
            Console.WriteLine("\n Cadastro de número {0} excluido.",excCadastro[i] + 1);
        }
        avançar1:
        avançar2:
        avançar3:
        Console.WriteLine();
        avançar0:
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