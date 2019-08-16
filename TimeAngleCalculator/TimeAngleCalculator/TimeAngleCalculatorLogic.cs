using System;
using System.Collections.Generic;
using System.Text;

namespace TimeAngleCalculator
{
    public abstract class TimeAngleCalculatorLogic
    {
        private static readonly double degreesInWatch = 360;
        private static readonly double minutesInWatch = 60;
        private static readonly double hoursInWatch = 12;
        private static readonly double minutesInHour = 60;
        public static double GetAngleBetweenWatchHands(int hour, int minute)
        {
            return GetMinuteHandAngle(minute) - GetHourHandAngle(GetSimplifiedHour(hour), minute);
        }

        private static double GetSimplifiedHour(int hour)
        {
            return hour > hoursInWatch ? hour - hoursInWatch : hour;
        }

        /// <summary>
        /// Gets the angle between origen and the minutes hand in the watch.
        /// </summary>
        private static double GetMinuteHandAngle(int minute)
        {
            var degreesInMinute = degreesInWatch / minutesInWatch;
            return minute * degreesInMinute;
        }

        /// <summary>
        /// Gets the angle between origen and the hours hand in the watch.
        /// </summary>
        private static double GetHourHandAngle(double hour, int minute)
        {
            var degreesInHour = degreesInWatch / hoursInWatch;
            var exactHourAngle = degreesInHour * hour;
            var extraDeegresPerMinute = minute > 0 ? (degreesInHour / minutesInHour) * minute : 0;

            return exactHourAngle + extraDeegresPerMinute;
        }
    }
}
