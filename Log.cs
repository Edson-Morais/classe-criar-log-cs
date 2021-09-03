using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_criar_LOG
{
    public class Log
    {
        static string pastausuario = Environment.GetEnvironmentVariable("HOMEPATH");// caminho padrão pasta usuário
        string diretorio = pastausuario + @"\Documents\";// caminho pasta documentos
        string nomePasta = "LOG";//nome da pasta
        string nomeArquivo = "log.txt";// nome do arquivo


        public Log()
        {
            
        }
        public void criar(string log)
        {
            FileInfo file = new FileInfo(diretorio+"\\"+nomePasta);// passa o diretorio da pasta log
            //confere se já existe a pasta
            if (file.Exists)
            {               
                StreamWriter arquivo = new StreamWriter(diretorio + "\\" + nomePasta + "\\" + nomeArquivo, true);
                arquivo.WriteLine(log + " " + DateTime.Now.ToString());
                arquivo.Close();
            }
            else
            {
                DirectoryInfo raiz = new DirectoryInfo(diretorio);
                raiz.CreateSubdirectory(nomePasta);
                StreamWriter arquivo = new StreamWriter(diretorio + "\\" + nomePasta + "\\" + nomeArquivo, true);
                arquivo.WriteLine(log + " " + DateTime.Now.ToString());
                arquivo.Close();
            }
        }
    }
}
