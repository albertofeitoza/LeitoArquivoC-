using System;
using System.IO;

namespace Utilitarios
{
    internal class Document
    {
        private StreamReader pathSourceRTF;
        private object html;

        public Document(StreamReader pathSourceRTF, object html)
        {
            this.pathSourceRTF = pathSourceRTF;
            this.html = html;
        }

        internal void SaveToFile(string v, object rtf)
        {
            throw new NotImplementedException();
        }
    }
}