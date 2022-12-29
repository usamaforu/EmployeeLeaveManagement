using DomainEntity.Enum;

namespace DTOs
{
    public class LeaveDto : BaseDto
    {
      
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public LeaveEnum LeaveEnum { get; set; }
        public int EmployeeId { get; set; }
        public Status Status { get; set; }
    }
}
