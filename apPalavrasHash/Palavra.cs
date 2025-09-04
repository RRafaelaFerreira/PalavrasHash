using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Palavra
{
    private String palavra;
    private String dica;

    public Palavra(String palavra, String dica){
        this.palavra = palavra;
        this.dica = dica;
    }

    public String getPalavra() { return palavra; }
    public String getDica() { return dica; }

    public String toString() {
        return palavra + " - " + dica;
    }
}


