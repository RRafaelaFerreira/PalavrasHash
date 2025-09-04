using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IHashTable
{
    void Inserir(Palavra p);                       // Insere a palavra e a dica
    bool Remover(string palavra);                  // Remover a palavra
    bool AlterarDica(string palavra, string novaDica); // Altera a dica
    void Listar();                                 // Listar todas as palavras e dicas
    void SalvarEmArquivo(string caminho);          // Salvar tabela no arquivo
    void CarregarDeArquivo(string caminho); // pega do próprio arquivo pra listar
}
