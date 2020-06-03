using System.Collections.Generic;

namespace Weekdays
{
    public class WeeklyCalendar
    {
        public List<WeeklyEntry> WeeklySchedule { get; }

        public WeeklyCalendar()
        {
            this.WeeklySchedule = new List<WeeklyEntry>();
        }

        public void AddEntry(string weekDay, string notes)
        {
            this.WeeklySchedule.Add(new WeeklyEntry(weekDay, notes));
        }
    }
}
