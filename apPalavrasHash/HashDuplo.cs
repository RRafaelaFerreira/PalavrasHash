using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

public class HashDuplo<T> where T : IRegistro<T>, new()
{
    const int R = 10003;
    T[] tabelaDeHash;


    public HashDuplo(int tamanhoDesejado)
    {
        tabelaDeHash = new T[tamanhoDesejado];
    }

    private int Hash1(string chave)
    {//pego do HashAprimorado da apostila
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

    //private int Hash2(string chave)
    //{
    //long tot = 0;
    //   for (int i = 0; i < chave.Length; i++)
    //  {
    //tot += 31 * tot + (int)chave[i];
    //}
    //tot = tot % (tabelaDeHash.Length -1);
    //  if (tot < 0)
    //{
    //tot += tabelaDeHash.Length -1;
    //}
    //return (int)tot +1;
    //}

    public string Incluir(T novoDado){
        string saida = " ";
        int hash1 = Hash1(novoDado.Chave);
        int chave = 0;
        foreach (char c in novoDado.Chave)
            chave += (int)c;

        int hash2 = R - (chave % R);
        //Hash2(chave) = R - ( chave % R )  peguei da apostila

        for (int i = 0; i < tabelaDeHash.Length; i++){
            
            int indice = (hash1 + i * hash2) % tabelaDeHash.Length;
            if (tabelaDeHash[indice] == null){
                tabelaDeHash[indice] = novoDado;
                return saida;
            }
        }
        throw new Exception("Tabela Cheia!"); ;
    }

    public bool Existe(T dado, out int posicao){
        posicao = Hash1(dado.Chave);
        int chave = 0;
        foreach (char c in dado.Chave)
            chave += (int)c;

        int hash2 = R - (chave % R);
        for (int i = 0; i < tabelaDeHash.Length; i++)
        {

            int indice = (posicao + i * hash2) % tabelaDeHash.Length;
            if (tabelaDeHash[indice] == null)
            {
                posicao = -1;
                return false;
            }
            if(tabelaDeHash[indice].Equals(dado)){
                posicao = indice;
                return true;
            }
        }
        posicao = - 1;
        return false;
    }

    public List<string> Conteudo(){
        var saida = new List<string>();
        for (int i = 0; i < tabelaDeHash.Length; i++)
        {
            if (tabelaDeHash[i] != null)
            {
                saida.Add($"{i,5} : {tabelaDeHash[i]}");
            }

        }
        return saida;
    }

    public void Limpar(){
        for (int i = 0; i < tabelaDeHash.Length; i++)
            tabelaDeHash[i] = default(T);
    }

    public bool Excluir(T dado){
        int ondeAchou;
        if (Existe(dado, out ondeAchou))
        {
            tabelaDeHash[ondeAchou] = default(T);
            return true;
        }
        return false;
    }
}

