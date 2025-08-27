namespace ProjetoLoja.Repositorios
{
    public class ProdutoRepositorio
    {
        // DECLARANDO STRING DE CONEXÃO 
        private readonly string _connectionString;

        public ProdutoRepositorio(string connectionString)
        {
            _connectionString = connectionString;
        }
    }
}
