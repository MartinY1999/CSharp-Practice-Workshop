using System;

namespace Weekdays
{
    public class WeeklyEntry : IComparable<WeeklyEntry>
    {
        private Weekday weekDay;
        private string notes;
        public WeeklyEntry(string weekDay, string notes)
        {
            Enum.TryParse(weekDay, out this.weekDay);
            this.notes = notes;
        }


        public int CompareTo(WeeklyEntry other)
        {
            if (ReferenceEquals(this, other))
                return 0;
            if (ReferenceEquals(null, other))
                return 1;
            int weekDayComparision = this.weekDay.CompareTo(other.weekDay);
            if (weekDayComparision != 0)
                return weekDayComparision;
            return string.Compare(this.notes, other.notes, StringComparison.Ordinal);
        }

        public override string ToString()
        {
            return $"{weekDay} {notes}";
        }
    }
}
