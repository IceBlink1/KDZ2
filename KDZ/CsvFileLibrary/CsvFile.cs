using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace CsvFileLibrary
{
    public enum DefaultFields
    {
        ROWNUM,
        FullName,
        ShortName,
        AdmArea,
        District,
        PostalCode,
        Address,
        ChiefName,
        ChiefPosition,
        ChiefGender,
        ChiefPhone,
        PublicPhone,
        Fax,
        Email,
        CloseFlag,
        CloseReason,
        CloseDate,
        ReopenDate,
        WorkingHours,
        ClarificationOfWorkingHours,
        Specialization,
        BeneficialDrugPrescriptions,
        ExtraInfo,
        POINT_X,
        POINT_Y,
        GLOBALID
    }
    public class CsvFile
    {

        public CsvFile(string path, bool ignoreHeader)
        {
            using (StreamReader s = new StreamReader(path, Encoding.UTF8))
            {
                if (ignoreHeader)
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
                    Fields.Add(Regex.Split(line, "(\"?;\"|\";\"?)", RegexOptions.ExplicitCapture).ToArray());
                }
                Length = Fields.ToArray().Length;
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
        public List<string[]> Fields { get; set; } = new List<string[]>();
        public string[] Header { get; set; }
        public int Length { get; private set; }

        public void IncLength()
        {
            Length++;
        }
        public void DecLength()
        {
            Length--;
        }

        public void Save(string path)
        {
            using (StreamWriter s = new StreamWriter(path, false, Encoding.UTF8))
            {
                s.WriteLine(string.Join(";", Header) + ";");
                for (int i = 0; i < Length; i++)
                {
                    s.WriteLine(Fields[i][0] + ";\"" +
                        string.Join("\";\"", Fields[i], 1, Fields[i].Length - 1) + "\";");
                }
            }
        }
    }
}
