using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class databaseClass
    {
        public void selecionar(string tabela)
        {
            Console.WriteLine("Select * from " + tabela + ";");
        }

        public void selecionar(string tabela, string linha = "*")
        {
            Console.WriteLine("Select " + linha + " from " + tabela + ";");
        }

        public void selecionar(string tabela, string linha, string condicao)
        {
            Console.WriteLine("Select " + linha + " from " + tabela + " " + condicao + ";");
        }
    }
}
