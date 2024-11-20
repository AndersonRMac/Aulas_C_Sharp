// See https://aka.ms/new-console-template for more information


using System.Globalization;

    Triangulo x, y;
    x = new Triangulo("X");
    y = new Triangulo("Y");
    x.calculaArea();
    y.calculaArea();
    x.comparaArea(x,y);

    System.Console.WriteLine("===============================================================================================");
    
    Pessoa pessoa,pessoa1, pessoa2;
    pessoa1 = new Pessoa("Amanda", 29);
    pessoa2 = new Pessoa("Anderson", 30);
    pessoa1.comparaIdade(pessoa1, pessoa2);
