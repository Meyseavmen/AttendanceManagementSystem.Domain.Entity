using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem.Domain.Entity;

public class Log
{
    public Guid Id { get; set; }
    public DateTime? TimeStamp { get; set; }
    public uint TimeShift { get; set; }
    //ForiegnKey
    public Guid CurrentEmployeeId { get; set; }
    //Navigation
    public Employee? Employee { get; set; }
    public Log() { }
    public Log(DateTime Timestamp, uint TimeShift)
    {
        this.Id=Guid.NewGuid();
        this.TimeStamp=Timestamp;
        this.TimeShift=TimeShift;
    }
}
