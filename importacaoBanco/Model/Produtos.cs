using importacaoBanco.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace importacaoBanco.Model
{
    internal class Produtos
    {
        public Produtos()
        {

        }
        public Produtos(int id, string codEAN, string nome, double preco, int estoque)
        {
            Id = id;
            CodEAN = codEAN;
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }

        public int Id { get; set; }
        public string CodEAN { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Estoque { get; set; }

       // StreamWriter sw;
     

        public void CarregaTabProduto()
        {
          
            try
            {
                StreamWriter sw = new StreamWriter(@"C:\Users\Elias Couto\source\repos\importacaoBanco\importacaoBanco\Data\dbo.produtos.txt");
                Banco bd = new Banco();
                SqlConnection cn = bd.abrirConexao();
                SqlCommand command = new SqlCommand("select CodEAN, Nome, preco, estoque from dbo.produtos where estoque>0 ", cn);
                SqlDataReader dataReader = command.ExecuteReader();

                sw.WriteLine("Id - CodEAN - Nome = preco - estoque");
                while (dataReader.Read())
                {
                    Id++;
                    Id += Id;
                    CodEAN = dataReader.GetString(0);
                    Nome = dataReader.GetString(1);
                    Preco = dataReader.GetDouble(2);
                    Estoque = dataReader.GetInt32(3);
                    sw.WriteLine(Id + "-" + CodEAN + "-" + Nome + "-" + Preco + "-" + Estoque);

                }
                sw.Close();
                MessageBox.Show("Arquivo dbo.produtos.txt, gerado com sucesso!", "Sucesso!",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                return;
            }

            catch (Exception ex)
            {

                MessageBox.Show(" " + ex.Message);
                return;
            }
            

            
        }


    }
}
