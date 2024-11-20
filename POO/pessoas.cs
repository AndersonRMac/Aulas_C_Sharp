class Pessoa
{
    public string nome;
    public int idade;

    public Pessoa(string nome, int idade){
        this.nome = nome;
        this.idade = idade;
    }
    public string calculaMaiorIdade(Pessoa pessoa1, Pessoa pessoa2){

        string resultado;
        if (pessoa1.idade > pessoa2.idade)
        {
            resultado = $"A pessoa mais velhar é: {pessoa1.nome}";
            Console.WriteLine(resultado);
            return resultado;
        }
        else{
            resultado = $"A pessoa mais velhar é: {pessoa2.nome}";
            System.Console.WriteLine(resultado);
            return resultado;
        } 
    }

}