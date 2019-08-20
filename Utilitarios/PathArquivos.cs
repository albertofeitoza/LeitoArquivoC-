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
    class PathArquivos
    {


        public string entrada()
        {
            StreamReader pathSource = new StreamReader(@"C:\Users\alberto.feitoza\Documents\Projetos\Utilitarios\arquivos\entrada\entrada.csv");
            return pathSource;

        }




    }
}
