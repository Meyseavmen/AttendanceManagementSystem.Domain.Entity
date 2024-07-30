using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem.Application;

public interface IAuthentication
{
    //Define property
    bool IsAuthenticated { get; }
    //Define methods
    bool ValidateLogin(string username, string password);
    void LogOut();
}
