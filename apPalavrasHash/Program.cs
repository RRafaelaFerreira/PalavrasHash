using System;
using System.IO;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apPalavrasHash
{
    public static class Program
    {
        [STAThread]


        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            var tabelaBucket = new BucketHash<Palavra>();
            var tabelaSimples = new HashSimples<Palavra>(101);
            var tabelaQuadratica = new SondagemQuadratica<Palavra>(101);
            var tabelaLinear = new SondagemLinear<Palavra>(101);
            var tabelaHashDuplo = new HashDuplo<Palavra>(101);

            BackgroundColor = ConsoleColor.White;
            ForegroundColor = ConsoleColor.Black;


            //TESTANDO OS HASH E SONDAGENS

            /*WriteLine("TESTANDO BUCKET HASH");
            WriteLine("Inserindo chaves");
            for (int i = 0; i < palavrasTeste.Length; i++) {
                tabelaBucket.Incluir(palavrasTeste[i]);
            }
            Exibir(tabelaBucket.Conteudo());
            EsperarEnter();
            if (tabelaBucket.Excluir(new Palavra("Thiago", "Gosta muito de programar")))
                WriteLine("Removeu: Thiago");
            else
                WriteLine("Não achou: Thiago");
            Exibir(tabelaBucket.Conteudo());
            EsperarEnter();

            WriteLine("---------------------------------------------------------------");
            WriteLine("TESTANDO HASH SIMPLES");
            WriteLine("Inserindo chaves");
            for (int i = 0; i < palavrasTeste.Length; i++) {
                tabelaSimples.Incluir(palavrasTeste[i]);                
            }
            Exibir(tabelaSimples.Conteudo());
            EsperarEnter();
            if (tabelaSimples.Excluir(new Palavra("Rafaela", "miau miau")))
                WriteLine("Palavra e dica removida!");
            else
                WriteLine("Palavra não encontrada");
            Exibir(tabelaSimples.Conteudo());
            EsperarEnter();

            WriteLine("---------------------------------------------------------------");
            WriteLine("TESTANDO HASH DUPLO");
            WriteLine("Inserindo chaves");
            for (int i = 0; i < palavrasTeste.Length; i++)
            {
                tabelaHashDuplo.Incluir(palavrasTeste[i]);
            }
            Exibir(tabelaHashDuplo.Conteudo());
            EsperarEnter();
            if (tabelaHashDuplo.Excluir(new Palavra("Rafaela", "miau miau")))
                WriteLine("Palavra e dica removida!");
            else
                WriteLine("Palavra não encontrada");
            Exibir(tabelaHashDuplo.Conteudo());
            EsperarEnter();

            WriteLine("---------------------------------------------------------------");
            WriteLine("TESTANDO SONDAGEM QUADRATICA");
            WriteLine("Inserindo chaves");
            for (int i = 0; i < palavrasTeste.Length; i++)
            {
                tabelaQuadratica.Inserir(palavrasTeste[i]);
            }

            Exibir(tabelaQuadratica.Listar());
            EsperarEnter();

            if (tabelaQuadratica.Remover(new Palavra("Rafaela", "miau miau")))
                WriteLine("Palavra e dica removida!");
            else
                WriteLine("Palavra não encontrada");
            
            Exibir(tabelaQuadratica.Listar());
            EsperarEnter();

            WriteLine("---------------------------------------------------------------");
            WriteLine("TESTANDO SONDAGEM LINEAR");
            WriteLine("Inserindo chaves");
            for (int i = 0; i < palavrasTeste.Length; i++)
            {
                tabelaLinear.Inserir(palavrasTeste[i]);
            }
            
            Exibir(tabelaLinear.Listar());
            EsperarEnter();
            
            if (tabelaLinear.Remover(new Palavra("Rafaela", "miau miau")))
                WriteLine("Palavra e dica removida!");
            else
                WriteLine("Palavra não encontrada");
            
            Exibir(tabelaLinear.Listar());
            EsperarEnter();
        }*/



            /*static Palavra[] palavrasTeste = new Palavra[]
            { 
                new Palavra("Thiago","Gosta muito de programar"),
                new Palavra("Rafaela","miau miau"),
                new Palavra("Chocolate","Feito da fruta do cacaueiro"),
                new Palavra("Peixe","Mar"),
                new Palavra("Tartaruga marinha","Cágado, só que do mar"),
            };
            static void EsperarEnter() {
                Write("Pressione [Enter]");
                ReadLine();
            }

            static void Exibir(List<String> lista) {
                foreach (string item in lista)
                    WriteLine(item);
            }*/

        }
    }
}
            
