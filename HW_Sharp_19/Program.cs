using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Sharp_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
                //File numbs read and stat
            //HundredThousandStat test = new HundredThousandStat();
            //test.CreateNGenerate();
            //test.GetStat();
                //Reverse file text
            //TXTFileReverse TFR = new TXTFileReverse();
            //string path = null;
            //path = Console.ReadLine();
            //TFR.reverseFile(path);
                //Get words and exchange them to *
            FileTextModerate FTM = new FileTextModerate();
            string PathToWords = Console.ReadLine();
            string PathToModerate = Console.ReadLine();
            FTM.Moderate(PathToWords, PathToModerate);
        }
    }
}
