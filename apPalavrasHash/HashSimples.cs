using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class HashSimples<T> where T : IRegistro<T>, new()
{
    const int tamanhoPadrao = 1007;
    T[] tabelaDeHash;
    int qntsElementos;

    public HashSimples(int tamanhoDesejado) {
        tabelaDeHash = new T[tamanhoDesejado];
    }

    private int Hash(string chave) {//pego do HashAprimorado da apostila
        long tot = 0;
        for (int i = 0; i < chave.Length; i++) {
            tot += 37 * tot + (int)chave[i];
        }
        tot = tot % tabelaDeHash.Length;
        if (tot < 0) {
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
        tamanhoPadrao = tamanhoRehash;
    }

    public string Incluir(T novoDado) {
        saida = " ";
        double tabelaCheia = (double)qntsElementos / tamanhoPadrao;
        if (tabelaCheia > 0.7)
            Rehash();
        int valorDeHash = Hash(novoDado.Chave);
        if (tabelaDeHash[valorDeHash] == null) {
            tabelaDeHash[valorDeHash] = novoDado;
            qntsElementos = qntsElementos + 1;
        }
        return saida;
    }

    public bool Existe(T dado, out int posicao) {
        posicao = Hash(dado.Chave);
        return tabelaDeHash[posicao].Equals(dado);
    }

    public List<string> Conteudo() {
        var saida = new List<string>();
        for (int i = 0; i < tabelaDeHash.Length; i++) {
            if (tabelaDeHash[i] != null) {
                saida.Add($"{i,5} : {tabelaDeHash[i]}");
            }

        }
        return saida;
    }

    public void Limpar() {
        for (int i = 0; i < tabelaDeHash.Length; i++)
            tabelaDeHash[i] = default(T);
    }

    public bool Excluir(T dado) {
        int ondeAchou;
        if (Existe(dado, out ondeAchou)) {
            tabelaDeHash[ondeAchou] = default(T);
            qntsElementos--;
            return true;
        }
        return false;
    }
}