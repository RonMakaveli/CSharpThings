namespace MostraFiguras
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.caixaBotoes = new System.Windows.Forms.GroupBox();
            this.rdBtn2 = new System.Windows.Forms.RadioButton();
            this.rdBtn1 = new System.Windows.Forms.RadioButton();
            this.rdBtn4 = new System.Windows.Forms.RadioButton();
            this.rdBtn3 = new System.Windows.Forms.RadioButton();
            this.caixaImagem = new System.Windows.Forms.PictureBox();
            this.caixaTexto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.caixaBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caixaImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // caixaBotoes
            // 
            this.caixaBotoes.Controls.Add(this.rdBtn2);
            this.caixaBotoes.Controls.Add(this.rdBtn1);
            this.caixaBotoes.Controls.Add(this.rdBtn4);
            this.caixaBotoes.Controls.Add(this.rdBtn3);
            this.caixaBotoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caixaBotoes.Location = new System.Drawing.Point(11, 85);
            this.caixaBotoes.Margin = new System.Windows.Forms.Padding(2);
            this.caixaBotoes.Name = "caixaBotoes";
            this.caixaBotoes.Padding = new System.Windows.Forms.Padding(2);
            this.caixaBotoes.Size = new System.Drawing.Size(176, 186);
            this.caixaBotoes.TabIndex = 2;
            this.caixaBotoes.TabStop = false;
            this.caixaBotoes.Text = "Selecione o país";
            this.caixaBotoes.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdBtn2
            // 
            this.rdBtn2.AutoSize = true;
            this.rdBtn2.Location = new System.Drawing.Point(14, 60);
            this.rdBtn2.Margin = new System.Windows.Forms.Padding(2);
            this.rdBtn2.Name = "rdBtn2";
            this.rdBtn2.Size = new System.Drawing.Size(70, 17);
            this.rdBtn2.TabIndex = 3;
            this.rdBtn2.TabStop = true;
            this.rdBtn2.Text = "Argentina";
            this.rdBtn2.UseVisualStyleBackColor = true;
            this.rdBtn2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdBtn1
            // 
            this.rdBtn1.AutoSize = true;
            this.rdBtn1.Location = new System.Drawing.Point(14, 32);
            this.rdBtn1.Margin = new System.Windows.Forms.Padding(2);
            this.rdBtn1.Name = "rdBtn1";
            this.rdBtn1.Size = new System.Drawing.Size(59, 17);
            this.rdBtn1.TabIndex = 2;
            this.rdBtn1.TabStop = true;
            this.rdBtn1.Text = "México";
            this.rdBtn1.UseVisualStyleBackColor = true;
            this.rdBtn1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdBtn4
            // 
            this.rdBtn4.AutoSize = true;
            this.rdBtn4.Location = new System.Drawing.Point(14, 118);
            this.rdBtn4.Margin = new System.Windows.Forms.Padding(2);
            this.rdBtn4.Name = "rdBtn4";
            this.rdBtn4.Size = new System.Drawing.Size(48, 17);
            this.rdBtn4.TabIndex = 1;
            this.rdBtn4.Text = "Chile";
            this.rdBtn4.UseVisualStyleBackColor = true;
            this.rdBtn4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rdBtn3
            // 
            this.rdBtn3.AutoSize = true;
            this.rdBtn3.Checked = true;
            this.rdBtn3.Location = new System.Drawing.Point(14, 90);
            this.rdBtn3.Margin = new System.Windows.Forms.Padding(2);
            this.rdBtn3.Name = "rdBtn3";
            this.rdBtn3.Size = new System.Drawing.Size(50, 17);
            this.rdBtn3.TabIndex = 0;
            this.rdBtn3.TabStop = true;
            this.rdBtn3.Text = "Brasil";
            this.rdBtn3.UseVisualStyleBackColor = true;
            this.rdBtn3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // caixaImagem
            // 
            this.caixaImagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caixaImagem.Image = global::MostraFiguras.Properties.Resources.brasil;
            this.caixaImagem.Location = new System.Drawing.Point(191, 179);
            this.caixaImagem.Margin = new System.Windows.Forms.Padding(2);
            this.caixaImagem.Name = "caixaImagem";
            this.caixaImagem.Size = new System.Drawing.Size(246, 168);
            this.caixaImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.caixaImagem.TabIndex = 3;
            this.caixaImagem.TabStop = false;
            // 
            // caixaTexto
            // 
            this.caixaTexto.Location = new System.Drawing.Point(191, 11);
            this.caixaTexto.Margin = new System.Windows.Forms.Padding(2);
            this.caixaTexto.Multiline = true;
            this.caixaTexto.Name = "caixaTexto";
            this.caixaTexto.Size = new System.Drawing.Size(302, 164);
            this.caixaTexto.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(476, 209);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "   ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 358);
            this.Controls.Add(this.caixaTexto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.caixaImagem);
            this.Controls.Add(this.caixaBotoes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geografia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.caixaBotoes.ResumeLayout(false);
            this.caixaBotoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caixaImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox caixaBotoes;
        private System.Windows.Forms.PictureBox caixaImagem;
        private System.Windows.Forms.TextBox caixaTexto;
        private System.Windows.Forms.RadioButton rdBtn1;
        private System.Windows.Forms.RadioButton rdBtn2;
        private System.Windows.Forms.RadioButton rdBtn3;
        private System.Windows.Forms.RadioButton rdBtn4;
        
        private System.Windows.Forms.Label label1;
    }
}

