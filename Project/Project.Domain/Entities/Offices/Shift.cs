namespace Project.Domain.Entities.Offices;

public class Shift:BaseEntity.BaseEntity
{
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }

    public long WorkCalendarId { get; set; }
    public WorkCalendar WorkCalendar { get; set; }

}