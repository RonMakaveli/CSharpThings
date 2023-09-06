namespace ProvedorInternet
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListCidades = new ListBox();
            label1 = new Label();
            CaixaVelocidade = new Panel();
            RbtSessenta = new RadioButton();
            RbtTrinta = new RadioButton();
            RbtDez = new RadioButton();
            label2 = new Label();
            OptPromo1 = new CheckBox();
            OptPromo2 = new CheckBox();
            label3 = new Label();
            label4 = new Label();
            Calcular = new Button();
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            CaixaVelocidade.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ListCidades
            // 
            ListCidades.FormattingEnabled = true;
            ListCidades.ItemHeight = 15;
            ListCidades.Items.AddRange(new object[] { "São paulo ", "Rio de janeiro ", "Campo Grande ", "Manaus ", "Roraima", "Rio Grande do Sul", "Rio Grande do Norte ", "Bahia ", "Espiro Santo", "Paraná", "Santa Catarina", "Acre" });
            ListCidades.Location = new Point(57, 58);
            ListCidades.Name = "ListCidades";
            ListCidades.Size = new Size(120, 94);
            ListCidades.TabIndex = 0;
            ListCidades.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(42, 38);
            label1.Name = "label1";
            label1.Size = new Size(154, 19);
            label1.TabIndex = 1;
            label1.Text = "Selecionar sua cidade";
            label1.Click += label1_Click;
            // 
            // CaixaVelocidade
            // 
            CaixaVelocidade.Controls.Add(RbtSessenta);
            CaixaVelocidade.Controls.Add(RbtTrinta);
            CaixaVelocidade.Controls.Add(RbtDez);
            CaixaVelocidade.Location = new Point(56, 197);
            CaixaVelocidade.Name = "CaixaVelocidade";
            CaixaVelocidade.Size = new Size(120, 100);
            CaixaVelocidade.TabIndex = 2;
            // 
            // RbtSessenta
            // 
            RbtSessenta.AutoSize = true;
            RbtSessenta.Location = new Point(3, 78);
            RbtSessenta.Name = "RbtSessenta";
            RbtSessenta.Size = new Size(63, 19);
            RbtSessenta.TabIndex = 2;
            RbtSessenta.Text = "60 MBs";
            RbtSessenta.UseVisualStyleBackColor = true;
            RbtSessenta.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // RbtTrinta
            // 
            RbtTrinta.AutoSize = true;
            RbtTrinta.Location = new Point(3, 40);
            RbtTrinta.Name = "RbtTrinta";
            RbtTrinta.Size = new Size(63, 19);
            RbtTrinta.TabIndex = 1;
            RbtTrinta.Text = "30 MBs";
            RbtTrinta.UseVisualStyleBackColor = true;
            RbtTrinta.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // RbtDez
            // 
            RbtDez.AutoSize = true;
            RbtDez.Checked = true;
            RbtDez.Location = new Point(3, 3);
            RbtDez.Name = "RbtDez";
            RbtDez.Size = new Size(66, 19);
            RbtDez.TabIndex = 0;
            RbtDez.TabStop = true;
            RbtDez.Text = "10 MBs ";
            RbtDez.UseVisualStyleBackColor = true;
            RbtDez.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 171);
            label2.Name = "label2";
            label2.Size = new Size(231, 19);
            label2.TabIndex = 3;
            label2.Text = "Selecione a velocidade desejada.";
            label2.Click += label2_Click;
            // 
            // OptPromo1
            // 
            OptPromo1.AutoSize = true;
            OptPromo1.Location = new Point(28, 350);
            OptPromo1.Name = "OptPromo1";
            OptPromo1.Size = new Size(162, 19);
            OptPromo1.TabIndex = 4;
            OptPromo1.Text = "Até três e-mail fornecidos";
            OptPromo1.UseVisualStyleBackColor = true;
            // 
            // OptPromo2
            // 
            OptPromo2.AutoSize = true;
            OptPromo2.Location = new Point(28, 375);
            OptPromo2.Name = "OptPromo2";
            OptPromo2.Size = new Size(165, 19);
            OptPromo2.TabIndex = 5;
            OptPromo2.Text = "Página pessoal hospedada";
            OptPromo2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(42, 315);
            label3.Name = "label3";
            label3.Size = new Size(155, 19);
            label3.TabIndex = 6;
            label3.Text = "Promoções Opcionais";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 479);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 7;
            label4.Text = "Resultado:";
            label4.Click += label4_Click;
            // 
            // Calcular
            // 
            Calcular.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            Calcular.Location = new Point(68, 420);
            Calcular.Margin = new Padding(2);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(97, 38);
            Calcular.TabIndex = 8;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, ajudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(248, 24);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(93, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // ajudaToolStripMenuItem
            // 
            ajudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sobreToolStripMenuItem });
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            ajudaToolStripMenuItem.Size = new Size(50, 20);
            ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(104, 22);
            sobreToolStripMenuItem.Text = "Sobre";
            sobreToolStripMenuItem.Click += sobreToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(248, 525);
            Controls.Add(Calcular);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(OptPromo2);
            Controls.Add(OptPromo1);
            Controls.Add(label2);
            Controls.Add(CaixaVelocidade);
            Controls.Add(label1);
            Controls.Add(ListCidades);
            Controls.Add(menuStrip1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calcular Mensalidade de Internet";
            Load += Form1_Load;
            CaixaVelocidade.ResumeLayout(false);
            CaixaVelocidade.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ListCidades;
        private Label label1;
        private Panel CaixaVelocidade;
        private Label label2;
        private RadioButton RbtSessenta;
        private RadioButton RbtTrinta;
        private RadioButton RbtDez;
        private CheckBox OptPromo1;
        private CheckBox OptPromo2;
        private Label label3;
        private Label label4;
        private Button Calcular;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}