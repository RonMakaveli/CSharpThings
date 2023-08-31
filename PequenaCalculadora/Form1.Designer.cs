namespace PequenaCalculadora
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtDado1 = new TextBox();
            txtDado2 = new TextBox();
            lblResultado = new Label();
            button1 = new Button();
            rbMedia = new RadioButton();
            rbMediaPond = new RadioButton();
            rbPotencia = new RadioButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(rbPotencia);
            panel1.Controls.Add(rbMediaPond);
            panel1.Controls.Add(rbMedia);
            panel1.Location = new Point(40, 145);
            panel1.Name = "panel1";
            panel1.Size = new Size(252, 132);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 28);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 1;
            label1.Text = "Digite dois valores: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 66);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 2;
            label2.Text = "a: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 95);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 3;
            label3.Text = "b: ";
            // 
            // txtDado1
            // 
            txtDado1.Location = new Point(69, 66);
            txtDado1.Name = "txtDado1";
            txtDado1.Size = new Size(79, 23);
            txtDado1.TabIndex = 4;
            // 
            // txtDado2
            // 
            txtDado2.Location = new Point(69, 92);
            txtDado2.Name = "txtDado2";
            txtDado2.Size = new Size(79, 23);
            txtDado2.TabIndex = 5;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.Location = new Point(40, 347);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(65, 15);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "Resultado:";
            // 
            // button1
            // 
            button1.Location = new Point(39, 299);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // rbMedia
            // 
            rbMedia.AutoSize = true;
            rbMedia.Checked = true;
            rbMedia.Location = new Point(12, 20);
            rbMedia.Name = "rbMedia";
            rbMedia.Size = new Size(158, 19);
            rbMedia.TabIndex = 0;
            rbMedia.TabStop = true;
            rbMedia.Text = "Média aritmética de a e b";
            rbMedia.UseVisualStyleBackColor = true;
            // 
            // rbMediaPond
            // 
            rbMediaPond.AutoSize = true;
            rbMediaPond.Location = new Point(14, 54);
            rbMediaPond.Name = "rbMediaPond";
            rbMediaPond.Size = new Size(220, 19);
            rbMediaPond.TabIndex = 1;
            rbMediaPond.TabStop = true;
            rbMediaPond.Text = "Média ponderada (1º com peso dois)";
            rbMediaPond.UseVisualStyleBackColor = true;
            // 
            // rbPotencia
            // 
            rbPotencia.AutoSize = true;
            rbPotencia.Location = new Point(14, 88);
            rbPotencia.Name = "rbPotencia";
            rbPotencia.Size = new Size(95, 19);
            rbPotencia.TabIndex = 2;
            rbPotencia.TabStop = true;
            rbPotencia.Text = "Potência a^b";
            rbPotencia.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 413);
            Controls.Add(button1);
            Controls.Add(lblResultado);
            Controls.Add(txtDado2);
            Controls.Add(txtDado1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Operações aritméticas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDado1;
        private TextBox txtDado2;
        private Label lblResultado;
        private Button button1;
        private RadioButton rbMedia;
        private RadioButton rbPotencia;
        private RadioButton rbMediaPond;
    }
}