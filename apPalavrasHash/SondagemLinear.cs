using System.Runtime.ConstrainedExecution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SondagemLinear<T> where T : IRegistro<T>, new()
{
    T[] tabelaDeHash;
    private int tamanho;
    int qntsElementos;

    public SondagemLinear(int tamanho)
    {
        this.tamanho = tamanho;
        tabelaDeHash = new T[tamanho];
        this.qntsElementos = qntsElementos;

        for (int i = 0; i < tamanho; i++)
        {
            tabelaDeHash = new T[tamanho];
        }
    }

    private int Hash(string chave)
    {//peguei do HashAprimorado da apostila
        long tot = 0;
        for (int i = 0; i < chave.Length; i++)
        {
            tot += 37 * tot + (int)chave[i];
        }
        tot = tot % tabelaDeHash.Length;
        if (tot < 0)
        {
            tot += tabelaDeHash.Length;
        }
        return (int)tot;
    }

    public void Rehash(){
        int tamanhoRehash = 2017;
        T[] tabelaDeRehash = new T[tamanhoRehash];

        foreach (T dado in tabelaDeHash){
            if (dado != null){
                int indice = (Hash(dado.Chave) % tamanhoRehash);

                while (tabelaDeRehash[indice] != null){
                    indice = ((indice + 1) % tamanhoRehash);
                }
                tabelaDeRehash[indice] = dado;
            }
        }
        tabelaDeHash = tabelaDeRehash;
        tamanho = tamanhoReHash;
    }

    public void Inserir(T novoDado){
        //adicionando o rehash
        double tabelaCheia = (double)qntsElementos / tamanho;
        if (tabelaCheia > 0.7)
            Rehash();
        
        int indice = Hash(novoDado.Chave);

        for (int i = 0; i < tamanho; i++)
        {
            int pos = (indice + i) % tamanho;

            if (tabelaDeHash[pos] == null)
            {
                tabelaDeHash[pos] = novoDado;
                qntsElementos = qntsElementos + 1;
                return;
            }
        }

        
        throw new Exception("Tabela cheia!");
    }

    public bool Existe(T dado, out int posicao)
    {
        int indice = Hash(dado.Chave);
        for (int i = 0; i < tamanho; i++){
            posicao = (indice + i) % tamanho;
            if (tabelaDeHash[posicao] == null)
                return false; //significa q n existe nd aq
            if (tabelaDeHash[posicao].Equals(dado))
                return true; 
        }
        posicao = -1;
        return false;
    }
    public bool Remover(T dado){
        int ondeAchou;
        if (Existe(dado, out ondeAchou))
        {
            tabelaDeHash[ondeAchou] = default(T);
            qntsElementos = qntsElementos - 1;
            return true;
        }
        return false;
    }

    public void Listar()
    {
        for (int i = 0; i < tamanho; i++)
        {
            if (tabelaDeHash[i] != null && tabelaDeHash[i].Equals(default(T)))
                Console.WriteLine($"{i}: |{tabelaDeHash[i]}");
        }
    }

}