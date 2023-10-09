using System;

namespace Exercicio
{
    partial class frmMedias
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtMat = new System.Windows.Forms.TextBox();
            this.BoxNota1 = new System.Windows.Forms.TextBox();
            this.BoxNota2 = new System.Windows.Forms.TextBox();
            this.BoxNota3 = new System.Windows.Forms.TextBox();
            this.lblMedCalc = new System.Windows.Forms.Label();
            this.situacao = new System.Windows.Forms.Label();
            this.btnCalcMed = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(2, 47);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(271, 37);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome do estudante:";
            this.lblNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateria.Location = new System.Drawing.Point(12, 114);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(261, 37);
            this.lblMateria.TabIndex = 1;
            this.lblMateria.Text = "Matéria / disciplina:";
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota1.Location = new System.Drawing.Point(12, 204);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(113, 37);
            this.lblNota1.TabIndex = 2;
            this.lblNota1.Text = "NOTA 1";
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota2.Location = new System.Drawing.Point(170, 204);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(113, 37);
            this.lblNota2.TabIndex = 3;
            this.lblNota2.Text = "NOTA 2";
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota3.Location = new System.Drawing.Point(340, 204);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(113, 37);
            this.lblNota3.TabIndex = 4;
            this.lblNota3.Text = "NOTA 3";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia.Location = new System.Drawing.Point(521, 204);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(111, 37);
            this.lblMedia.TabIndex = 5;
            this.lblMedia.Text = "MEDIA:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(279, 47);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(409, 44);
            this.txtNome.TabIndex = 6;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress_1);
            // 
            // txtMat
            // 
            this.txtMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMat.Location = new System.Drawing.Point(279, 112);
            this.txtMat.Name = "txtMat";
            this.txtMat.Size = new System.Drawing.Size(409, 44);
            this.txtMat.TabIndex = 7;
            this.txtMat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMat_KeyPress_1);
            // 
            // BoxNota1
            // 
            this.BoxNota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxNota1.Location = new System.Drawing.Point(19, 244);
            this.BoxNota1.Name = "BoxNota1";
            this.BoxNota1.Size = new System.Drawing.Size(89, 44);
            this.BoxNota1.TabIndex = 8;
            this.BoxNota1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BoxNota1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BoxNota1_KeyPress);
            // 
            // BoxNota2
            // 
            this.BoxNota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxNota2.Location = new System.Drawing.Point(177, 244);
            this.BoxNota2.Name = "BoxNota2";
            this.BoxNota2.Size = new System.Drawing.Size(89, 44);
            this.BoxNota2.TabIndex = 9;
            this.BoxNota2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BoxNota2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BoxNota2_KeyPress_1);
            // 
            // BoxNota3
            // 
            this.BoxNota3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxNota3.Location = new System.Drawing.Point(347, 244);
            this.BoxNota3.Name = "BoxNota3";
            this.BoxNota3.Size = new System.Drawing.Size(89, 44);
            this.BoxNota3.TabIndex = 10;
            this.BoxNota3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BoxNota3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BoxNota3_KeyPress_1);
            // 
            // lblMedCalc
            // 
            this.lblMedCalc.AutoSize = true;
            this.lblMedCalc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMedCalc.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedCalc.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblMedCalc.Location = new System.Drawing.Point(533, 246);
            this.lblMedCalc.Name = "lblMedCalc";
            this.lblMedCalc.Size = new System.Drawing.Size(75, 39);
            this.lblMedCalc.TabIndex = 12;
            this.lblMedCalc.Text = "        ";
            this.lblMedCalc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // situacao
            // 
            this.situacao.AutoSize = true;
            this.situacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.situacao.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.situacao.ForeColor = System.Drawing.Color.ForestGreen;
            this.situacao.Location = new System.Drawing.Point(497, 306);
            this.situacao.Name = "situacao";
            this.situacao.Size = new System.Drawing.Size(155, 59);
            this.situacao.TabIndex = 13;
            this.situacao.Text = "            ";
            this.situacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.situacao.Click += new System.EventHandler(this.situacao_Click);
            // 
            // btnCalcMed
            // 
            this.btnCalcMed.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcMed.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnCalcMed.Location = new System.Drawing.Point(12, 371);
            this.btnCalcMed.Name = "btnCalcMed";
            this.btnCalcMed.Size = new System.Drawing.Size(166, 88);
            this.btnCalcMed.TabIndex = 14;
            this.btnCalcMed.Text = "Calcular média";
            this.btnCalcMed.UseVisualStyleBackColor = true;
            this.btnCalcMed.Click += new System.EventHandler(this.btnCalcMed_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnLimpar.Location = new System.Drawing.Point(216, 371);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(166, 88);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmMedias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 471);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcMed);
            this.Controls.Add(this.situacao);
            this.Controls.Add(this.lblMedCalc);
            this.Controls.Add(this.BoxNota3);
            this.Controls.Add(this.BoxNota2);
            this.Controls.Add(this.BoxNota1);
            this.Controls.Add(this.txtMat);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.lblNota3);
            this.Controls.Add(this.lblNota2);
            this.Controls.Add(this.lblNota1);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblNome);
            this.Name = "frmMedias";
            this.Text = "Calcula médias";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtMat;
        private System.Windows.Forms.TextBox BoxNota1;
        private System.Windows.Forms.TextBox BoxNota2;
        private System.Windows.Forms.TextBox BoxNota3;
        private System.Windows.Forms.Label lblMedCalc;
        private System.Windows.Forms.Label situacao;
        private System.Windows.Forms.Button btnCalcMed;
        private System.Windows.Forms.Button btnLimpar;
    }
}

