using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;
using System.IO;
using System.Text;

namespace Utilitarios
{
    class Program
    {
        public static object Response { get; private set; }
        public object SeuListBox { get; private set; }

        static void Main(string[] args)
        {





            StreamReader pathSource = new StreamReader(@"C:\Users\alberto.feitoza\Documents\Projetos\Utilitarios\arquivos\entrada\entrada.csv");
            StreamWriter pathExit = new StreamWriter(@"C:\Users\alberto.feitoza\Documents\Projetos\Utilitarios\arquivos\saida\DB.json", true, Encoding.ASCII);


            string iniArray = "[";
            string fimArray = "]";
            string iniDetalhe = "{";
            string fimDetalhe = "}";
            char aspa = '"';
            string tituloDominio = "aplicacao";
            
            string titulo1 = "nome";
            string titulo2 = "rua"; 
            string titulo3 = "cep";
            string titulo4 = "complemento";
            string igual = ":";
            char proximo = ',';
            string bteQtdWhiteSpace = "          ";





            string linha = null;
            int cont = 0;
            int contAnterior = cont - 2;

            while ((linha = pathSource.ReadLine()) != null)
            {
                string[] coluna = linha.Split(';');

                if (cont == 0)
                {
                    pathExit.WriteLine(iniDetalhe + "\n"
                                               + aspa
                                               + tituloDominio
                                               + aspa
                                               + igual
                                               + iniArray
                                           );
                }else if (cont == 1) { 
                                       pathExit.Write(bteQtdWhiteSpace + iniDetalhe + "\n" +
                                       bteQtdWhiteSpace + aspa + titulo1 + aspa + igual + aspa + coluna[0] + aspa + proximo + "\n" +
                                       bteQtdWhiteSpace + aspa + titulo2 + aspa + igual + aspa + coluna[1] + aspa + proximo + "\n" +
                                       bteQtdWhiteSpace + aspa + titulo3 + aspa + igual + aspa + coluna[2] + aspa + proximo + "\n" +
                                       bteQtdWhiteSpace + aspa + titulo4 + aspa + igual + aspa + coluna[3] + aspa + "\n" +
                                       bteQtdWhiteSpace + fimDetalhe
                                        );
                }else {
                                       pathExit.Write(proximo + "\n" +
                                       bteQtdWhiteSpace + iniDetalhe + "\n" +
                                       bteQtdWhiteSpace + aspa + titulo1 + aspa + igual + aspa + coluna[0] + aspa + proximo + "\n" +
                                       bteQtdWhiteSpace + aspa + titulo2 + aspa + igual + aspa + coluna[1] + aspa + proximo + "\n" +
                                       bteQtdWhiteSpace + aspa + titulo3 + aspa + igual + aspa + coluna[2] + aspa + proximo + "\n" +
                                       bteQtdWhiteSpace + aspa + titulo4 + aspa + igual + aspa + coluna[3] + aspa + "\n" +
                                       bteQtdWhiteSpace + fimDetalhe
                                        );
                }
                cont += 1;
            }
                                       pathExit.WriteLine("\n" + 
                                                          fimArray + 
                                                          "\n" +
                                                          fimDetalhe);
            pathSource.Close();
            pathExit.Close();
        }
    }
}
