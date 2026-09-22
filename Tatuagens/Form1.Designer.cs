namespace Tatuagens
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
            lblTitulo = new Label();
            lblNomeCliente = new Label();
            txtNomeCliente = new TextBox();
            lblTamanho = new Label();
            lblParteCorpo = new Label();
            chkPrimeiraTatuagem = new CheckBox();
            txtParteCorpo = new TextBox();
            txtTamanho = new TextBox();
            btnCalcular = new Button();
            lblValorbase = new Label();
            lblValorFinal = new Label();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(0, 0, 192);
            lblTitulo.Location = new Point(174, 29);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(448, 29);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "SISTEMA DE AGENDAMENTO DE TATUAGENS";
            // 
            // lblNomeCliente
            // 
            lblNomeCliente.AutoSize = true;
            lblNomeCliente.Location = new Point(174, 105);
            lblNomeCliente.Name = "lblNomeCliente";
            lblNomeCliente.Size = new Size(96, 15);
            lblNomeCliente.TabIndex = 1;
            lblNomeCliente.Text = "NOME CLIENTE :";
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(290, 102);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(278, 23);
            txtNomeCliente.TabIndex = 2;
            // 
            // lblTamanho
            // 
            lblTamanho.AutoSize = true;
            lblTamanho.Location = new Point(174, 178);
            lblTamanho.Name = "lblTamanho";
            lblTamanho.Size = new Size(73, 15);
            lblTamanho.TabIndex = 4;
            lblTamanho.Text = "TAMANHO :";
            // 
            // lblParteCorpo
            // 
            lblParteCorpo.AutoSize = true;
            lblParteCorpo.Location = new Point(174, 146);
            lblParteCorpo.Name = "lblParteCorpo";
            lblParteCorpo.Size = new Size(89, 15);
            lblParteCorpo.TabIndex = 5;
            lblParteCorpo.Text = "PARTE CORPO :";
            // 
            // chkPrimeiraTatuagem
            // 
            chkPrimeiraTatuagem.AutoSize = true;
            chkPrimeiraTatuagem.Location = new Point(174, 207);
            chkPrimeiraTatuagem.Name = "chkPrimeiraTatuagem";
            chkPrimeiraTatuagem.Size = new Size(134, 19);
            chkPrimeiraTatuagem.TabIndex = 6;
            chkPrimeiraTatuagem.Text = "Primeira Tatuagem ?";
            chkPrimeiraTatuagem.UseVisualStyleBackColor = true;
            // 
            // txtParteCorpo
            // 
            txtParteCorpo.Location = new Point(290, 143);
            txtParteCorpo.Name = "txtParteCorpo";
            txtParteCorpo.Size = new Size(278, 23);
            txtParteCorpo.TabIndex = 7;
            // 
            // txtTamanho
            // 
            txtTamanho.Location = new Point(290, 178);
            txtTamanho.Name = "txtTamanho";
            txtTamanho.Size = new Size(105, 23);
            txtTamanho.TabIndex = 8;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.Blue;
            btnCalcular.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.ForeColor = Color.FromArgb(255, 255, 128);
            btnCalcular.Location = new Point(247, 232);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(191, 59);
            btnCalcular.TabIndex = 9;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblValorbase
            // 
            lblValorbase.AutoSize = true;
            lblValorbase.Location = new Point(174, 317);
            lblValorbase.Name = "lblValorbase";
            lblValorbase.Size = new Size(79, 15);
            lblValorbase.TabIndex = 10;
            lblValorbase.Text = "VALOR BASE :";
            // 
            // lblValorFinal
            // 
            lblValorFinal.AutoSize = true;
            lblValorFinal.Location = new Point(174, 347);
            lblValorFinal.Name = "lblValorFinal";
            lblValorFinal.Size = new Size(84, 15);
            lblValorFinal.TabIndex = 11;
            lblValorFinal.Text = "VALOR FINAL :";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(174, 375);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(53, 15);
            lblStatus.TabIndex = 12;
            lblStatus.Text = "STATUS :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblStatus);
            Controls.Add(lblValorFinal);
            Controls.Add(lblValorbase);
            Controls.Add(btnCalcular);
            Controls.Add(txtTamanho);
            Controls.Add(txtParteCorpo);
            Controls.Add(chkPrimeiraTatuagem);
            Controls.Add(lblParteCorpo);
            Controls.Add(lblTamanho);
            Controls.Add(txtNomeCliente);
            Controls.Add(lblNomeCliente);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNomeCliente;
        private TextBox txtNomeCliente;
        private Label lblTamanho;
        private Label lblParteCorpo;
        private CheckBox chkPrimeiraTatuagem;
        private TextBox txtParteCorpo;
        private TextBox txtTamanho;
        private Button btnCalcular;
        private Label lblValorbase;
        private Label lblValorFinal;
        private Label lblStatus;
    }
}
