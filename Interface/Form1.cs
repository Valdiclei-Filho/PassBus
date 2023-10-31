using MySql.Data.MySqlClient;

namespace Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var strConexao = "server=127.0.0.1:3306;uid=root;pwd=root;database=atividade";
            var conexao = new MySqlConnection(strConexao);
            conexao.Open();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}