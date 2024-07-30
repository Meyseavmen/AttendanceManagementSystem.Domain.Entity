using AttendanceManagementSystem.Domain.Entity;
using AttendanceManagementSystem.Application;
using AttendanceManagementSystem.Presentation;
using AttendanceManagementSystem.Infrastructure;

namespace AttendanceManagementSystem;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        TimeSheetDbContext db = new TimeSheetDbContext();
        db.Database.EnsureCreated();
        var emp = db.Employees.FirstOrDefault();
        if(emp == null)
        {
            var aEmp = new Employee()
            {
                FullName = "Admin",
                Position = "Admin",
                CardNo = "001",
                UserAccount = new UserAccount()
                {
                    Username = "Admin",
                    Password = "123"
                }
            };
            db.Employees.Add(aEmp);
            db.SaveChanges();
        }
        var AppTimeSheet = new DBTimeSheet(db);
        var AppAuth = new DBAuthentication(db);
        System.Windows.Forms.Application.Run(new MainForm(AppTimeSheet, AppAuth));

        //var AppTimeSheet = new FileTimeSheet();
        ////load the timeSheet data from timeSheet.Json
        //AppTimeSheet = TimeSheetDataStorage.LoadTimeSheetFromStorage();

        //System.Windows.Forms.Application.Run(new MainForm(AppTimeSheet));
    }
}