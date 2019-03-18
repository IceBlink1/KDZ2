using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DispensaryLibrary
{
    public class Chief
    {
        readonly string MaleGender = "мужской";
        readonly string NamePattern = "^[А-ЯЁ][а-яё]* [А-ЯЁ][а-яё]* [А-ЯЁ][а-яё]*$";
        private string name;

        public Chief(string chiefPosition, string chiefGender, string chiefName, string phones)
        {
            ChiefName = chiefName;
            ChiefPosition = chiefPosition;
            ChiefGender = GetBoolGender(chiefGender);
            Phones = Phone.GetPhoneList(phones);
        }

        public string ChiefPosition { get; private set; }
        public bool ChiefGender { get; private set; }
        public string ChiefName
        {
            get { return name; }
            set
            {
                if (!IsAppropriateName(value))
                    throw new IllegalChiefNameException("Имя начальника содержит недопустимые символы");
                name = value;
            }
        }
        public List<Phone> Phones { get; private set; }

        private bool IsAppropriateName(string name)
        {
            return Regex.IsMatch(name, NamePattern);
        }
        private bool GetBoolGender(string chiefGender)
        {
            return chiefGender.ToLower() == MaleGender;
        }
    }
}
