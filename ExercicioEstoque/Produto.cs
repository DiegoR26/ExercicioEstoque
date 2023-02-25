namespace ExercicioEstoque
{
    internal class Produto
    {

        public string Nome { get; private set; }
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public void SetNome(string nome)
        {
            if (nome != null)
            {
                Nome = nome;
            }
            else
            {
                Console.WriteLine("Nome inválido! Nenhuma alteração realizada");
            }
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome
                + "; $ "
                + Preco.ToString("F2")
                + "; "
                + Quantidade
                + " unidades; $ "
                + ValorTotalEmEstoque().ToString("F2");
        }
    }
}
