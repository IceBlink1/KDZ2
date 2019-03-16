using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DispensaryLibrary
{
    class Chief
    {
        private string name;

        public Chief(string chiefPosition, string chiefGender, string chiefName, string phones)
        {
            ChiefName = chiefName;
            ChiefPosition = chiefPosition;
            ChiefGender = GetBoolGender(chiefGender);
            foreach (string phone in phones.Split(';'))
            {
                Phones.Add(new Phone(phone));
            }
        }

        public string ChiefPosition { get; private set; }
        public bool ChiefGender { get; private set; }
        public string ChiefName
        {
            get { return name; }
            set
            {
                if (!IsAppropriateName(value))
                    throw new IllegalChiefNameException("");
                name = value;
            }
        }
        public List<Phone> Phones { get; private set; }

        private bool IsAppropriateName(string name)
        {
            return Regex.IsMatch(name, "^[А-ЯЁ][а-яё]* [А-ЯЁ][а-яё]* [А-ЯЁ][а-яё]*$");
        }
        private bool GetBoolGender(string chiefGender)
        {
            return chiefGender.ToLower() == "мужской";
        }
    }
}
