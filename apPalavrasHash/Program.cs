using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apPalavrasHash
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            var tabela = new BucketHash<Palavra>();

            BackgroundColor = ConsoleColor.White;
            ForegroundColor = ConsoleColor.Black;
            //Clear();

            WriteLine("Inserindo chaves");
            for (int i = 0; i < palavrasTeste.Length; i++) {
                tabela.Incluir(palavrasTeste[i]);
            }
            Exibir(tabela.Conteudo());
            EsperarEnter();
            if (tabela.Excluir(new Palavra("Thiago", "Gosta muito de programar")))
                WriteLine("Removeu: Thiago");
            else
                WriteLine("Não achou: Thiago");
            Exibir(tabela.Conteudo());
            EsperarEnter();
        }

       
        static Palavra[] palavrasTeste = new Palavra[]
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
        }

    }
}
            