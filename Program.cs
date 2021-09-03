using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Classe_criar_LOG
{
    class Program
    {

        static void Main(string[] args)
        {
            Log log = new Log();
            for (int i = 0; i < 2000; i++)
            {
                log.criar(i.ToString());
            }
            Console.WriteLine("arquivo criado ");
            Console.ReadLine();
        }
    }
}
