using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DispensaryLibrary
{
    class Dispensary
    {
        private string email;
        private string globalID;

        public Dispensary(string fullName, string shortName, Location location, int postalCode,
            string adress, Chief chief, List<Phone> publicPhones, Phone fax, CloseInfo close, 
            string clarification, string specialization, string drugPrescriptions, 
            string extraInfo, string email, string id)
        {
            FullName = fullName;
            ShortName = ShortName;
            DispensaryLocation = location;
            PostalCode = postalCode;
            Adress = adress;
            DispensaryChief = chief;
            PublicPhones = publicPhones;
            Fax = fax;
            Close = close;
            ClarificationOfWorkingHours = clarification;
            Specialization = specialization;
            BeneficialDrugPrescriptions = drugPrescriptions;
            ExtraInfo = extraInfo;
            Email = email;
            GlobalID = id;
        }
        public int Rownum { get; private set; }
        public string FullName { get; private set; }
        public string ShortName { get; private set; }
        public Location DispensaryLocation { get; private set; }
        public int PostalCode { get; private set; }
        public string Adress { get; private set; }
        public Chief DispensaryChief { get; private set; }
        public List<Phone> PublicPhones { get; private set; }
        public Phone Fax { get; private set; }
        public CloseInfo Close { get; private set; }
        public string ClarificationOfWorkingHours { get; private set; }
        public string Specialization { get; private set; }
        public string BeneficialDrugPrescriptions { get; private set; }
        public string ExtraInfo { get; private set; }
        public string Email
        {
            get { return email; }
            private set
            {
                if (!IsAppropriateEmail(value))
                    throw new IllegalEmailException("Неверный формат email: " + value);
                email = value;
            }
        }

        public string GlobalID
        {
            get { return globalID; }
            set
            {
                if (!Regex.IsMatch(value, @"\d+"))
                    throw new IllegalIDException("Неверный Global ID");
                globalID = value;
            }
        }

        private bool IsAppropriateEmail(string email)
        {
            return Regex.IsMatch(email, @".+@.+\..+") || string.IsNullOrEmpty(email);
        }
    }
}
