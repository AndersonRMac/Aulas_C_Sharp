class Produto
{
    public string Name;
    public double Price;
    public int QtdEstoque;

    public Produto(string name, double price,  int qtdEstoque){
        Name = name;
        Price = price;
        QtdEstoque = qtdEstoque;
        
        Console.Write($"Dados do produto: NOME: {Name}, PREÇO: R${Price},00 reais, QUANTIDADE EM ESTOQUE: {QtdEstoque}, VALOR EM ESTOQUE: {price * QtdEstoque} ");
    }

    /*
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
    */
}