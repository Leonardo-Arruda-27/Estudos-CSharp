namespace Produto
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();

            Console.WriteLine("Entre com os dados dos produtos:");
            product.Name = Console.ReadLine();
            product.Price = double.Parse(Console.ReadLine());
            product.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do produto: {product.Name}, R${product.Price}, {product.Quantity} unidades\nTotal: R${product.valorTotalEmEstoque()}");

            Console.WriteLine();
            Console.Write($"Digite o numero de produtos a ser adicionado ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            product.AdicionarProdutos(qtd);

            Console.WriteLine();
            Console.WriteLine($"Dados do produto atualizado: {product.Name}, R${product.Price}, {product.Quantity} unidades\nTotal: R${product.valorTotalEmEstoque()}");

            Console.WriteLine();
            Console.Write($"Digite o numero de produtos a ser removido do estoque: ");
            qtd = int.Parse(Console.ReadLine());
            product.RemoverProdutos(qtd);

            Console.WriteLine();
            Console.WriteLine($"Dados do produto atualizado: {product.Name}, R${product.Price}, {product.Quantity} unidades\nTotal: R${product.valorTotalEmEstoque()}");

        }
    }
}