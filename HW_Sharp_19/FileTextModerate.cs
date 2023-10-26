using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Sharp_19
{
    internal class FileTextModerate
    {
        public void Moderate(string pathToWords, string pathToModerate)
        {
            string buff = null;
            StreamReader words = new StreamReader(pathToWords);
            buff = words.ReadToEnd();
            words.Close();
            char[] separators = {' ', ',', '.', '/', ':', ';', '\\', '\n', '\t', '\b'};
            string[] Replacers = buff.Split(separators);
            StreamReader Replace = new StreamReader(pathToModerate);
            buff = Replace.ReadToEnd();
            Replace.Close();
            StringBuilder star = new StringBuilder();
            foreach (string Replacer in Replacers)
            {
                for (int i = 0; i < Replacer.Length; i++)
                {
                    star.Append('*');
                }
                buff = buff.Replace(Replacer, star.ToString());
                star.Clear();
            }
            StreamWriter rewrite = new StreamWriter(pathToModerate, false);
            rewrite.Write(buff);
            rewrite.Close();
        }
    }
}
