using importacaoBanco.Model;

namespace importacaoBanco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerarArquivoClientes_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.CarregarTabCliente();
        }

        private void BtnArquivoProduto_Click(object sender, EventArgs e)
        {
            Produtos produtos = new Produtos();
            produtos.CarregaTabProduto();
        }
    }
}