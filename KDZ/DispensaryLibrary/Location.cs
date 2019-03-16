using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispensaryLibrary
{
    class Location
    {
        
        public Location(string administrativeArea, string district, double xCoordinate, double yCoordinate)
        {
            DispensaryLocationInfo = new LocationInfo(administrativeArea, district);
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
        }
        public LocationInfo DispensaryLocationInfo { get; private set; }
        public double XCoordinate { get; private set; }
        public double YCoordinate { get; private set; }
        
    }
}
