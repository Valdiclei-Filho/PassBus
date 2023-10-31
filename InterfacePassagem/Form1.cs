using MySql.Data.MySqlClient;

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
            var Conexao = $"server=127.0.0.1; User Id=root; database=atividade; password=Chamex13";
            MySqlConnection COnexaoBD = new MySqlConnection(Conexao);
            COnexaoBD.Open();
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
    }
}