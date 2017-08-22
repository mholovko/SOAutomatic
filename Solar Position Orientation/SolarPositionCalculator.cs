using System;

namespace SOAutomatic
{
    class SolarPositionCalculator
    {

        static double pi = 3.14159265358979323846;
        static double twopi = (2 * pi);
        static double rad = pi / 180;
        static double dEarthMeanRadius = 6371.01;
        static double dAstronomicalUnit = 149597890;

        public struct SCTime
        {
            public int iYear { get; set; }
            public int iMonth { get; set; }
            public int iDay { get; set; }
            public double dHours { get; set; }
            public double dMinutes { get; set; }
            public double dSeconds { get; set; }
        }

        public struct SCLocation
        {
            public double dLongitude { get; set; }
            public double dLatitude { get; set; }
        }

        public struct SCSunCoordinates
        {
            public double dZenithAngle { get; set; }
            public double dAzimuth { get; set; }
        }
        public static void SolarPositionCalculate(SCTime udtTime, SCLocation udtLocation, ref SCSunCoordinates udtSunCoordinates)
        {
            // Main variables
            double dElapsedJulianDays;
            double dDecimalHours;
            double dEclipticLongitude;
            double dEclipticObliquity;
            double dRightAscension;
            double dDeclination;

            // Auxiliary variables
            double dY;
            double dX;

            // Calculate difference in days between the current Julian Day 
            // and JD 2451545.0, which is noon 1 January 2000 Universal Time
            {
                double dJulianDate;
                long liAux1;
                long liAux2;
                // Calculate time of the day in UT decimal hours
                dDecimalHours = udtTime.dHours + (udtTime.dMinutes + udtTime.dSeconds / 60.0) / 60.0;
                // Calculate current Julian Day
                liAux1 = (udtTime.iMonth - 14) / 12;
                liAux2 = (1461 * (udtTime.iYear + 4800 + liAux1)) / 4 + (367 * (udtTime.iMonth - 2 - 12 * liAux1)) / 12 - (3 * ((udtTime.iYear + 4900 + liAux1) / 100)) / 4 + udtTime.iDay - 32075;
                dJulianDate = (double)(liAux2) - 0.5 + dDecimalHours / 24.0;
                // Calculate difference between current Julian Day and JD 2451545.0 
                dElapsedJulianDays = dJulianDate - 2451545.0;
            }

            // Calculate ecliptic coordinates (ecliptic longitude and obliquity of the 
            // ecliptic in radians but without limiting the angle to be less than 2*Pi 
            // (i.e., the result may be greater than 2*Pi)
            {
                double dMeanLongitude;
                double dMeanAnomaly;
                double dOmega;
                dOmega = 2.1429 - 0.0010394594 * dElapsedJulianDays;
                dMeanLongitude = 4.8950630 + 0.017202791698 * dElapsedJulianDays; // Radians
                dMeanAnomaly = 6.2400600 + 0.0172019699 * dElapsedJulianDays;
                dEclipticLongitude = dMeanLongitude + 0.03341607 * Math.Sin(dMeanAnomaly) + 0.00034894 * Math.Sin(2 * dMeanAnomaly) - 0.0001134 - 0.0000203 * Math.Sin(dOmega);
                dEclipticObliquity = 0.4090928 - 6.2140e-9 * dElapsedJulianDays + 0.0000396 * Math.Cos(dOmega);
            }

            // Calculate celestial coordinates ( right ascension and declination ) in radians 
            // but without limiting the angle to be less than 2*Pi (i.e., the result may be 
            // greater than 2*Pi)
            {
                double dSin_EclipticLongitude;
                dSin_EclipticLongitude = Math.Sin(dEclipticLongitude);
                dY = Math.Cos(dEclipticObliquity) * dSin_EclipticLongitude;
                dX = Math.Cos(dEclipticLongitude);
                dRightAscension = Math.Atan2(dY, dX);
                if (dRightAscension < 0.0)
                    dRightAscension = dRightAscension + twopi;
                dDeclination = Math.Asin(Math.Sin(dEclipticObliquity) * dSin_EclipticLongitude);
            }

            // Calculate local coordinates ( azimuth and zenith angle ) in degrees
            {
                double dGreenwichMeanSiderealTime;
                double dLocalMeanSiderealTime;
                double dLatitudeInRadians;
                double dHourAngle;
                double dCos_Latitude;
                double dSin_Latitude;
                double dCos_HourAngle;
                double dParallax;
                dGreenwichMeanSiderealTime = 6.6974243242 + 0.0657098283 * dElapsedJulianDays + dDecimalHours;
                dLocalMeanSiderealTime = (dGreenwichMeanSiderealTime * 15 + udtLocation.dLongitude) * rad;
                dHourAngle = dLocalMeanSiderealTime - dRightAscension;
                dLatitudeInRadians = udtLocation.dLatitude * rad;
                dCos_Latitude = Math.Cos(dLatitudeInRadians);
                dSin_Latitude = Math.Sin(dLatitudeInRadians);
                dCos_HourAngle = Math.Cos(dHourAngle);
                udtSunCoordinates.dZenithAngle = (Math.Acos(dCos_Latitude * dCos_HourAngle * Math.Cos(dDeclination) + Math.Sin(dDeclination) * dSin_Latitude));
                dY = -Math.Sin(dHourAngle);
                dX = Math.Tan(dDeclination) * dCos_Latitude - dSin_Latitude * dCos_HourAngle;
                udtSunCoordinates.dAzimuth = Math.Atan2(dY, dX);
                if (udtSunCoordinates.dAzimuth < 0.0)
                    udtSunCoordinates.dAzimuth = udtSunCoordinates.dAzimuth + twopi;
                udtSunCoordinates.dAzimuth = udtSunCoordinates.dAzimuth / rad;
                // Parallax Correction
                dParallax = (dEarthMeanRadius / dAstronomicalUnit) * Math.Sin(udtSunCoordinates.dZenithAngle);
                udtSunCoordinates.dZenithAngle = (udtSunCoordinates.dZenithAngle + dParallax) / rad;
            }
        }
    }
}
