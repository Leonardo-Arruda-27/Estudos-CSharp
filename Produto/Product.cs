

namespace Produto
{
    class Product
    {
        public string Name;
        public double Price;
        public int Quantity;

        public double valorTotalEmEstoque()
        {
            return Price * Quantity;
        }

        public void AdicionarProdutos(int quantity)
        {
            Quantity += quantity;
            
        }
        public void RemoverProdutos(int quantity)
        {
            Quantity -= quantity;

        }
    }
}
