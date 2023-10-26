using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HW_Sharp_19
{
    internal class HundredThousandStat
    {
        public string path = @"C:\Users\Admin\source\repos\HW_Sharp_19\HW_Sharp_19\HundredThousandStat.txt";
        public void CreateNGenerate()
        {
            StreamWriter writer = new StreamWriter(path, false);
            Random random = new Random();
            for (int i = 0; i < 99999; i++)
            {
                int next = random.Next();
                writer.Write((next % 2 == 0 ? next : next * -1));
                writer.Write(',');
            }
            writer.Close();
        }
        public void GetStat()
        {
            StreamReader reader = new StreamReader(path);
            string buff = reader.ReadToEnd();
            reader.Close();
            string[] numbs = buff.Split(',');
            int cAboveZero = 0;
            int cBelowZero = 0;
            int cTwoDigitNumbs = 0;
            int cFiveDigitNumbs = 0;
            foreach(string num in numbs)
            {
                int.TryParse(num, out int j);
                if (j >= 0)
                {
                    cAboveZero++;
                }
                else
                {
                    cBelowZero++;
                }
                if (j > 9 && j < 100 || j < -9 && j > -100)
                {
                    cTwoDigitNumbs++;
                }
                else if (j > 9999 && j < 100000 || j < -9999 && j > -100000)
                {
                    cFiveDigitNumbs++;
                }
            }
            Console.WriteLine($"Number:\nBelove zero: {cBelowZero}\nAbove zero: {cAboveZero}\nTwo-digits: {cTwoDigitNumbs}" +
                $"\nFive-digits: {cFiveDigitNumbs}");
        }
    }
}
