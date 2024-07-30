using AttendanceManagementSystem.Infrastructure;
namespace AttendanceManagementSystem.Application;
public class DBAuthentication : IAuthentication
{
    private TimeSheetDbContext _context;
    public bool IsAuthenticated { get; set; } = false;
    public DBAuthentication(TimeSheetDbContext context)
    {
        _context = context;
    }
    public bool ValidateLogin(string username, string password)
    {
        if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        {
            throw new ArgumentException("Please provide username and password");
        }
        var user = _context.UserAccounts.Where(u=>u.Username==username.Trim() && u.Password == password.Trim()).FirstOrDefault();
        if (user == null){
            return IsAuthenticated = false;
        }
        return IsAuthenticated = true;
    }
    public void LogOut()
    {
        IsAuthenticated = false;
    }
}
