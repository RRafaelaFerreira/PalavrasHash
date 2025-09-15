using System;
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

        public Form1()
        {
            InitializeComponent();
        }

        private void rbtnBucketHash_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnBucketHash.Checked)
                hashAtual = new ListaSimples<Palavra>(); // ou BucketHash se tiver
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
            var palavra = txtPalavra.Text.Trim();
            var dica = txtDica.Text.Trim();
            var nova = new Palavra(palavra, dica);

            btnExcluir_Click(sender, e); // remove versão antiga
            btnIncluir_Click(sender, e); // insere a versão nova
        }


        private void btnListar_Click(object sender, EventArgs e)
        {
            ListarConteudo();
        }

        private void ListarConteudo()
        {
            lsbListagem.Items.Clear();

            if (hashAtual is SondagemLinear<Palavra> linear)
                for (int i = 0; i < 101; i++) lsbListagem.Items.Add(linear.ToString());
            else if (hashAtual is HashDuplo<Palavra> duplo)
                foreach (var item in duplo.Conteudo()) lsbListagem.Items.Add(item);
            else if (hashAtual is HashSimples<Palavra> simples)
                foreach (var item in simples.Conteudo()) lsbListagem.Items.Add(item);
            // SondagemQuadratica também pode ser adaptada (precisa retornar uma lista).
        }

        private void txtPalavra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDica_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
