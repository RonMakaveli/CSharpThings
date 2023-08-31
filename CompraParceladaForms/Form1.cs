namespace CompraParcelada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float valorFinalCompra = 0, valorParcelas;
            try
            {
                float valorCompra = Convert.ToSingle(txtValorCompra.Text);
                int qtdeParc = Convert.ToInt16(txtQtdeParc.Text);

                if (qtdeParc < 0)
                {
                    MessageBox.Show("a Quantidade de parcelas deve ser positiva", "Erro");
                }
                else if (qtdeParc == 0 || qtdeParc == 1)
                {
                    valorFinalCompra = valorCompra;
                    valorParcelas = valorCompra;
                }
                else if (qtdeParc <= 3)
                {
                    valorFinalCompra = valorCompra + 5.0f / 100.0f * valorCompra;
                    valorParcelas = valorFinalCompra / qtdeParc;
                }
                else
                {
                    valorFinalCompra = valorCompra + 10.0f / 100.0f * valorCompra;
                    valorParcelas = valorFinalCompra / qtdeParc;
                }

                lblValorParcelas.Text = "Valor das parcelas: " + qtdeParc;
                lblTotalCompra.Text = "Valor final da compra: " + valorFinalCompra;
            }
            catch (Exception)
            {
                MessageBox.Show("Digite os dados corretos", "Erro");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblTotalCompra_Click(object sender, EventArgs e)
        {

        }
    }
}

