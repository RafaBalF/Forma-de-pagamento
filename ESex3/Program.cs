// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
double preco = 10;
Console.WriteLine("O preco do produto é R$" + preco + "escolha forma de pagamento desejada");
Console.WriteLine("Digite 1 para pagamento a vista em dinheiro ou cheque");
Console.WriteLine("Digite 2 para pagamento a vista no cartão de crédito");
Console.WriteLine("Digite 3 para pagamento parcelado em duas vezes");
Console.WriteLine("Digite 4 para pagamento parcelado em três vezes");

int x = Convert.ToInt32(Console.ReadLine());

switch(x)
{
    case 1:
        Console.WriteLine("Devido ao pagamento a vista em dinheiro ou cheque você receberá um desconto de 10%.");
        preco = preco - preco * 0.1;
        Console.WriteLine("O preço do seu produto será R$" + preco);
        break;

    case 2:
        Console.WriteLine("Devido ao pagamento a vista no cartão de crédito você receberá um desconto de 5%.");
        preco = preco - preco * 0.05;
        Console.WriteLine("O preço do seu produto será R$" + preco);
        break;
    
    case 3:
        Console.WriteLine("Devido ao pagamento parcelado em 2 vezes o valor do produto nao terá alterações.");
        double parcela = preco / 2;
        Console.WriteLine("O preço do seu produto será duas parcelas no valor de R$" + parcela + " totalalizando R$" + preco);
        break;

    case 4:
        Console.WriteLine("Devido ao pagamento parcelado em 3 vezes voce recebera um juros de 10%.");
        double parcela3 = preco / 3 + (preco * 0.1);
        preco = preco * 0.3 + preco;
        Console.WriteLine("O preço do seu produto será três parcelas no valor de R$" + Math.Round(parcela3, 2) + " totalalizando R$" + preco);
        break;

    default:
        Console.WriteLine("Opção invalida");
        break;
        
}
