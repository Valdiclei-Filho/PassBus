using MySql.Data.MySqlClient;
using System.Data;

namespace InterfacePassagem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            string Conexao = $"server=127.0.0.1; User Id=root; database=atividade; password=Chamex13";
            MySqlConnection ConexaoBD = new MySqlConnection(Conexao);

            try
            {
                MySqlCommand InserirCliente = new MySqlCommand("InserirCliente", ConexaoBD);
                InserirCliente.CommandType = CommandType.StoredProcedure;
                InserirCliente.Parameters.AddWithValue("@nome", nome_Cliente.Text);
                InserirCliente.Parameters.AddWithValue("@idade", idade_Cliente.Text);
                InserirCliente.Parameters.AddWithValue("@cpf", cpf_Cliente.Text);

                MySqlCommand InserirPassagem = new MySqlCommand("InserirPassagem", ConexaoBD);
                InserirPassagem.CommandType = CommandType.StoredProcedure;
                InserirPassagem.Parameters.AddWithValue("@poltrona", Poltrona.Text);
                InserirPassagem.Parameters.AddWithValue("@destino", Destino.Text);
                InserirPassagem.Parameters.AddWithValue("@horarioP", horario_Partida.Text);
                InserirPassagem.Parameters.AddWithValue("@horarioC", horario_Chegada.Text);
                InserirPassagem.Parameters.AddWithValue("@forma_pagamento", forma_Pagamento.Text);
                InserirPassagem.Parameters.AddWithValue("@valor", Valor.Text);

                ConexaoBD.Open();

                InserirCliente.ExecuteNonQuery();
                InserirPassagem.ExecuteNonQuery();

                MessageBox.Show("Informações Inseridas");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ConexaoBD.Close();
            }

        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            Form2 filtro = new Form2();
            filtro.ShowDialog();
        }
    }
}