using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MostraFiguras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Dictionary<RadioButton, (string imagePath, string description)> optionData = new Dictionary<RadioButton, (string, string)>();

        public void Form1_Load(object sender, EventArgs e)
        {
            optionData.Add(rdBtn1, ("../../Resources/mexico.png", "O México possui uma rica história que remonta a civilizações antigas como os astecas, maias e olmecas. Em 1521, os espanhóis liderados por Hernán Cortés conquistaram o México, estabelecendo o domínio colonial que durou até a independência em 1821. O país enfrentou uma série de conflitos, incluindo a Revolução Mexicana no início do século XX. Hoje, o México é uma nação vibrante, conhecida por sua cultura diversificada, gastronomia e influência global."));
            optionData.Add(rdBtn2, ("../../Resources/argentina.jpg", "A Argentina tem uma história rica e complexa que remonta aos povos indígenas antes da chegada dos espanhóis em 1516. Em 1816, o país declarou sua independência da Espanha. O século XIX testemunhou conflitos internos e lutas por poder. No século XX, a Argentina passou por períodos de instabilidade política, incluindo o governo de Juan Domingo Perón. Hoje, é uma nação sul-americana com uma cultura única, famosa por seu tango, futebol e contribuições culturais para o mundo."));
            optionData.Add(rdBtn3, ("../../Resources/brasil.png", "A história do Brasil é marcada por uma diversidade impressionante de povos indígenas, a chegada dos portugueses em 1500 e a colonização que durou quase três séculos. Em 1822, o país conquistou sua independência e se tornou um império. Ao longo do século XIX, o Brasil enfrentou o abolicionismo, a República foi proclamada em 1889 e, no século XX, houve períodos de governos autoritários e democráticos. Hoje, o Brasil é a maior nação da América do Sul, conhecida por sua cultura diversificada, belezas naturais e desafios socioeconômicos.\r\n\r\n\r\n\r\n\r\n"));
            optionData.Add(rdBtn4, ("../../Resources/chile.jpg", "A história do Chile é marcada por uma rica herança indígena, incluindo os Mapuches, que habitavam a região antes da chegada de exploradores espanhóis no século XVI, liderados por Pedro de Valdivia. Em 1818, o Chile conquistou sua independência da Espanha após uma guerra de independência. O século XIX viu períodos de instabilidade política, incluindo a Guerra Civil de 1891. No século XX, o Chile passou por transformações políticas significativas, incluindo o governo de Salvador Allende e o regime militar de Pinochet. Hoje, o Chile é uma democracia estável e uma das economias mais avançadas da América do Sul, conhecida por sua cultura, vinhos e beleza natural.\r\n\r\n\r\n\r\n\r\n"));

            // Defina a opção padrão
            rdBtn3.Checked = true;
            ExibirInformacoesOpcaoSelecionada(rdBtn3);
        }

        public void alteraFigura()
        {
            label1.Text = "   ";
            try
            {
                foreach (var kvp in optionData)
                {
                    if (kvp.Key.Checked)
                    {
                        caixaImagem.Load(kvp.Value.imagePath);
                        caixaTexto.Text = kvp.Value.description;
                        break; 
                    }
                }
            }
            catch (Exception ex)
            {
                label1.Text = "Arquivo da bandeira não encontrado. " + ex.Message;
            }
        }

        private void ExibirInformacoesOpcaoSelecionada(RadioButton selectedOption)
        {
            if (optionData.TryGetValue(selectedOption, out var optionInfo))
            {
                caixaImagem.Load(optionInfo.imagePath);
                caixaTexto.Text = optionInfo.description;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            alteraFigura();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            alteraFigura();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            alteraFigura();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            alteraFigura();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
