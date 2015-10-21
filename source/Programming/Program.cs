using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>() { "Joao", "\tMaria", "José" };

            // ESCRITA EM ARQUIVOS
            using (StreamWriter writer = new StreamWriter(@"C:\temp\MeuArquivo.txt"))
            {
                foreach (var item in nomes)
                {
                    writer.WriteLine(item);

                    Console.WriteLine("O nome {0} está sendo escrito no arquivo!", item);
                }
            }

            Console.ReadKey();
        }
    }
}