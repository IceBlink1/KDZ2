using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Test
{
    class Program
    {
        public static bool Check(string[,] matrix)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (matrix[i, j] == " ")
                        return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            string alphabet = "pqrstuvw";
            string[,] matrix = new string[8, 8] {
                { "v", "w", "u", "t", " ", "r", " ", " " },
{"u"," ", "v", " ","w","t"," ","p"},
{ "w","v","s", " ","u","p"," ", "t" },
{ " ", "r","q","v","p","w"," ", "u"},
{" ", "u", " ","p","v", " "," ", "r"},
{"q"," ", "t","w"," ", "v"," ","s"},
{" ", " "," ", " "," ", " ","v"," " },
{"r"," ","p","u","q","s"," ","v" }
};
            while (Check(matrix))
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (matrix[i, j] == " ")
                        {
                            List<string> list = new List<string>();
                            for (int l = 0; l < 8; l++)
                            {
                                list.Add(matrix[i, l]);
                                list.Add(matrix[l, j]);
                            }
                            List<string> flist = new List<string>();
                            foreach (char c in alphabet)
                            {
                                if (!list.Contains(c.ToString()))
                                    flist.Add(c.ToString());
                            }
                            if (flist.ToArray().Length == 1)
                                matrix[i, j] = flist[0];
                            if (flist.ToArray().Length == 0)
                                throw new ArgumentException();
                        }
                    }
                }
            
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(matrix[i, j].ToUpper() + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
