using System;
using System.Windows.Forms;

namespace Exercicio
{
    public partial class frmMedias : Form
    {
        public frmMedias()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnCalcMed_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3;

            if (double.TryParse(BoxNota1.Text, out nota1) &&
                double.TryParse(BoxNota2.Text, out nota2) &&
                double.TryParse(BoxNota3.Text, out nota3))
            {
                double media = (nota1 + nota2 + nota3) / 3.0;

                lblMedCalc.Text = $"{media:F2}";

                if (media >= 7.0)
                {
                    situacao.Text = "APROVADO!";
                    situacao.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    situacao.Text = "REPROVADO!";
                    situacao.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira notas válidas.");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtMat.Text = "";
            BoxNota1.Text = "";
            BoxNota2.Text = "";
            BoxNota3.Text = "";
            lblMedCalc.Text = "";
            situacao.Text = "";
            situacao.ForeColor = System.Drawing.Color.Black;
        }

        private void situacao_Click(object sender, EventArgs e)
        {

        }


        private void BoxNota1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BoxNota2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BoxNota3_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNome_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMat_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

