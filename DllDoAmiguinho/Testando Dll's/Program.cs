using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DllPastaWin;

namespace Testando_Dll_s
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentsAutoGenerate documentsAutoGenerate = new DocumentsAutoGenerate();

            documentsAutoGenerate.DeletarPastaMeusDocumentos("PastaWan", true);
            documentsAutoGenerate.ObterPastasDiretorioMeuDocumentos().ForEach(i => Console.WriteLine(i));
            //documentsAutoGenerate.CriarPastaMeusDocumentos("PastaWan");
            Console.ReadLine();
        }
    }
}
