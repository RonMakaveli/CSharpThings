using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WFGravarDados
{
    public partial class Form1 : Form
    {
        private MySqlConnection Conexao;
        private string data_source = "datasource=localhost;username=root" + "database=db_agenda;password=12345;";
        public Form1()
        {
            InitializeComponent();

            lstContatos.View = View.Details;
            lstContatos.AllowColumnReorder = true;
            lstContatos.FullRowSelect = true;
            lstContatos.GridLines = true;

            //Definição das colunas no listView (Nome da coluna, tamanho e alinhamento)
            lstContatos.Columns.Add("ID", 30, HorizontalAlignment.Left);
            lstContatos.Columns.Add("NOME", 150, HorizontalAlignment.Left);
            lstContatos.Columns.Add("E-MAIL", 150, HorizontalAlignment.Left);
            lstContatos.Columns.Add("TELEFONE", 30, HorizontalAlignment.Left);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEnviar_click(object sender, EventArgs e)
        {
            try
            {
                //Criar conexão
                Conexao = new MySqlConnection(data_source);
                string sql = "INSERT INTO contatos(nome, email, telefone " + "VALUES" + 
                    "('" + txtNome.Text + "', '" + txtEmail.Text + "', '" + txtTelefone.Text + "')";


                //Executar comando Insert
                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                Conexao.Open();
                comando.ExecuteReader();
                MessageBox.Show("Inclusão efetuada!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void btnBuscar_click(object sender, EventArgs e)
        {
            try
            {
                string q = "'%" + txtBuscar.Text + "%'";
                //Criar conexão
                Conexao = new MySqlConnection(data_source);
                string sql = "SELECT * " +
                             "FROM contatos WHERE nome " +
                             "LIKE " + q + "OR email LIKE " + q;

                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                Conexao.Open();
                MySqlDataReader reader = comando.ExecuteReader();
                lstContatos.Items.Clear();
                while (reader.Read())
                {
                    string[] linha =
                    {
                    reader.GetString(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                };
                    var linha_listview = new ListViewItem(linha);
                    lstContatos.Items.Add(linha_listview);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close(); 
            }
        }
    }
}
