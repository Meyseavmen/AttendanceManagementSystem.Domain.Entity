using Microsoft.EntityFrameworkCore;
using AttendanceManagementSystem.Domain.Entity;
using AttendanceManagementSystem.Infrastructure;

namespace AttendanceManagementSystem.Application;

public class DBTimeSheet : ITimeSheet
{
    private TimeSheetDbContext _dbContext;
    public DBTimeSheet(TimeSheetDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public void AddEmployee(Employee emp)
    {
        if (string.IsNullOrEmpty(emp.FullName) ||
           string.IsNullOrEmpty(emp.Position) ||
           string.IsNullOrEmpty(emp.CardNo) ||
           string.IsNullOrEmpty(emp.UserAccount.Username) ||
           string.IsNullOrEmpty(emp.UserAccount.Password)){
            throw new ArgumentException("Please provide all employee data!");
        }
        else
        {
            _dbContext.Employees.Add(emp);
            _dbContext.SaveChanges();
        }
    }
    public void UpdateEmployee(string EmployeeId, string Fullname, string Position)
    {
        //Check for empty data
        if(string.IsNullOrEmpty(Fullname) || string.IsNullOrEmpty(Position))
        {
            throw new ArgumentException("Please provide all employee data!");
        }
        var emp = _dbContext.Employees.Find(new Guid(EmployeeId));
        if (emp == null)
        {
            throw new ArgumentException("Employee not found!");
        }
        //update the employee data
        emp.FullName = Fullname;
        emp.Position = Position;
        _dbContext.SaveChanges();
    }
    public void LogEmployee(string cardNo, Log logInfo) 
    {
        if (string.IsNullOrEmpty(cardNo))
        {
            throw new ArgumentException("Card No is empty!");
        }
        var emp = _dbContext.Employees.Include(l=>l.Logs).FirstOrDefault(emp=>emp.CardNo == cardNo.Trim());
        if (emp == null)
        {
            throw new ArgumentException($"Card No { cardNo} not found in employee list.");
        }
        emp.Logs!.Add(logInfo);
        _dbContext.SaveChanges();
    }
    public List<EmployeeView> GetAllEmployee()
    {
        return _dbContext.Employees.Select(emp=>new EmployeeView()
        {
            EmployeeId = emp.EmployeeId,
            FullName = emp.FullName,
            Position = emp.Position,
            CardNo = emp.CardNo
        }).ToList();
    }
    public List<Employee> GetAllEmployee(bool isSimpleVersion)
    {
        return _dbContext.Employees.ToList();
    }
    public void DeleteEmployee(string EmployeetId) { }
    public bool IsDuplicateCardNo(string cardNo, string employeeId = null) { return true; }
    public bool IsNameValid(string name) { return true; }
}
