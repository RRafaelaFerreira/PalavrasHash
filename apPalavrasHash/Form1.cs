using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apPalavrasHash
{
    public partial class Form1 : Form
    {
        private object hashAtual;  
        private const int TAMANHO_INICIAL = 101;
        const string arquivo = "palavras.txt";//aparentemente é assim

        public Form1()
        {
            InitializeComponent();

            LerArquivo();
        }

        private void LerArquivo(){
            if (!File.Exists(arquivo))
                return;

            string[] linhas = File.ReadAllLines(arquivo);

            foreach (string linha in linhas)
            {
                var palavra = new Palavra();
                palavra.LerDeLinha(linha);

                if (hashAtual is SondagemLinear<Palavra> linear)
                    linear.Inserir(palavra);
            
                else if (hashAtual is SondagemQuadratica<Palavra> quadratica)
                    quadratica.Inserir(palavra);
                
                else if (hashAtual is HashDuplo<Palavra> duplo)
                    duplo.Incluir(palavra);
                
                else if (hashAtual is HashSimples<Palavra> simples)
                    simples.Incluir(palavra);
            }
        }
        private void rbtnBucketHash_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnBucketHash.Checked)
                hashAtual = new ListaSimples<Palavra>(); 

        }

        private void rbtnSondagemLinear_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSondagemLinear.Checked)
                hashAtual = new SondagemLinear<Palavra>(TAMANHO_INICIAL);
        }

        private void rbtnSondagemQuadratica_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSondagemQuadratica.Checked)
                hashAtual = new SondagemQuadratica<Palavra>(TAMANHO_INICIAL);
        }

        private void rbtnDuploHash_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDuploHash.Checked)
                hashAtual = new HashDuplo<Palavra>(TAMANHO_INICIAL);
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPalavra.Text)) {
                MessageBox.Show("Digite a Palavra antes de incluir!");
            }
            if (hashAtual == null)
            {
                MessageBox.Show("Selecione uma técnica de hashing primeiro.");
                return;
            }

            var nova = new Palavra(txtPalavra.Text.Trim(), txtDica.Text.Trim());

            if (hashAtual is SondagemLinear<Palavra> linear)
                linear.Inserir(nova);
            
            else if (hashAtual is SondagemQuadratica<Palavra> quadratica)
                quadratica.Inserir(nova);
            
            else if (hashAtual is HashDuplo<Palavra> duplo)
                duplo.Incluir(nova);
            
            else if (hashAtual is HashSimples<Palavra> simples)
                simples.Incluir(nova);

            ListarConteudo();
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var alvo = new Palavra(txtPalavra.Text.Trim(), "");
            bool removido = false;

            if (hashAtual is SondagemLinear<Palavra> linear)
                removido = linear.Remover(alvo);
            else if (hashAtual is SondagemQuadratica<Palavra> quadratica)
                removido = quadratica.Remover(alvo);
            else if (hashAtual is HashDuplo<Palavra> duplo)
                removido = duplo.Excluir(alvo);
            else if (hashAtual is HashSimples<Palavra> simples)
                removido = simples.Excluir(alvo);

            MessageBox.Show(removido ? "Excluído com sucesso." : "Palavra não encontrada.");
            ListarConteudo();
        }


        private void btnAlterar_Click(object sender, EventArgs e)
        {
            var conteudo = new List<string>();
            if (hashAtual is HashDuplo<Palavra> duplo)
                conteudo.AddRange(duplo.Conteudo());
            
            else if (hashAtual is HashSimples<Palavra> simples)
                conteudo.AddRange(simples.Conteudo());
            
            else if (hashAtual is SondagemLinear<Palavra> linear)
                conteudo.AddRange(linear.Listar());
            
            else if (hashAtual is SondagemQuadratica<Palavra> quadratica)
                conteudo.AddRange(quadratica.Listar());

            File.WriteAllLines("palavras.txt", conteudo);
            MessageBox.Show("Arquivo salvo com sucesso!");
        }


        private void btnListar_Click(object sender, EventArgs e)
        {
            if (!File.Exists(arquivo))
            {
                MessageBox.Show("Arquivo não encontrado.");
                return;
            }

            string[] linhas = File.ReadAllLines(arquivo);
            foreach (string linha in linhas)
            {
                var nova = new Palavra();
                nova.LerDeLinha(linha);

                if (hashAtual is SondagemLinear<Palavra> linear)
                    linear.Inserir(nova);
            
                else if (hashAtual is SondagemQuadratica<Palavra> quadratica)
                    quadratica.Inserir(nova);
                
                else if (hashAtual is HashDuplo<Palavra> duplo)
                    duplo.Incluir(nova);
                
                else if (hashAtual is HashSimples<Palavra> simples)
                    simples.Incluir(nova);
            }

            ListarConteudo();
        }


        private void ListarConteudo()
        {
            lsbListagem.Items.Clear();

            if (hashAtual is SondagemLinear<Palavra> linear)
                foreach (var item in linear.Listar())
                    lsbListagem.Items.Add(item);

            else if (hashAtual is SondagemQuadratica<Palavra> quadratica)
                foreach (var item in quadratica.Listar())
                    lsbListagem.Items.Add(item);

            else if (hashAtual is HashDuplo<Palavra> duplo)
                foreach (var item in duplo.Conteudo())
                    lsbListagem.Items.Add(item);

            else if (hashAtual is HashSimples<Palavra> simples)
                foreach (var item in simples.Conteudo())
                    lsbListagem.Items.Add(item);
        }

        private void SalvarHash(){
            if (hashAtual == null)
                return;

            var conteudo = new List<string>();

            if (hashAtual is SondagemLinear<Palavra> linear)
                conteudo.AddRange(linear.Listar());

            else if (hashAtual is SondagemQuadratica<Palavra> quadratica)
                conteudo.AddRange(quadratica.Listar());
            
            else if (hashAtual is HashDuplo<Palavra> duplo)
                conteudo.AddRange(duplo.Conteudo());
            
            else if (hashAtual is HashSimples<Palavra> simples)
                conteudo.AddRange(simples.Conteudo());

            File.WriteAllLines(arquivo, conteudo);

        }

        private void txtPalavra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDica_TextChanged(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            SalvarHash();
            base.OnFormClosing(e);
        }
    }
}
