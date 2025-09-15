using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Palavra : IRegistro<Palavra>
{
    private String palavra { get; set; }
    private String dica {get; set; }

    public Palavra() { }
    public Palavra(String palavra, String dica){
        this.palavra = palavra;
        this.dica = dica;
    }

    public string Chave => palavra;

    public override bool Equals(object obj){
        if (obj is Palavra outra)
            return Equals(outra);
        return false;
    }

    public bool Equals(Palavra outra){
        if (outra == null) return false;
        return this.palavra.Equals(outra.palavra, StringComparison.OrdinalIgnoreCase);
    }

    public override int GetHashCode(){
        return palavra?.ToLower().GetHashCode() ?? 0;
    }

    public void LerRegistro(StreamReader arquivo){
        var linha = arquivo.ReadLine();
        if (linha == null) return;

        if (linha.Length <= 30){
            palavra = linha.Trim();
            dica = "";
        }
        else{
            palavra = linha.Substring(0, 30).Trim();
            dica = linha.Substring(30).Trim();
        }
    }

    public void LerDeLinha(string linha){
        if (linha.Length <= 30){
            palavra = linha.Trim();
            dica = "";
        }
        else{
            palavra = linha.Substring(0, 30).Trim();
            dica = linha.Substring(30).Trim();
        }
    }

    public void EscreverRegistro(StreamWriter arquivo){
        arquivo.WriteLine($"{palavra} ; {dica}");
    }

    public String Arquivar(){
        return $"{palavra};{dica}";
    }

    public override string ToString(){
        return $"{palavra} - {dica}";
    }

    public int CompareTo(Palavra outra){
        if (outra == null) return 1;
        return string.Compare(this.palavra, outra.palavra, StringComparison.OrdinalIgnoreCase);
    }
}


