using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DispensaryLibrary
{
    public class Phone
    {
        private string phoneNumber;

        public Phone(string number)
        {
            PhoneNumber = number;
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                if (!IsStandardPhoneNumber(value))
                    throw new IllegalPhoneNumberException($"Неверный формат ввода номера телефона: {value}");
                phoneNumber = value;
            }
        }
        public static List<Phone> GetPhoneList(string input)
        {
            return Regex.Split(input, "; *", RegexOptions.ExplicitCapture).ToList().ConvertAll(s => new Phone(s));
        }
        private bool IsStandardPhoneNumber(string number)
        {
            return Regex.IsMatch(number, @"\(\d{3}\) \d{3}-\d{2}-\d{2}") || number == "";
        }
    }
}
