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
                if (counter == 0) { fileOut.WriteLine(String.Join(";", lines)); counter++; continue; }
                for(int i = 1; i < lines.Count(); i++)
                {
                    if ((( new int[] {  1,2,3,7,8,9 }).Contains(i)) && (lines[i]!=""))
                    {
                        if (lines[i][0] == '0')
                        {
                            lines[i] = lines[i].Insert(5, ","); //добавляю запятую в нужное место
                            lines[i] = lines[i].Substring(0, 1) + lines[i].Substring(2); //удаляю первую запятую
                            lines[i] = lines[i].TrimStart('0'); //убираю начальные нули
                        }
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
