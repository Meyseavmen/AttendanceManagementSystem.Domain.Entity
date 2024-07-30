using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem.Domain.Entity;

public class UserAccount
{
    public int UserAccountID { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }
    //ForeignKey
    public Guid UserAccounctOfEmployeeId { get; set; }
    //Navigation Property
    public Employee Employee { get; set; }
}
