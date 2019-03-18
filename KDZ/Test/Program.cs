using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using CsvFileLibrary;

namespace Test
{
    class Program
    {
       static void Main(string[] args)
       {
            CsvFile file = new CsvFile(@"H:\6ekrzaden\KDZ2-master\KDZ\test.csv", false);
            file.Save(@"H:\6ekrzaden\KDZ2-master\KDZ\test.csv");
       }        
    }
}
