using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Sharp_19
{
    internal class TXTFileReverse
    {
        public string pathToRecreation = @"C:\Users\Admin\source\repos\HW_Sharp_19\HW_Sharp_19\ReverseRecreation.txt";
        public void reverseFile(string path)
        {
            StreamReader sr = new StreamReader(path);
            string buff = sr.ReadToEnd();
            sr.Close();
            buff = TXTFileReverse.Reverse(buff);
            StreamWriter wr = new StreamWriter(pathToRecreation);
            wr.Write(buff);
            wr.Close();
            Console.WriteLine($"New file was created by path: {pathToRecreation}");
        }

        private static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
