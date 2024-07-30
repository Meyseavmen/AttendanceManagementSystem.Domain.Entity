using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AttendanceManagementSystem.Domain.Entity;
namespace AttendanceManagementSystem.Application;

public class FileTimeSheet : ITimeSheet
{
    public List<Employee>? Employees { get; set; }
    public FileTimeSheet()
    {
        Employees = new List<Employee>();
    }
    public void AddEmployee(Employee emp)
    {
        if (string.IsNullOrEmpty(emp.FullName) ||
            string.IsNullOrEmpty(emp.Position) ||
            string.IsNullOrEmpty(emp.CardNo)){
            throw new ArgumentException("Please provide all employee data!");
        } else
        {
            Employees?.Add(emp);
        }
    }
    public void UpdateEmployee(string EmployeeId, string FullName, string Position)
    {
        if(string.IsNullOrEmpty(FullName)||string.IsNullOrEmpty(Position)) { throw new ArgumentException("Please provide all employee data!");
        }
        int foundIndex = Employees!.FindIndex(em => em.EmployeeId == new Guid(EmployeeId));
        Employees[foundIndex].FullName = FullName;
        Employees[foundIndex].Position = Position;
    }
    public void LogEmployee(string cardNo, Log logInfo)
    {
        if (string.IsNullOrEmpty(cardNo))
        {
            throw new ArgumentException("Card No is Empty!");
        }
        int foundIndex = Employees!.FindIndex(emp => emp.CardNo == cardNo.Trim());
        if(foundIndex < 0)
        {
            throw new ArgumentException($"Card No{cardNo} not found in employee list.");
        }
        Employees[foundIndex].Logs!.Add(logInfo);
    }
    public List<EmployeeView> GetAllEmployee()
    {
        return Employees!.Select(emp => new EmployeeView()
        {
            EmployeeId = emp.EmployeeId,
            FullName = emp.FullName,
            Position = emp.Position,
            CardNo = emp.CardNo
        }).ToList();
    }
    public List<Employee> GetAllEmployee(bool isSimpleVersion)
    {
        return Employees!;
    }

    public void DeleteEmployee(string EmployeetId)
    {
        var employeeGuid = new Guid(EmployeetId);
        var employee = Employees!.FirstOrDefault(e => e.EmployeeId == employeeGuid);
        if (employee == null)
        {
            throw new ArgumentException("Employee not found!");
        }
        Employees.Remove(employee);
    }
    public bool IsDuplicateCardNo(string cardNo, string employeeId = null)
    {
        if (!cardNo.All(char.IsDigit))
        {
            throw new ArgumentException("Card number must contain only digits.");
        }
        return Employees!.Any(emp => emp.CardNo == cardNo && (employeeId == null || emp.EmployeeId.ToString() != employeeId));
    }
    public bool IsNameValid(string name)
    {
        if (string.IsNullOrWhiteSpace(name) || name.Length < 2)
            return false;

        // Split the name by spaces and check each part
        var parts = name.Split(' ');
        foreach (var part in parts)
        {
            if (part.Length < 2 || !part.All(char.IsLetter))
                return false;
        }

        return true;
    }


}
