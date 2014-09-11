using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            // MÉTODOS COM RETORNO
            int idade = 21;
            Console.WriteLine(MeuMetodoQueRetornaString(idade));

            Console.WriteLine(MeuMetodoQueRetornaString(15));
            Console.WriteLine(MeuMetodoQueRetornaString(5));

            bool ehValido = MeuMetodoQueRetornaBool(21);
            Console.WriteLine(ehValido);

            Console.ReadLine();
        }

        static string MeuMetodoQueRetornaString(int idade)
        {
            if (idade < 12)
            {
                return "Criança";
            }
            else if (idade > 20)
            {
                return "Adulto";
            }

            return "Adolescente";
        }

        static bool MeuMetodoQueRetornaBool(int idade)
        {
            if (idade < 21)
            {
                return false;
            }

            return true;
        }
    }
}
