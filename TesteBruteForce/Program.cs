using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;

namespace TesteBruteForce
{
    class Program
    {

        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            key = Console.ReadKey(true);
            string retorno;
            Console.WriteLine("> iniciando o BruteForce");
            do
            {
                Console.WriteLine("Digite a senha: ");
                funcaoPrincipal();
                Console.Clear();
                Console.WriteLine("Deseja testar novamente?");
                Console.WriteLine("S - para sim ");
                Console.WriteLine("N - para não ");
                retorno = Console.ReadLine().ToUpper();
                Console.Clear();

            }
            while (retorno == "S"); 


        }

        static void funcaoPrincipal()
        {
            string senha = Console.ReadLine();

            string[] vetorSenha = quebraString(senha);
            string[] possibilidades = passWord();

            Console.WriteLine(probabilidades(vetorSenha, possibilidades) + senha);

            //para aguardar comando finalizar
            Console.ReadLine();
        }


        static string probabilidades(string[] senhaDigitada, string[] vetorChars)
        {
            string retorno = string.Empty;
            int iteracao = 0;

            for (int i = 0; i < vetorChars.Length; i++)
            {
                for (int j = 0; j < senhaDigitada.Length; j++)
                {
                    if (senhaDigitada[j] == vetorChars[i])
                    {
                        retorno = retorno + senhaDigitada[j];
                    }
                    iteracao++;
                }
            }

            string retornoFormatado = $@"Foram efetuadas {iteracao} tentativas de comparação para chegar a senha digitada ";

            return retornoFormatado;
        }

        static string[] quebraString(string senha)
        {
            string[] vetor = new string[senha.Length];

            for (int i = 0; i < senha.Length; i++)
            {
                vetor[i] = senha.Substring(i, 1);
            }
            return vetor;
        }

        static string[] passWord()
        {
            string[] aux = new string[256];
            for (int i = 0; i < aux.Length; i++)
            {
                aux[i] = char.ConvertFromUtf32(i);
                //Console.WriteLine(i + " => " + aux[i]);
            }

            return aux;
        }

        static string charValid(string atual)
        {
            string novaString = string.Empty;

            return novaString;
        }
    }
}
