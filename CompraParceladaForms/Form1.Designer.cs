namespace CompraParcelada
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtValorCompra = new TextBox();
            txtQtdeParc = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnCalcular = new Button();
            lblValorParcelas = new Label();
            lblTotalCompra = new Label();
            SuspendLayout();
            // 
            // txtValorCompra
            // 
            txtValorCompra.Location = new Point(254, 91);
            txtValorCompra.Name = "txtValorCompra";
            txtValorCompra.Size = new Size(73, 23);
            txtValorCompra.TabIndex = 0;
            // 
            // txtQtdeParc
            // 
            txtQtdeParc.Location = new Point(254, 131);
            txtQtdeParc.Name = "txtQtdeParc";
            txtQtdeParc.Size = new Size(100, 23);
            txtQtdeParc.TabIndex = 1;
            txtQtdeParc.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(49, 92);
            label1.Name = "label1";
            label1.Size = new Size(125, 19);
            label1.TabIndex = 2;
            label1.Text = "Valor da compra:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(49, 132);
            label2.Name = "label2";
            label2.Size = new Size(172, 19);
            label2.TabIndex = 3;
            label2.Text = "Quantidade de parcelas:";
            label2.Click += label2_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalcular.Location = new Point(49, 202);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(93, 30);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += button1_Click;
            // 
            // lblValorParcelas
            // 
            lblValorParcelas.AutoSize = true;
            lblValorParcelas.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblValorParcelas.Location = new Point(49, 336);
            lblValorParcelas.Name = "lblValorParcelas";
            lblValorParcelas.Size = new Size(72, 19);
            lblValorParcelas.TabIndex = 5;
            lblValorParcelas.Text = "Valor final:";
            lblValorParcelas.Click += label3_Click;
            // 
            // lblTotalCompra
            // 
            lblTotalCompra.AutoSize = true;
            lblTotalCompra.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalCompra.Location = new Point(49, 305);
            lblTotalCompra.Name = "lblTotalCompra";
            lblTotalCompra.Size = new Size(174, 19);
            lblTotalCompra.TabIndex = 6;
            lblTotalCompra.Text = "Total da compra com juros:";
            lblTotalCompra.Click += lblTotalCompra_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 450);
            Controls.Add(lblTotalCompra);
            Controls.Add(lblValorParcelas);
            Controls.Add(btnCalcular);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtQtdeParc);
            Controls.Add(txtValorCompra);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Compra Parcelada";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtValorCompra;
        private TextBox txtQtdeParc;
        private Label label1;
        private Label label2;
        private Button btnCalcular;
        private Label lblValorParcelas;
        private Label lblTotalCompra;
    }
}