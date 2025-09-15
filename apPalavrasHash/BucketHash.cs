using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class BucketHash<T> where T : IRegistro<T>, new()
{
    private const int size = 37;
    ListaSimples<T>[] dados;

    public BucketHash() { 
        dados = new ListaSimples<T>[size];
        for(int i = 0; i < size; i++)
        {
            dados[i] = new ListaSimples<T>();
        } 
    }

    private int Hash(string chave) {
        long tot = 0;
        for (int i = 0; i < chave.Length; i++) {
            tot += 37 * tot + (char)chave[i];
        }
        tot = tot % dados.Length;
        if (tot < 0)
            tot += dados.Length;

        return (int)tot;
    }

    public bool Incluir(T novoDado) {
        int valorDeHash = Hash(novoDado.Chave);
        
        if (!dados[valorDeHash].Existe(novoDado)) {
            dados[valorDeHash].InserirAposFim(novoDado);
            return true;
        }
        return false;
    }

    public bool Excluir(T dado) {
        int onde = 0;
        if(!Existe(dado, out onde))
            return false;
        dados[onde].Remover(dado);
        return true;
    }

    public bool Existe(T dado, out int onde) {
        onde = Hash(dado.Chave);
        return dados[onde].Existe(dado);
    }

    public List<string> Conteudo()
    {
        List<string> saida = new List<string>();

        for (int i = 0; i < dados.Length; i++)
        {
            var elementos = dados[i].Listar();

            if (elementos.Count > 0)
            {
                string linha = $"{i,5} : ";
                foreach (var dado in elementos)
                    linha += "|" + dado.ToString();

                saida.Add(linha);
            }
        }

        return saida;
    }

}

