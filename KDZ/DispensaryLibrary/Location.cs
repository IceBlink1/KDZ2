using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DispensaryLibrary
{
    public class Location
    {

        public Location(string administrativeArea, string district, string xCoordinate, string yCoordinate)
        {
            DispensaryLocationInfo = new LocationInfo(administrativeArea, district);
            if (!IsDouble(xCoordinate) || !IsDouble(yCoordinate))
                throw new IllegalCoordinateException("Не удалось преобразовать координату к числу с плавающей запятой");
            XCoordinate = double.Parse(xCoordinate.Replace('.', ','));
            YCoordinate = double.Parse(yCoordinate.Replace('.', ','));
        }
        public LocationInfo DispensaryLocationInfo { get; private set; }
        public double XCoordinate { get; private set; }
        public double YCoordinate { get; private set; }

        private bool IsDouble(string input)
        {
            return Regex.IsMatch(input, @"\d*\.\d+");
        }
        public override bool Equals(object obj)
        {
            Location location = obj as Location;
            if (location == null)
                return false;
            return location.XCoordinate == XCoordinate && location.YCoordinate == YCoordinate
                && location.DispensaryLocationInfo.Area == DispensaryLocationInfo.Area 
                && location.DispensaryLocationInfo.District == DispensaryLocationInfo.District;
        }
    }
}
