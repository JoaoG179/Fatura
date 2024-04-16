/*Crie uma classe chamada Fatura que possa ser utilizado por uma loja de suprimentos de informática para representar uma fatura de um item vendido na loja. Uma fatura deve incluir as seguintes informações como atributos:
o número do item faturado,
a descrição do item,
a quantidade comprada do item e
o preço unitário do item.
Sua classe deve ter um construtor que inicialize os quatro atributos. Se a quantidade não for positiva, ela deve ser configurada como 0. Se o preço por item não for positivo ele deve ser configurado como 0.0. Forneça os métodos get/set para cada variável de instância. Além disso, forneça um método chamado calcular_valor_fatura que calcula o valor da fatura (isso é, multiplica a quantidade pelo preço por item) e depois retorna o valor. Escreva também um programa de teste (main) que demonstra as capacidades da classe Fatura.*/

using System;

class Fatura{
    private int numero, quantidade;
    private double preco;
    private string descricao;

    //gets e sets
    public int id{
      get {return numero;}
      set {numero = value;}
    }
    public string info{
        get {return descricao;}
        set {descricao = value;}
    }
    public int qntd{
      get{return quantidade;}
      set{
        if (value < 0)
        {
          quantidade = 0;
          }else{quantidade = value;}
        }
    }
    public double pri{
      get {return preco;}
      set{
        if (value < 0){
        preco = 0.0;
        }else{preco = value;}
        }
    }

    //inicializar o produto
    public void inicializarFatura(int numero, string descricao, int quantidade, double preco){
      id = numero;
      info = descricao;
      qntd = quantidade;
      pri = preco;
    }

    //metodo de impressão
  public void imprimir(){
      Console.WriteLine("Número: {0}", this.numero);
      Console.WriteLine("Descrição: {0}", this.descricao);
      Console.WriteLine("Preço: {0}", this.preco);
      Console.WriteLine("Quantidade: {0}", this.quantidade);
    }

    //metodo de calculo da fatura
  public double calcular_valor_fatura(){
    double valorFatura = this.preco * this.quantidade;
    Console.WriteLine("Valor da fatura: {0}", valorFatura);
    return valorFatura;
  }
}