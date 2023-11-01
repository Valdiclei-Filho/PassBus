using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacePassagem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Conexao = $"server=127.0.0.1; User Id=root; database=atividade; password=Chamex13";
            MySqlConnection ConexaoBD = new MySqlConnection(Conexao);

            try
            {
                ConexaoBD.Open();

                string filtro = Filtro.Text;

                MySqlCommand command = new MySqlCommand("ExcluirClienteEPassagem", ConexaoBD);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@filtro", filtro);

                command.ExecuteNonQuery();
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
    }
}
