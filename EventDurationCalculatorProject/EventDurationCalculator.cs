namespace EventDurationCalculatorProject
{
    internal static class EventDurationCalculator
    {
        public static (DateOnly, int, int) CalculateEnd(DateOnly startDate, int startHour, int startMinute, int durationHours, int durationMinutes)
        {
            if (durationHours < 0) throw new ArgumentException("Az esemény hossza órában nem lehet negatív!", nameof(durationHours));
            if (durationMinutes < 0) throw new ArgumentException("Az esemény hossza percben nem lehet negatív!", nameof(durationMinutes));
            DateTime endDateTime = new DateTime(startDate.Year, startDate.Month, startDate.Day, startHour, startMinute, 0).AddHours(durationHours).AddMinutes(durationMinutes);
            return (new DateOnly(endDateTime.Year, endDateTime.Month, endDateTime.Day), endDateTime.Hour, endDateTime.Minute);
        }
    }
}
