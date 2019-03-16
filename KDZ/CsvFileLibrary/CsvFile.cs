using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace CsvFileLibrary
{
    class CsvFile
    {

        public CsvFile(string path, bool ignoreHeader)
        {
            using (StreamReader s = new StreamReader(path))
            {
                if (ignoreHeader == true)
                {
                    Header = DefaultHeader;
                }
                else
                {
                    Header = s.ReadLine().Split(new char[] { ';' },
                        StringSplitOptions.RemoveEmptyEntries);
                }
                string line;
                while ((line = s.ReadLine()) != null)
                {
                    Fields.Add(Regex.Split(line, "(\"?;\"|\";\"?)").ToList());
                }
            }
        }
        public string[] DefaultHeader { get; private set; } = new string[] {
            "ROWNUM", "FullName",
            "ShortName", "AdmArea", "District", "PostalCode", "Address",
            "ChiefName", "ChiefPosition",   "ChiefGender", "ChiefPhone",
            "PublicPhone", "Fax", "Email", "CloseFlag", "CloseReason",
            "CloseDate", "ReopenDate", "WorkingHours", "ClarificationOfWorkingHours",
            "Specialization",   "BeneficialDrugPrescriptions", "ExtraInfo",
            "POINT_X", "POINT_Y", "GLOBALID" };
        public List<List<string>> Fields { get; private set; }
        public string[] Header { get; private set; }
        public int Length { get; private set; }

        public void Save(string path) // fu
        {
            using (StreamWriter s = new StreamWriter(path))
            {
                s.WriteLine(string.Join(";",Header) + ";");
                for (int i = 0; i < Length; i++)
                {
                    s.WriteLine(string.Join("\";\"", Fields[i].ToArray()) + "\";"); //TODO: Переделать для первого элемента
                }
            }
        }
    }
}
