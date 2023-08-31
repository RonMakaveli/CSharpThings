namespace PequenaCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b, resultado = 0.0;
                a = Convert.ToDouble(txtDado1.Text);
                b = Convert.ToDouble(txtDado2.Text);
                if (rbMedia.Checked)
                {
                    resultado = (a + b) / 2.0;
                }
                else if (rbMediaPond.Checked)
                {
                    resultado = (2.0 * a + b) / 3.0;
                }
                else
                {
                    resultado = Math.Pow(a, b);
                }
                lblResultado.Text = "Resultado: " + resultado.ToString("0.00");
            }
            catch {
                MessageBox.Show("Por favor, verifique os dados", "Erro");
            }
        }
    }
}