using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            databaseClass db = new databaseClass();
            db.selecionar("clientes");
            db.selecionar("clientes", "*");
            db.selecionar("clientes", "nome", "WHERE id = 1");
            Console.ReadLine();
        }
    }
}
