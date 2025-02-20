// See https://aka.ms/new-console-template for more information


using System.Globalization;

    /*Triangulo x, y;
    x = new Triangulo("X");
    y = new Triangulo("Y");
    x.calculaArea();
    y.calculaArea();
    x.comparaArea(x,y);

    System.Console.WriteLine("===========================================EXERCICIO PESSOA E IDADE====================================================");
    
    Pessoa pessoa,pessoa1, pessoa2;
    pessoa1 = new Pessoa("Amanda", 29);
    pessoa2 = new Pessoa("Anderson", 30);
    pessoa1.comparaIdade(pessoa1, pessoa2);

        System.Console.WriteLine("========================================EXERCICIO FUNCIONÁRIO E SALARIO=======================================================");

    Funcionario funcionario1, funcionario2;
    funcionario1 = new Funcionario("João");
    funcionario2 = new Funcionario("Pedro");

    funcionario1.run();
    funcionario2.run();

    funcionario1.comparaSalario(funcionario1, funcionario2);*/

        System.Console.WriteLine("========================================EXERCICIO ESTOQUE=======================================================");

        Console.Write($"Qual o nome do produto?");
        string nome = Console.ReadLine();
        Console.Write($"Qual o valor do produto?");
        double preco = double.Parse(Console.ReadLine());
        Console.Write($"Qual a quantidade do produto?");
        int estoque = int.Parse(Console.ReadLine());

         Produto p = new Produto(nome, preco, estoque);


    //FAZER EXERCICIOS EM FORMA DE CLASSE PARA SÓ INSTANCIAR NA CLASSE PRINCIPAL
