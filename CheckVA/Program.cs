using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckVA
{
    class Program
    {
        static void Main(string[] args)
        {
            string _inputPath = Directory.GetCurrentDirectory() + "\\input.txt";
            StreamReader fileIn = new StreamReader(_inputPath);
            StreamWriter fileOut = new StreamWriter("output.txt");
            string line;
            string[] lines;
            int counter = 0;
            while (( line = fileIn.ReadLine())!= null){
                lines =line.Split(';');
                for(int i = 1; i < lines.Count(); i++)
                {
                    if ((lines[i][0] == '0') || ((lines[i][0] == '-') && (lines[i][1] == '0')))
                    {
                        lines[i] = (Convert.ToDecimal(lines[i]) * 1000).ToString("G29"); 
                    }
                }
                fileOut.WriteLine(String.Join(";", lines));
                counter++;
            }
            Console.WriteLine("Done. Press Enter");
            Console.ReadLine();
            fileIn.Close();
            fileOut.Close();
        }
    }
}
