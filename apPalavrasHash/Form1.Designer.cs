namespace apPalavrasHash
{
    partial class Form1
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
            this.lsbListagem = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtnBucketHash = new System.Windows.Forms.RadioButton();
            this.rbtnSondagemLinear = new System.Windows.Forms.RadioButton();
            this.rbtnSondagemQuadratica = new System.Windows.Forms.RadioButton();
            this.rbtnDuploHash = new System.Windows.Forms.RadioButton();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.txtPalavra = new System.Windows.Forms.TextBox();
            this.txtDica = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lsbListagem
            // 
            this.lsbListagem.FormattingEnabled = true;
            this.lsbListagem.Location = new System.Drawing.Point(44, 291);
            this.lsbListagem.Name = "lsbListagem";
            this.lsbListagem.Size = new System.Drawing.Size(610, 147);
            this.lsbListagem.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Técnicas de hashing";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lista de dados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Palavra:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dica:";
            // 
            // rbtnBucketHash
            // 
            this.rbtnBucketHash.AutoSize = true;
            this.rbtnBucketHash.Location = new System.Drawing.Point(44, 75);
            this.rbtnBucketHash.Name = "rbtnBucketHash";
            this.rbtnBucketHash.Size = new System.Drawing.Size(87, 17);
            this.rbtnBucketHash.TabIndex = 5;
            this.rbtnBucketHash.TabStop = true;
            this.rbtnBucketHash.Text = "Bucket Hash";
            this.rbtnBucketHash.UseVisualStyleBackColor = true;
            this.rbtnBucketHash.CheckedChanged += new System.EventHandler(this.rbtnBucketHash_CheckedChanged);
            // 
            // rbtnSondagemLinear
            // 
            this.rbtnSondagemLinear.AutoSize = true;
            this.rbtnSondagemLinear.Location = new System.Drawing.Point(44, 113);
            this.rbtnSondagemLinear.Name = "rbtnSondagemLinear";
            this.rbtnSondagemLinear.Size = new System.Drawing.Size(103, 17);
            this.rbtnSondagemLinear.TabIndex = 6;
            this.rbtnSondagemLinear.TabStop = true;
            this.rbtnSondagemLinear.Text = "Sonsagem linear";
            this.rbtnSondagemLinear.UseVisualStyleBackColor = true;
            this.rbtnSondagemLinear.CheckedChanged += new System.EventHandler(this.rbtnSondagemLinear_CheckedChanged);
            // 
            // rbtnSondagemQuadratica
            // 
            this.rbtnSondagemQuadratica.AutoSize = true;
            this.rbtnSondagemQuadratica.Location = new System.Drawing.Point(44, 157);
            this.rbtnSondagemQuadratica.Name = "rbtnSondagemQuadratica";
            this.rbtnSondagemQuadratica.Size = new System.Drawing.Size(129, 17);
            this.rbtnSondagemQuadratica.TabIndex = 7;
            this.rbtnSondagemQuadratica.TabStop = true;
            this.rbtnSondagemQuadratica.Text = "Sondagem quadratica";
            this.rbtnSondagemQuadratica.UseVisualStyleBackColor = true;
            this.rbtnSondagemQuadratica.CheckedChanged += new System.EventHandler(this.rbtnSondagemQuadratica_CheckedChanged);
            // 
            // rbtnDuploHash
            // 
            this.rbtnDuploHash.AutoSize = true;
            this.rbtnDuploHash.Location = new System.Drawing.Point(44, 192);
            this.rbtnDuploHash.Name = "rbtnDuploHash";
            this.rbtnDuploHash.Size = new System.Drawing.Size(81, 17);
            this.rbtnDuploHash.TabIndex = 8;
            this.rbtnDuploHash.TabStop = true;
            this.rbtnDuploHash.Text = "Duplo Hash";
            this.rbtnDuploHash.UseVisualStyleBackColor = true;
            this.rbtnDuploHash.CheckedChanged += new System.EventHandler(this.rbtnDuploHash_CheckedChanged);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(262, 189);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 9;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(370, 192);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(474, 192);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 11;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(579, 192);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 12;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // txtPalavra
            // 
            this.txtPalavra.Location = new System.Drawing.Point(325, 39);
            this.txtPalavra.Name = "txtPalavra";
            this.txtPalavra.Size = new System.Drawing.Size(100, 20);
            this.txtPalavra.TabIndex = 13;
            this.txtPalavra.TextChanged += new System.EventHandler(this.txtPalavra_TextChanged);
            // 
            // txtDica
            // 
            this.txtDica.Location = new System.Drawing.Point(308, 93);
            this.txtDica.Name = "txtDica";
            this.txtDica.Size = new System.Drawing.Size(309, 20);
            this.txtDica.TabIndex = 14;
            this.txtDica.TextChanged += new System.EventHandler(this.txtDica_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 450);
            this.Controls.Add(this.txtDica);
            this.Controls.Add(this.txtPalavra);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.rbtnDuploHash);
            this.Controls.Add(this.rbtnSondagemQuadratica);
            this.Controls.Add(this.rbtnSondagemLinear);
            this.Controls.Add(this.rbtnBucketHash);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsbListagem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbListagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtnBucketHash;
        private System.Windows.Forms.RadioButton rbtnSondagemLinear;
        private System.Windows.Forms.RadioButton rbtnSondagemQuadratica;
        private System.Windows.Forms.RadioButton rbtnDuploHash;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.TextBox txtPalavra;
        private System.Windows.Forms.TextBox txtDica;
    }
}

