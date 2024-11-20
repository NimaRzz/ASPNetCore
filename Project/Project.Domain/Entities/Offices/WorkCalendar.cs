namespace Project.Domain.Entities.Offices;

public class WorkCalendar:BaseEntity.BaseEntity
{
    // تاریخ و زمان شروع و پایان هر روز کاری
    public DateTime WorkStart { get; set; }
    public DateTime WorkEnd { get; set; }

    // لیست تعطیلات
    public List<DateTime> Holidays { get; set; }

    // لیست شیفت‌ها (مثال: 9:00 AM - 5:00 PM)
    public ICollection<Shift> Shifts { get; set; }

    public Office Office { get; set; }

    public string OfficeId { get; set; }

}