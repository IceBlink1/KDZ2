using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DispensaryLibrary
{
    public class Dispensary
    {
        private string email;
        private string globalID;
        private string postalCode;

        public Dispensary(string fullName, string shortName, string administrariveArea, string district,
            string xCoordinate, string yCoordinate, string postalCode,
            string adress, string chiefName, string chiefPosition, string chiefGender, string chiefPhones,
            string publicPhones, string fax, string closeFlag, string closeReason, string closeDate,
            string reopenDate, string clarificationOfWorkingHours, string specialization, string drugPrescriptions,
            string extraInfo, string email, string id, int rowNum)
        {
            FullName = fullName;
            ShortName = shortName;
            DispensaryLocation = new Location(administrariveArea, district, xCoordinate, yCoordinate);
            PostalCode = postalCode;
            Adress = adress;
            DispensaryChief = new Chief(chiefPosition, chiefGender, chiefName, chiefPhones);
            PublicPhones = Phone.GetPhoneList(publicPhones);
            Fax = new Phone(fax);
            if (closeFlag.ToLower() == "действует")
            {
                if (!string.IsNullOrEmpty(closeReason) || !string.IsNullOrEmpty(closeDate) || !string.IsNullOrEmpty(reopenDate))
                    throw new IllegalCloseInfoException("Одно из полей CloseReason, CloseDate или ReopenDate не пусто при действующем CloseFlag");
                Close = new CloseInfo();
            }
            else
                Close = new CloseInfo(closeReason, StringToDateTime(closeDate), StringToDateTime(reopenDate));
            ClarificationOfWorkingHours = clarificationOfWorkingHours;
            Specialization = specialization;
            BeneficialDrugPrescriptions = drugPrescriptions;
            ExtraInfo = extraInfo;
            Email = email;
            GlobalID = id;
            Rownum = rowNum;
        }
        public int Rownum { get; private set; }
        public string FullName { get; private set; }
        public string ShortName { get; private set; }
        public Location DispensaryLocation { get; private set; }
        public string PostalCode
        {
            get
            {
                return postalCode;
            }
            private set
            {
                if (!Regex.IsMatch(value, @"\d+"))
                    throw new IllegalPostalCodeException("Почтовый индекс не соответствует паттерну");
                postalCode = value;
            }
        }
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

        private DateTime StringToDateTime(string date)
        {
            if (!Regex.IsMatch(date, @"\d{2}\.\d{2}.\d{4}"))
                throw new IllegalDateException("Неверно задана дата");
            int[] arr = Array.ConvertAll(date.Split('.'), s => int.Parse(s));
            return new DateTime(arr[2], arr[1], arr[0]);
        }

        public override bool Equals(object obj)
        {
            Dispensary disp = obj as Dispensary;
            if (disp == null)
                return false;
            return disp.DispensaryLocation == DispensaryLocation;
        }
    }
}
