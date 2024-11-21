class Produto
{
    public string name;
    public double price;
    public int qtdEstoque;

    public Produto(){
        this.name = name;
        this.price = price;
        this.qtdEstoque = qtdEstoque;
    }  
    public void Run(){
        System.Console.WriteLine($"Qual o nome do produto?");
        this.name = Console.ReadLine();
        System.Console.WriteLine($"Qual o valor do produto?");
        this.price = double.Parse(Console.ReadLine());
        System.Console.WriteLine($"Qual a quantidade do produto?");
        this.qtdEstoque = int.Parse(Console.ReadLine());

        System.Console.WriteLine($"{this.name}, preço unitário: R$={this.price},00 , quantidade: {this.qtdEstoque}, valor estoque {this.qtdEstoque * this.price}");
    }
    public int RealizaEntrada(Produto produto){
        int qtdFinal;
        int qtdEntrada;
        Console.WriteLine($"Qual a quantidade você deseja adicionar ao produto {produto.name}?");
        qtdEntrada = int.Parse(System.Console.ReadLine());
        qtdFinal = produto.qtdEstoque + qtdEntrada;
        this.qtdEstoque = qtdFinal;
        System.Console.WriteLine($"Dados atualizados: {this.name}, {this.price}, quantidade atual em estoque: {this.qtdEstoque}, valor total atual em estoque R$={this.qtdEstoque * this.price},00");
        return qtdFinal;
    }
    
    public void MostraDadosProduto(){
        Console.WriteLine($"Produto: {this.name}");
        Console.WriteLine($"Valor do Produto: {this.price}");
        Console.WriteLine($"Quantidade em estoque: {this.qtdEstoque}");
    }
    public void RetiraProduto(Produto produto){
        int qtdFinal, qtdSaida;
        System.Console.WriteLine($"Qual a quantidade você deseja retirar do estoque do produto{produto.name}?");
        qtdSaida = int.Parse(Console.ReadLine());
        qtdFinal = produto.qtdEstoque - qtdSaida;
        this.qtdEstoque = qtdFinal;
        System.Console.WriteLine($"Dados atualizados: {this.name}, {this.price}, quantidade atual em estoque: {this.qtdEstoque}, valor total atual em estoque: R$={this.qtdEstoque * this.price},00");
    }
}