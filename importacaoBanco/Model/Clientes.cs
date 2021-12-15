using importacaoBanco.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace importacaoBanco.Model
{
    internal class Clientes
    {
        //StreamWriter sw;


        public Clientes()
        {

        }
        public Clientes(int id, string cpf, string nome, string telefone, string email)
        {
            Id = id;
            Cpf = cpf;
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }

        public int Id { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }


        public void CarregarTabCliente()
        {
           
            try
            {
                StreamWriter sw = new StreamWriter(@"C:\Users\Elias Couto\source\repos\importacaoBanco\importacaoBanco\Data\dbo.clientes.txt");
                Banco bd = new Banco();
                SqlConnection cn = bd.abrirConexao();
                SqlCommand command = new SqlCommand(" select cpf,Nome,isnull(Telefone,' '),Email from dbo.clientes where Nome<>' ' or nome<>null ", cn);
                SqlDataReader dataReader = command.ExecuteReader();

                sw.WriteLine("Id - Cpf  - Nome - Telefone - Email");
                while (dataReader.Read())
                {
                    Id++;
                    Id = Id;
                    Cpf = dataReader.GetString(0);
                    Nome = dataReader.GetString(1);
                    Telefone = dataReader.GetString(2);
                    Email = dataReader.GetString(3);
                    sw.WriteLine(Id + "-" + Cpf + "-" + Nome + "-" + Telefone + "-" + Email);


                }
                sw.Close();
                MessageBox.Show("Arquivo dbo.clientes.txt, gerado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {

                MessageBox.Show(" " + ex.Message);
                
            }
           

        }



    }

}
