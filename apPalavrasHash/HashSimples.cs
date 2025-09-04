using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class HashSimples<T> where T : IRegistro<T>, new()
{
    const int tamanhoPadrao = 10007;
    T[] tabelaDeHash;

    //public HashSimples() : this.(tamanhoPadrao){}

    public HashSimples(int tamanhoDesejado) {
        tabelaDeHash = new T[tamanhoDesejado];
    }

    private int Hash(string chave) {
        int tot = 0;
        for (int i = 0; i < chave.Trim().Length; ++) {
            tot += (int)chave[i];
        }
        return tot % tabelaDeHash.Lenght;
    }

    public string Incluir(T novoDado) {
        string saida = " ";
    }
}
//CONTINUAR A COPIAR DA APOSTILA NA PÁGIINA 40!!!!!!