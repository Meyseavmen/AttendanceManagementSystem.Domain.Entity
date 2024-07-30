using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AttendanceManagementSystem.Domain.Entity;
namespace AttendanceManagementSystem.Application;

public interface ITimeSheet
{
    void AddEmployee(Employee emp);
    void UpdateEmployee(string EmployeetId, string FullName, string Position);
    void LogEmployee(string CardNo, Log logInfo);
    void DeleteEmployee(string EmployeetId);
    bool IsDuplicateCardNo(string cardNo, string employeeId = null);
    bool IsNameValid(string name);
    List<EmployeeView> GetAllEmployee();
    List<Employee> GetAllEmployee(bool isSimpleVersion);
}
