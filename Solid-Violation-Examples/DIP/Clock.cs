namespace Solid_Violation_Examples.DIP
{
    public class Clock
    {
        public DateOnly MonthDay()
        {
            var today = DateOnly.FromDateTime(DateTime.Today);
            return new DateOnly(1, today.Month, today.Day);
        }
    }
}
