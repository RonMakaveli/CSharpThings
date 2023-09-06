using System.Windows.Forms;

namespace ProvedorInternet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ListCidades.SelectedIndex == -1)
            {
                label4.Text = "Por favor, selecione uma cidade.";
                return;
            }

            int cidadeSelecionada = ListCidades.SelectedIndex;

            decimal valorVelocidade = 0.00M;
            if (RbtDez.Checked)
            {
                valorVelocidade = 0.00M;
            }
            else if (RbtTrinta.Checked)
            {
                valorVelocidade = 30.00M;
            }
            else if (RbtSessenta.Checked)
            {
                valorVelocidade = 60.00M;
            }

            decimal valorOpcionais = 0.00M;
            if (OptPromo1.Checked)
            {
                valorOpcionais += 10.00M;
            }
            if (OptPromo2.Checked)
            {
                valorOpcionais += 15.00M;
            }

            decimal[] valoresBase = { 140.00M, 140.00M, 135.00M, 120.00M, 120.00M, 120.00M, 120.00M, 120.00M, 120.00M, 120.00M, 120.00M, 120.00M };
            decimal mensalidadeTotal = valoresBase[cidadeSelecionada] + valorVelocidade + valorOpcionais;

            label4.Text = $"Mensalidade total: R${mensalidadeTotal:F2}";
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ronald Gustavo - 36283631.", "Sobre");
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}