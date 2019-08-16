using System;
using Xunit;

namespace TimeAngleCalculator.Tests
{
    public class TimeAngleCalculatorLogicTest
    {
        [Fact]
        public void GetAngleBetweenWatchHands_ExactHourTest1()
        {
            var hour = 6;
            var minute = 45;
            var minuteAngle = 180 + ((30/60.0) * minute);

            var result = TimeAngleCalculator.TimeAngleCalculatorLogic.GetAngleBetweenWatchHands(hour, minute);

            Assert.Equal(minuteAngle - 180, result);
        }

    }
}
