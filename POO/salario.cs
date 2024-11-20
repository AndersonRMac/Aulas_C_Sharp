using System.Reflection.Metadata.Ecma335;
using System.Xml.XPath;

class Funcionario
{
    string name = "";
    double salario = 0;

    public Funcionario(string name){
        this.name = name;
    }

    public void run(){
        System.Console.WriteLine($"Qual o salário do funcionário {this.name}?");
        this.salario = double.Parse(Console.ReadLine());
    }

    public string comparaSalario(Funcionario funcionario1, Funcionario funcionario2){
        string result = "";
        if (funcionario1.salario > funcionario2.salario){
            result = $"O maior salário é do {funcionario1.name}";
            System.Console.WriteLine(result);
            return result;
        }else
        {
            result = $"O maior salário é do {funcionario2.name}";
            System.Console.WriteLine(result);
            return result;
        }
    } 
}